using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Consultorio.Entities;

namespace Consultorio.DataAccessLayer
{
    class PracticaDao
    {

        public IList<Practica> GetAll()
        {
            List<Practica> listadoPrac = new List<Practica>();

            var strSql = "SELECT nombre, descripcion, id_practica, importe from practica where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPrac.Add(crearObjPrac(row));
            }

            return listadoPrac;
        }
        public DataTable ObtenerListadoPracticas()
        {

            var strSql = "SELECT nombre, descripcion, id_practica, importe from practica ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);        

            return resultadoConsulta;
        }
        public DataTable ObtenerListadoPracticasConObraSocial(int id_obra_social, string desde, string hasta)
        {
          var strSql = "SELECT pr.id_practica, pr.nombre, pr.descripcion, pr.importe FROM practica pr JOIN pracxcons p ON(pr.id_practica = p.id_practica) RIGHT JOIN consulta c ON(p.id_consulta = c.id_consulta) LEFT JOIN turno t ON(c.fecha=t.fecha and c.id_paciente=t.id_paciente and c.id_profesional=t.id_profesional) WHERE t.id_obra_social = " + id_obra_social + "AND c.fecha between '"+ desde + "' and '" + hasta +"'";
            
           var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }
        public DataTable ObtenerListadoPracticasConProfesional(int id_profesional, string desde, string hasta)
        {
            var strSql = "SELECT pr.id_practica, pr.nombre, pr.descripcion FROM practica pr JOIN pracxcons p on(pr.id_practica = p.id_practica) JOIN consulta c ON (p.id_consulta = c.id_consulta) WHERE c.id_profesional = " + id_profesional + "AND c.fecha between'" + desde + "' and '" + hasta + "'";
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }
        public Practica GetPractica(int id)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT nombre, descripcion, id_practica, importe",
                                               "   FROM practica ",
                                               "  WHERE id_practica = ", id);

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjPrac(resultado.Rows[0]);
            }

            return null;
        }

        public Practica GetPracticaNom(string nom)
        {
            Practica Prac = new Practica();
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT nombre, descripcion, id_practica, importe",
                                               "   FROM practica ",
                                               "  WHERE nombre = '", nom, "'" );

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjPrac(resultado.Rows[0]);
            }
            return null;
        }

        private Practica crearObjPrac(DataRow row)
        {//creo nueva instancia de usuario con los parámetros de abajo
            Practica oPractica = new Practica();
            oPractica.Nombre = row[0].ToString();
            oPractica.Descripcion = row[1].ToString();
            oPractica.Importe = Service.convertirA0(row[3]);
            oPractica.Id_practica = Convert.ToInt32(row[2].ToString());
            return oPractica;
        }

        public void actualizacion(string nom, string desc, int imp, int id, bool esAlta)
        {
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
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        public void baja(int idP)
        {
            string sentencia = string.Concat("UPDATE practica SET borrado = 1 WHERE id_practica =", idP);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }
    }
}
