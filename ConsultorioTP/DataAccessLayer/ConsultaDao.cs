﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class ConsultaDao
    {
        string sentencia;

        public IList<Consulta> GetAll()
        {
            List<Consulta> listadoPrac = new List<Consulta>();

            var strSql = "SELECT id_insumo, nombre, stock FROM insumo where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPrac.Add(crearObjConsulta(row));
            }

            return listadoPrac;
        }

        public Consulta GetConsulta(int id)
        {
            String consultaSql = string.Concat(" SELECT id_insumo, nombre, stock",
                                               "   FROM insumo ",
                                               "  WHERE id_insumo = ", id);

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return crearObjConsulta(resultado.Rows[0]);
            }

            return null;
        }
        private Consulta crearObjConsulta(DataRow row)
        {
            Consulta oConsulta = new Consulta();
            oConsulta.Fecha = Convert.ToDateTime(row["fecha"].ToString());
            oConsulta.Id_consulta = Convert.ToInt32(row["id_consulta"].ToString());
            oConsulta.Id_paciente = Convert.ToInt32(row["id_paciente"].ToString());
            oConsulta.Practicas_realizadas = row["practicas_realizadas"].ToString();
            oConsulta.Id_profesional = Convert.ToInt32(row["id_profesional"].ToString());
            oConsulta.Monto = Convert.ToInt32(row["monto"].ToString());
            oConsulta.Observacion = row["observacion"].ToString();
            oConsulta.Num_turno = Convert.ToInt32(row[0].ToString());
            oConsulta.Cobrado = Convert.ToBoolean(row["cobrado"]);

            return oConsulta;
        }

        internal DataTable recuperarPacientePorProfesionalPorFecha(DateTime desde, DateTime hasta)
        {
            String consultaSql = string.Concat("Select p.apellido, COUNT(c.id_paciente) as 'cantidad de paceintes'",
                                               " From consulta c Join profesional p on(c.id_profesional = p.matricula) ",
                                               "Where fecha between '", desde.ToString("yyyy-MM-dd"), "' and '", hasta.ToString("yyyy-MM-dd"), " 23:59:59' ",
                                                "Group by p.apellido");
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }

        public bool crearConsulta(Consulta oConsulta)
        {
            DataManager dm = new DataManager();
            try
            {
                int cobrado = 0;
                string[] listaPracticas;
                listaPracticas = new[] { oConsulta.Practicas_realizadas };
                if (oConsulta.Cobrado) { cobrado = 1; }
                //Select @@identity obtiene el identity insertado
                string sql = "INSERT INTO consulta(fecha, id_paciente, id_profesional, practicas_realizadas, cobrado, monto, num_turno, observacion, borrado) " +
                            "   VALUES('"
                            + oConsulta.Fecha.ToString("yyyy-MM-dd") + "', '"
                            + oConsulta.Id_paciente + ", "
                            + oConsulta.Id_profesional + ", '"
                            + oConsulta.Practicas_realizadas + "' , "
                            + cobrado + ", "
                            + oConsulta.Monto + ", "
                            + oConsulta.Num_turno + ", '"
                            + oConsulta.Observacion + "', 0)";

                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert del turno
                dm.EjecutarSQL(sql);

                var idConsulta = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

                //Guarda en numTurno el identity generado

                oConsulta.Id_consulta = Convert.ToInt32(idConsulta);

                string sqlhisto = "INSERT INTO historial_turnos(num_turno, estado) VALUES(" + oConsulta.Num_turno + "'consulta realizada')";

                dm.EjecutarSQL(sqlhisto);

                string sqlhistoClin = "INSERT INTO historial_clinico(id_paciente, fecha_consulta, id_consulta, borrado) VALUES("+ oConsulta.Id_paciente + ", " + oConsulta.Fecha + ", " + oConsulta.Id_consulta + ", 0)";

                dm.EjecutarSQL(sqlhistoClin);

                string sqlInsumos;

                foreach(string id_prac in listaPracticas)
                {
                    sqlInsumos = "UPDATE insumo SET stock = (stock - (SELECT cantidad FROM insumo_x_practica WHERE id_practica = " + id_prac + " AND id_insumo = " + /*buscar id insumo + */ ")) WHERE id_insumo = ";
                    dm.EjecutarSQL(sqlInsumos);
                }


                dm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
        }
    }
}
