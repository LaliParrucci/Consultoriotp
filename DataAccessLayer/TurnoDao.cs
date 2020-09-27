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

        Service s = new Service();
        public IList<Turno> GetAll()
        {
            List<Turno> listadoTurno = new List<Turno>();

            var strSql = "SELECT num_turno, fecha_turno, hora_turno, id_paciente, id_profesional, estado from turno where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTurno.Add(crearObjTurno(row));
            }

            return listadoTurno;
        }
        public Turno GetTurno(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT num_turno, fecha_turno, hora_turno, id_paciente, id_profesional, estado",
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

        private Turno crearObjTurno(DataRow row)
        {//creo nueva instancia de usuario con los parámetros de abajo
            Turno oTurno = new Turno();
            oTurno.Num_turno = Convert.ToInt32(row[0].ToString());
            oTurno.Fecha_hora = Convert.ToDateTime(row[1].ToString());
            oTurno.Id_paciente = Convert.ToInt32(row[2].ToString());
            oTurno.Id_profesional = Convert.ToInt32(row[3].ToString());
            oTurno.Estado = row[4].ToString();
            oTurno.Id_obra_social = Convert.ToInt32(row[5].ToString());
            return oTurno;
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

        public void conectarConTransaccion()
        {
            string sentencia = "";
            //DBHelper.GetDBHelper().EjecutarSQLConTransaccion(sentencia);
        }
    }
}
