using System;
using System.Collections.Generic;
using Consultorio.Entities;
using System.Data;
using Consultorio.BussinessLayer;

namespace Consultorio.DataAccessLayer
{
    class InsumoDao
    {
        string sentencia;

        public IList<Insumo> GetAll()
        {
            List<Insumo> listadoPrac = new List<Insumo>();

            var strSql = "SELECT id_insumo, nombre, stock FROM insumo where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPrac.Add(crearObjPrac(row));
            }

            return listadoPrac;
        }
        public Insumo GetInsumo(int id)
        {
            String consultaSql = string.Concat(" SELECT id_insumo, nombre, stock",
                                               "   FROM insumo ",
                                               "  WHERE id_insumo = ", id);

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return crearObjPrac(resultado.Rows[0]);
            }

            return null;
        }
        private Insumo crearObjPrac(DataRow row)
        {
            Insumo oInsumo = new Insumo();
            oInsumo.Nombre = row[1].ToString();
            oInsumo.Id = Convert.ToInt32(row[0].ToString());
            oInsumo.Stock = Service.convertirA0(row["stock"]);
            return oInsumo;
        }

        public void actualizacion(string nom, int id, int s, bool esAlta)
        {

            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO insumo(nombre, stock, borrado)" +
                                          " VALUES('", nom, "', ", s,", 0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE insumo SET nombre = '", nom,
                                                             "', stock =", s," WHERE id_insumo = ", id);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }

        public void baja(int id)
        {
            string sentencia = string.Concat("UPDATE insumo SET borrado = 1 WHERE id_insumo = ", id);

            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }
    }
}