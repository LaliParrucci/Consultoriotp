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

        internal IList<Disponibilidad> GetTodos(string matricula, DateTime fecha)
        {
            List<Disponibilidad> listadoTodosTurnos = new List<Disponibilidad>();

            var strSql = "SELECT d.matricula, d.fecha, d.hora, d.disponible, t.id_paciente FROM disponibilidad_Profesional d LEFT JOIN turno t ON(d.matricula = t.id_profesional AND d.fecha = t.fecha AND d.hora = t.hora AND t.borrado = 0) WHERE matricula = " + matricula + " AND d.fecha = '" + fecha.ToString("yyyy-MM-dd") + "'";
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTodosTurnos.Add(crearObjDisponibilidadPaciente(row));
            }

            return listadoTodosTurnos;
        }

        internal DataTable recuperarTurnoFechaProfesional(DateTime desde, DateTime hasta)
        {
            String consultaSql = string.Concat("Select p.apellido as id_profesional, T.num_turno ",
                                               "FROM profesional p JOIN turno t ON(p.matricula = t.id_profesional) ",
                                               "WHERE t.fecha BETWEEN '", desde.ToString("yyyy-MM-dd"), "' AND ' ", hasta.ToString("yyyy-MM-dd"), "'");
            
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }

        internal IList<Disponibilidad> GetTodosDisp(string matricula, DateTime fecha)
        {
            List<Disponibilidad> listadoTodosTurnos = new List<Disponibilidad>();

            var strSql = "SELECT d.matricula, d.fecha, d.hora, d.disponible FROM disponibilidad_Profesional d " +
                " WHERE matricula = '" + matricula + "' AND D.fecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND disponible = 1";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTodosTurnos.Add(crearObjDisponibilidadPaciente(row));
            }

            return listadoTodosTurnos;

        }

        internal Turno GetTurnoFechaDni(DateTime fecha, string dni)
        {
            String consultaSql = string.Concat(" SELECT num_turno, fecha, hora, id_paciente, id_profesional, id_obra_social",
                                               "   FROM turno ",
                                               "  WHERE id_paciente = ", dni, " AND fecha = '", fecha.ToString("yyyy-MM-dd"), "'");

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return crearObjTurno(resultado.Rows[0]);
            }

            return null;
        }

        public Turno GetTurno(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT num_turno, fecha, hora, id_paciente, id_profesional",
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

        public Turno getTurnoFechaHoraProf(DateTime fecha, string hora, int mat)
        {
            string consultaSql = string.Concat(" SELECT num_turno, fecha, hora, id_paciente, id_profesional, id_obra_social",
                                               "   FROM turno ",
                                               "  WHERE fecha = '", fecha.ToString("yyyy-MM-dd"), "' AND hora = '", hora, "' AND id_profesional = ",mat);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjTurno(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Turno> GetTurnoFecha(DateTime fecha)
        {
            String consultaSql = string.Concat(" SELECT num_turno, fecha, hora, id_paciente, id_profesional, id_obra_social",
                                               "   FROM turno ",
                                               "  WHERE fecha = '",fecha.ToString("yyyy-MM-dd"), "'");
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
            oTurno.Fecha = Convert.ToDateTime(row[1].ToString());
            oTurno.Id_paciente = Convert.ToInt32(row[3].ToString());
            oTurno.Id_profesional = Convert.ToInt32(row[4].ToString());
            oTurno.Id_obra_social = Convert.ToInt32(row["Id_obra_social"].ToString());
            oTurno.Hora = row["Hora"].ToString();
            return oTurno;
        }

        private Disponibilidad crearObjDisponibilidadPaciente(DataRow row)
        {//creo nueva instancia de usuario con los parámetros de abajo
            Disponibilidad oDisponibilidad = new Disponibilidad();
            oDisponibilidad.Matricula = Convert.ToInt32(row["Matricula"].ToString());
            oDisponibilidad.Fecha = Convert.ToDateTime(row["fecha"].ToString());
            oDisponibilidad.Hora = row["Hora"].ToString();
            oDisponibilidad.Disponible =Convert.ToBoolean(row["Disponible"]);
            try
            {
                oDisponibilidad.Paciente = Service.convertirA0(row["id_paciente"].ToString());
            }catch(Exception e)
            {
                return oDisponibilidad;
            }
            return oDisponibilidad;
        }


        public bool crearTurnoConHistorial(Turno oTurno, string observacion)
        {
            DataManager dm = new DataManager();
            try
            {
                //Select @@identity obtiene el identity insertado
                string sql = "INSERT INTO turno(fecha, hora, id_paciente, id_obra_social, id_profesional, observacion, borrado) " +
                            "   VALUES('" 
                            + oTurno.Fecha.ToString("yyyy-MM-dd") + "', '" 
                            + oTurno.Hora + "' , " 
                            + oTurno.Id_paciente + ", "
                            + oTurno.Id_obra_social + ", "
                            + oTurno.Id_profesional + ", '"
                            + observacion + "', 0)";

                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert del turno
                dm.EjecutarSQL(sql);

                var numTurno = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

                //Guarda en numTurno el identity generado

                oTurno.Num_turno = Convert.ToInt32(numTurno);

                string sqlhisto = "INSERT INTO historial_turnos(num_turno, borrado, estado, id_paciente, id_profesional, fecha, hora) VALUES(" + oTurno.Num_turno + ", 0, 'creado', "+ oTurno.Id_paciente +", "+ oTurno.Id_profesional+", '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "', '"
                            + oTurno.Hora + "')";

                dm.EjecutarSQL(sqlhisto);

                string sqldispo = "UPDATE disponibilidad_profesional SET disponible = 0 WHERE matricula = " + oTurno.Id_profesional + " AND fecha = '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "' AND hora = '" + oTurno.Hora + "' AND borrado = 0";

                dm.EjecutarSQL(sqldispo);

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

        public bool modificarTurnoConHistorial(Turno oTurno, string observacion, Turno turnoViejo)
        {
            DataManager dm = new DataManager();
            try
            {
                //Select @@identity obtiene el identity insertado
                string sqlhisto = "INSERT INTO historial_turnos(num_turno, borrado, estado, id_paciente, id_profesional, fecha, hora) VALUES(" + turnoViejo.Num_turno + ", 0, 'modificado', " + oTurno.Id_paciente + ", " + oTurno.Id_profesional + ", '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "', '"
                            + oTurno.Hora + "')";

                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert del turno
                dm.EjecutarSQL(sqlhisto);
                string sql = "UPDATE turno SET fecha = '"
                            + oTurno.Fecha.ToString("yyyy-MM-dd") + "', hora ='"
                            + oTurno.Hora + "', id_obra_social = "
                            + oTurno.Id_obra_social + ", id_profesional = "
                            + oTurno.Id_profesional + " WHERE num_turno = "+ turnoViejo.Num_turno;
                dm.EjecutarSQL(sql);

                string sqldispo = "UPDATE disponibilidad_profesional SET disponible = 0 WHERE matricula = " + oTurno.Id_profesional + " AND fecha = '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "' AND hora = '" + oTurno.Hora + "' AND borrado = 0" +
                                 " UPDATE disponibilidad_profesional SEt disponible = 1 WHERE matricula = " + turnoViejo.Id_profesional + " AND fecha = '" + turnoViejo.Fecha.ToString("yyyy-MM-dd") + "' AND hora = '" + turnoViejo.Hora + "' AND borrado = 0";


                dm.EjecutarSQL(sqldispo);

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

        public bool eliminarTurnoConHistorial(Turno oTurno)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string sqlhisto = "INSERT INTO historial_turnos(num_turno, borrado, estado, id_paciente, id_profesional, fecha, hora) VALUES(" + oTurno.Num_turno + ", 0, 'cancelado', " + oTurno.Id_paciente + ", " + oTurno.Id_profesional + ", '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "', '"
                            + oTurno.Hora + "')";

                dm.EjecutarSQL(sqlhisto);
                
                string sql = "UPDATE turno SET borrado = 1 WHERE num_turno = " + oTurno.Num_turno;
                //Ejecuto el insert del turno
                dm.EjecutarSQL(sql);


                string sqldispo = "UPDATE disponibilidad_profesional SET disponible = 1 WHERE matricula = " + oTurno.Id_profesional + " AND fecha = '" + oTurno.Fecha.ToString("yyyy-MM-dd") + "' AND hora = '" + oTurno.Hora + "' AND borrado = 0";

                dm.EjecutarSQL(sqldispo);

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

        public DataTable datasetTurnosReporte(DateTime fecha)
        {
            string sql = "SELECT t.num_turno, t.hora, pa.dni as id_paciente , prof.matricula as id_profesional, prof.apellido" +
                " FROM paciente pa " +
                " INNER JOIN turno t ON pa.dni = t.id_paciente" +
                " INNER JOIN profesional prof ON t.id_profesional = prof.matricula" +
                " WHERE (t.borrado = 0) AND t.fecha = '" + fecha.ToString("yyyy-MM-dd") + "' " +
                " ORDER BY t.num_turno";
            return DBHelper.GetDBHelper().reporte(sql);
        }

        public DataTable estadisticaConcretados(string desde, string hasta, int id)
        {
            string sql = "select (count(*)-count(c.num_turno)) as no_concretados, count(c.num_turno) as concretados" +
                " from turno t" +
                " left join consulta c on t.num_turno = c.num_turno" +
                " where t.fecha between '" + desde + "' and '" + hasta + "'";
            if(id != -1)
            {
                sql += " and t.id_profesional = " + id;
            }
            
            return DBHelper.GetDBHelper().reporte(sql);

        }
    }
}
