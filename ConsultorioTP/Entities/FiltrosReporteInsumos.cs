using Consultorio.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class FiltrosReporteInsumos
    {

        public DataTable ObtenerListadoInsumos()
        {

            var strSql = "SELECT id_insumo, nombre, stock FROM insumo ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }
        public DataTable ObtenerListadoInsumosFiltro(String filtro)
        {

            var strSql = "SELECT id_insumo, nombre, stock FROM insumo WHERE " + filtro;

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }
    }
}
