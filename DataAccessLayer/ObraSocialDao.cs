using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class ObraSocialDao
    {
        string sentencia;
        public IList<ObraSocial> GetAll()
        {
            List<ObraSocial> listadoObras = new List<ObraSocial>();

            var strSql = "SELECT cod_obra_social, nombre FROM obra_social WHERE borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoObras.Add(crearObjObras(row));
            }

            return listadoObras;
        }

        private ObraSocial crearObjObras(DataRow row)
        {//creo nueva instancia de obras
            ObraSocial oObraSocial = new ObraSocial();           
            oObraSocial.Codigo = Convert.ToInt32(row[0].ToString());
            oObraSocial.Nombre = row[1].ToString();

            return oObraSocial;
        }

        public ObraSocial GetObraSocial(int codigo)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT cod_obra_social,nombre",
                                               "   FROM obra_social ",
                                               "  WHERE cod_obra_social = ", codigo);

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjObras(resultado.Rows[0]);
            }

            return null;
        }
        public void actualizar(int codigo, string nombre,bool esAlta)
        {
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO obra_social(cod_obra_social, nombre, borrado)" +
                                          " VALUES(", codigo, ", '", nombre, "',0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE obra_social SET cod_obra_social = ", codigo,
                                                             ", nombre = '", nombre,
                                                             "' WHERE cod_obra_social = ", codigo);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }
        public void baja(int codigo)
        {
            string sentencia = string.Concat("UPDATE obra_social SET borrado = 1 WHERE cod_obra_social =", codigo);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }
    }
}
