﻿using System;
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

            DataTable resultadoConsulta = getAllTabla();

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoProfe.Add(crearObjProfe(row));
            }
            return listadoProfe;
        }
        public DataTable getAllTabla()
        {

            string strSQL = "SELECT matricula, nombre, apellido, especialidad, domicilio " +
                " FROM profesional " +
                " WHERE  borrado = 0";

            return DBHelper.GetDBHelper().ConsultaSQL(strSQL);
        }

        private ProfesionalE crearObjProfe(DataRow row)
        {
            //Creo nueva instancia de Profesional con los parametros de abajo
            ProfesionalE oProfesional = new ProfesionalE();
            oProfesional.Matricula = Convert.ToInt32(row[0].ToString());
            oProfesional.Nombre = row[1].ToString();
            oProfesional.Apellido = row[2].ToString();
            oProfesional.Especialidad = row[3].ToString();
            oProfesional.Domicilio = row[4].ToString();
            return oProfesional;
        }

        public ProfesionalE GetProfesional(int matricula)
        {
            //Construimos la consulta sql para buscar al Profecional
            String consultaSql = string.Concat("SELECT matricula, nombre, apellido, especialidad, domicilio",
                                               " FROM profesional",
                                               " WHERE matricula = " + matricula + " AND borrado = 0");
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return crearObjProfe(resultado.Rows[0]);
            }

            return null;
        }

        private ProfesionalE mapeo(DataRow row)
        {
            //Creo nueva instancia de Profesional con los parametros de abajo
            ProfesionalE oProfesional = new ProfesionalE();
            oProfesional.Nombre = row["nombre"].ToString();
            oProfesional.Apellido = row["apellido"].ToString();
            oProfesional.Matricula = Convert.ToInt32(row["matricula"].ToString());
            return oProfesional;
        }

        public List<ProfesionalE> GetProfesionalNom(string nom)
        {
            List<ProfesionalE> listadoProfe = new List<ProfesionalE>();
            //Construimos la consulta sql para buscar al Profecional
            String consultaSql = string.Concat("SELECT nombre, apellido, matricula",
                                               " FROM profesional",
                                               " WHERE nombre = '" + nom + "' AND borrado = 0");
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            foreach (DataRow row in resultado.Rows)
            {
                listadoProfe.Add(mapeo(row));
            }
            return listadoProfe;
        }
        public ProfesionalE GetProfesionalPorApellido(string ape)
        {
            String consultaSql = string.Concat(" SELECT matricula",
                                               "  FROM profesional ",
                                               "  WHERE apellido = '", ape, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return mapeoMatricula(resultado.Rows[0]);
            }
            return null;
        }
        public ProfesionalE mapeoMatricula(DataRow row)
        {
            ProfesionalE pr = new ProfesionalE();
            pr.Matricula = Convert.ToInt32(row[0].ToString());
            return pr;
        }

        public void baja(int matricula)
        {
            string sentencia = string.Concat("UPDATE profesional SET borrado = 1 WHERE matricula =", matricula);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        public void actualizacion(int mat, string nom, string ape,string esp, string dom, bool esAlta)
        {
            string sentencia;
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO profesional (nombre, apellido, especialidad, domicilio, borrado) ",
                                          "VALUES ('", nom, "', '", ape, "', '", esp, "', '", dom, "' , 0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE profesional SET nombre = '", nom,
                                                             "', apellido = '", ape,
                                                             "', especialidad = '", esp,
                                                            "', domicilio = '", dom,
                                                            "' WHERE matricula = ", mat);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }
    }
}
