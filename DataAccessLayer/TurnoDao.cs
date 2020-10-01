using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class TurnoDao
    {

        public IList<Turno> GetAll()
        {
            List<Turno> listadoTurno = new List<Turno>();

            var strSql = "SELECT num_turno, fecha, hora, id_paciente, id_profesional from turno where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTurno.Add(crearObjTurno(row));
            }

            return listadoTurno;
        }

        internal IList<Disponibilidad> GetTodos(string matricula, string fecha)
        {
            List<Disponibilidad> listadoTodosTurnos = new List<Disponibilidad>();

            var strSql = "SELECT matricula, semana, hora FROM disponibilidad_Profesional WHERE matricula = '"+ matricula + "' AND semana LIKE '" + fecha + "%'" ;

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTodosTurnos.Add(crearObjDisponibilidad(row));
            }

            return listadoTodosTurnos;
        }

        internal IList<Disponibilidad> GetTodosDisp(string matricula, string fecha)
        {
            List<Disponibilidad> listadoTodosTurnos = new List<Disponibilidad>();

            var strSql = "SELECT d.matricula, d.semana, d.hora FROM disponibilidad_Profesional d JOIN Turno t ON (d.matricula = t.id_profesional AND d.hora = t.hora) WHERE matricula = '" + matricula + "' AND t.fecha Like '" + fecha + "' AND d.semana Like '" + fecha + "%'";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTodosTurnos.Add(crearObjDisponibilidad(row));
            }

            return listadoTodosTurnos;
        }


        public Turno GetTurno(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT num_turno, fecha, id_paciente, id_profesional",
                                               "   FROM turno ",
                                               "  WHERE num_turno = ", id);

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjTurno(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Turno> GetTurnoFecha(string fecha)
        {
            String consultaSql = string.Concat(" SELECT num_turno, fecha, id_paciente, id_profesional, id_obra_social",
                                               "   FROM turno ",
                                               "  WHERE fecha = '",fecha, "'");
            List<Turno> listadoTurno = new List<Turno>();

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            foreach (DataRow row in resultado.Rows)
            {
                listadoTurno.Add(crearObjTurno(row));
            }

            return listadoTurno;
        }

        private Turno crearObjTurno(DataRow row)
        {//creo nueva instancia de usuario con los parámetros de abajo
            Turno oTurno = new Turno();
            oTurno.Num_turno = Convert.ToInt32(row[0].ToString());
            oTurno.Fecha = row[1].ToString();
            oTurno.Id_paciente = Convert.ToInt32(row[2].ToString());
            oTurno.Id_profesional = Convert.ToInt32(row[3].ToString());
            oTurno.Id_obra_social = Convert.ToInt32(row[4].ToString());
            oTurno.Hora = row["Hora"].ToString();
            return oTurno;
        }

        private Disponibilidad crearObjDisponibilidad(DataRow row)
        {//creo nueva instancia de usuario con los parámetros de abajo
            Disponibilidad oDisponibilidad = new Disponibilidad();
            oDisponibilidad.Matricula = Convert.ToInt32(row["Matricula"].ToString());
            oDisponibilidad.Semana = row["Semana"].ToString();
            oDisponibilidad.Hora = row["Hora"].ToString();
            return oDisponibilidad;
        }

        public void actualizacion(string nom, string desc, int imp, int id, bool esAlta)
        {
            //Cambiar Nombre!!!
            string sentencia;
            if (esAlta)
            {
                if (imp == 0)
                {
                    sentencia = string.Concat("INSERT INTO practica(nombre, descripcion, borrado) VALUES('", nom, "', '", desc, "', 0);");
                }
                else
                {
                    sentencia = string.Concat("INSERT INTO practica(nombre, descripcion, importe, borrado) VALUES('", nom, "', '", desc, "', ", imp, ", 0);");
                }
            }
            else
            {
                sentencia = string.Concat("UPDATE practica SET nombre = '", nom,
                                                      "', descripcion = '", desc, "'");
                if (imp != 0)
                {
                    sentencia += ", importe =" + imp;
                }
                sentencia += " WHERE id_practica = " + id;
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }

        public void baja(int idP)
        {
            string sentencia = string.Concat("UPDATE practica SET borrado = 1 WHERE id_practica =", idP);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        public bool crearTurnoConHistorial(Turno oTurno, string observacion)
        {
            DataManager dm = new DataManager();
            try
            {
                //Select @@identity obtiene el identity insertado
                string sql = "INSERT INTO turno(fecha, hora, id_paciente, id_profesional, id_obra_social, borrado) " +
                            "   VALUES('" 
                            + oTurno.Fecha + "', '" 
                            + oTurno.Hora + "' , " 
                            + oTurno.Id_paciente + ", " 
                            + oTurno.Id_profesional + ", " 
                            + oTurno.Id_obra_social + ", 0)";

                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert del turno
                dm.EjecutarSQL(sql);

                var numTurno = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

                //Guarda en numTurno el identity generado

                oTurno.Num_turno = Convert.ToInt32(numTurno);

                string sqlhisto = "INSERT INTO historial_turnos(num_turno, borrado, observacion) VALUES(" + oTurno.Num_turno + ", 0, '"+ observacion+"')";
                
                dm.EjecutarSQL(sqlhisto);

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
