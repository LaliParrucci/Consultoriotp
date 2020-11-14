using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;
using System.Reflection.Emit;

namespace Consultorio.DataAccessLayer
{
    class ConsultaDao
    {
        string sentencia;

        public IList<Consulta> GetAll()
        {
            List<Consulta> listadoConsultas = new List<Consulta>();

            var strSql = "SELECT id_consulta, fecha, id_paciente, cobrado, id_profesional" +
                ", monto, num_turno, observacion FROM consulta";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoConsultas.Add(crearObjConsulta(row));
            }

            return listadoConsultas;
        }

        public Consulta GetConsulta(int id)
        {
            String consultaSql = string.Concat(" SELECT *",
                                               "   FROM consulta ",
                                               "  WHERE id_consulta = ", id);

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
            oConsulta.Id_profesional = Convert.ToInt32(row["id_profesional"].ToString());
            oConsulta.Monto = Convert.ToInt32(row["monto"].ToString());
            oConsulta.Observacion = row["observacion"].ToString();
            oConsulta.Num_turno = Convert.ToInt32(row[0].ToString());
            oConsulta.Cobrado = Convert.ToBoolean(row["cobrado"]);

            return oConsulta;
        }

        internal DataTable recuperarPacientePorProfesionalPorFecha(DateTime desde, DateTime hasta)
        {
            String consultaSql = string.Concat("Select p.apellido as id_profesional, COUNT(c.id_paciente) as id_paciente",
                                               " From consulta c Join profesional p on(c.id_profesional = p.matricula) ",
                                               " Where fecha between '", desde.ToString("yyyy-MM-dd"), "' and '",
                                               hasta.ToString("yyyy-MM-dd"),
                                                "' Group by p.apellido");
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }
        public DataTable recuperarPracticaConsulta(string desde, string hasta, int practica)
        {
            String consultaSql = string.Concat("select p.id_consulta, pr.nombre as id_practica",
                                               " from pracXcons p join consulta c on(p.id_consulta = c.id_consulta)",
                                               "  join practica pr on(p.id_practica = pr.id_practica)",
                                               " Where fecha between '", desde, "' and '", hasta, "'",
                                               " and p.id_practica = ", practica);
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }

        public DataTable estadisticasConsulta(string desde, string hasta, int profesional)
        {
            string sql = string.Concat("select prac.nombre as nombre, count(p.id_practica) as id_practica" +
                                                          " from pracXcons p" +
                                                           " join consulta c on c.id_consulta = p.id_consulta" +
                                                             " join practica prac on p.id_practica = prac.id_practica" +
                                                            " where c.fecha between '"+ desde +"' and '"+hasta+"'"+
                                                            " and c.id_profesional = " + profesional +
                                                             " group by p.id_practica, prac.nombre");
            return DBHelper.GetDBHelper().reporte(sql);

        }

        public DataTable existeConsultaDeTurno(int numTurno)
        {
            string sql = string.Concat("select id_consulta" +
                                      " from consulta" +
                                      " where num_turno = " + numTurno);
            return DBHelper.GetDBHelper().reporte(sql);
        }

        public bool crearConsulta(Consulta oConsulta, int[] practicas)
        {
            DataManager dm = new DataManager();
            try
            {
                int cobrado = 0;
                if (oConsulta.Cobrado) { cobrado = 1; }

                string sql = "INSERT INTO consulta(fecha, id_paciente, id_profesional, cobrado, monto, num_turno, observacion) " +
                            "   VALUES('"
                            + oConsulta.Fecha.ToString("yyyy-MM-dd") + "', "
                            + oConsulta.Id_paciente + ", "
                            + oConsulta.Id_profesional + ", "
                            + cobrado + ", "
                            + (oConsulta.Monto.ToString().Replace(",", ".")) + ", "
                            + oConsulta.Num_turno + ", '"
                            + oConsulta.Observacion + "')";

                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert de la consulta
                dm.EjecutarSQL(sql);

                var idConsulta = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

                //Guarda en numTurno el identity generado

                oConsulta.Id_consulta = Convert.ToInt32(idConsulta);

                string sqlhisto = "INSERT INTO historial_turnos(num_turno, estado, borrado) VALUES(" + oConsulta.Num_turno + ", 'consulta realizada', 0)";

                dm.EjecutarSQL(sqlhisto);

                string sqlhistoClin = "INSERT INTO historial_clinico(id_paciente, fecha_consulta, id_consulta, borrado) VALUES(" + oConsulta.Id_paciente + ", '" + oConsulta.Fecha.ToString("yyyy-MM-dd") + "', " + oConsulta.Id_consulta + ", 0)";

                dm.EjecutarSQL(sqlhistoClin);
                foreach (int id_prac in practicas)
                {
                    //inserto las practicas q se realizaron en la consulta
                    string sqlPracticas = "INSERT INTO practicas_x_consulta VALUES(" + oConsulta.Id_consulta + ", " + id_prac + ")";
                    dm.EjecutarSQL(sqlPracticas);
                    //consulto la cantidad de insumos q se usan para cada practica
                    string sqlSelectCantInsumos = "SELECT * from insumo_x_practica WHERE id_practica = " + id_prac;
                    var resultado = DBHelper.GetDBHelper().ConsultaSQL(sqlSelectCantInsumos);
                    int cant = resultado.Rows.Count;
                    //y según esa cantidad, recorro el datatable para actualizar el stock de insumos
                    for (int i = 0; i < cant; i++)
                    {
                        string sqlInsumos = "UPDATE insumo SET stock = (stock - (SELECT cantidad FROM insumo_x_practica WHERE id_practica =" + id_prac + " AND id_insumo = insumo.id_insumo))" +
                            " WHERE id_insumo in (SELECT id_insumo FROM insumo_x_practica WHERE id_practica  =" + id_prac + ")";

                        dm.EjecutarSQL(sqlInsumos);
                    }
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
