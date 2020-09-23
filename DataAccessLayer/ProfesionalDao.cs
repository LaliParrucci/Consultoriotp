using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class ProfesionalDao
    {
        public IList<ProfesionalE> GetAll()
        {
            List<ProfesionalE> listadoProfe = new List<ProfesionalE>();

            var strSQL = "SELECT matricula,nombre, apellido, domicilio FROM profesional WHERE  borrado = 0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoProfe.Add(crearObjProfe(row));
            }
            return listadoProfe;
        }

        private ProfesionalE crearObjProfe(DataRow row)
        {
            //Creo nueva instancia de Profesional con los parametros de abajo
            ProfesionalE oProfesional = new ProfesionalE();
            oProfesional.Matricula = Convert.ToInt32(row[0].ToString());
            oProfesional.Nombre = row[1].ToString();
            oProfesional.Apellido = row[2].ToString();
            oProfesional.Domicilio = row[3].ToString();
            return oProfesional;
        }

        public ProfesionalE GetProfecional(int matricula)
        {
            //Construimos la consulta sql para buscar al Profecional
            String consultaSql = string.Concat("SELECT matricula, nombre, apellido, domicilio",
                                               " FROM profesional",
                                               " WHERE matricula = " + matricula);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if(resultado.Rows.Count > 0)
            {
                return crearObjProfe(resultado.Rows[0]);
            }

            return null;
        }

        public void baja(int matricula)
        {
            string sentencia = string.Concat("UPDATE profesional SET borrado = 1 WHERE matricula =", matricula);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        public void actualizacion(int mat, string nom, string ape, string dom, bool esAlta)
        {
            string sentencia;
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO profesional (nombre, apellido, domicilio, borrado) ",
                                          "VALUES ('", nom, "', '", ape, "', '", dom, "' , 0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE profesional SET nombre = '", nom,
                                                             "', apellido = '", ape,
                                                            "', domicilio = '", dom,
                                                            "' WHERE matricula = ", mat);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }
    }
}
