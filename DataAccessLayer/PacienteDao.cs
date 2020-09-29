using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class PacienteDao
    {
        string sentencia;
        public IList<PacienteE> GetAll()
        {
            List<PacienteE> listadoPacie = new List<PacienteE>();

            var strSql = "SELECT dni, nombre, apellido, telefono, domicilio, email FROM paciente where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPacie.Add(crearObjPrac(row));
            }

            return listadoPacie;
        }
        public PacienteE GetPaciente(int dni)
        {
            //Construimos la consulta sql para buscar el paciente en la base de datos.
            String consultaSql = string.Concat(" SELECT dni, nombre, apellido, telefono, domicilio, email",
                                               "   FROM paciente ",
                                               "  WHERE dni = ", dni);

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return crearObjPrac(resultado.Rows[0]);
            }

            return null;
        }
        private PacienteE crearObjPrac(DataRow row)
        {//creo nueva instancia de paciente con los parámetros de abajo
            PacienteE oPaciente = new PacienteE();
            oPaciente.Nombre = row[1].ToString();
            oPaciente.Apellido = row[2].ToString();
            oPaciente.Telefono = row[3].ToString();
            oPaciente.Dni = Convert.ToInt32(row[0].ToString());
            oPaciente.Domicilio = row[4].ToString();
            oPaciente.Email = row[5].ToString();
            return oPaciente;
        }



        internal IList<PacienteE> GetPacientePorNA(string nom, string ape)
        {
            //Construimos la consulta sql para buscar el paciente en la base de datos.
            List<PacienteE> listado = new List<PacienteE>();
            String consultaSql = string.Concat(" SELECT dni",
                                               "   FROM paciente ",
                                               "  WHERE nombre = '", nom, "' AND apellido = '", ape, "'" );

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);
            foreach (DataRow row in resultado.Rows)
            {
                listado.Add(mapeo(row));
            }
            return listado;
        }

        public PacienteE mapeo(DataRow row)
        {
            PacienteE oPaciente = new PacienteE();
            oPaciente.Dni = Convert.ToInt32(row[0].ToString());
            return oPaciente;
        }

        public void actualizacion(string nom, string ape, string tl, int dni, string dom, string email, bool esAlta)
        {
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO paciente(dni, nombre, apellido, domicilio, telefono, email, borrado)" +
                                          " VALUES(", dni, ", '", nom, "' , '", ape, "','", dom, "', '", tl, "','", email, "',0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE paciente SET dni = ", dni,
                                                             ", nombre = '", nom,
                                                             "', apellido = '", ape,
                                                             "', domicilio = '", dom,
                                                             "', telefono = '", tl,
                                                             "', email = '", email,
                                                             "' WHERE dni = ", dni);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }

        public void baja(int dni)
        {
            string sentencia = string.Concat("UPDATE paciente SET borrado = 1 WHERE dni =", dni);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }
    }
}
