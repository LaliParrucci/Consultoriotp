using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using System.Data;

namespace Consultorio.Entities
{
    class FiltrosReportePracticas
    {

        public DataTable ObtenerListadoPracticas()
        {

            var strSql = "SELECT nombre, descripcion, id_practica, importe from practica ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }
        public DataTable ObtenerListadoPracticasFiltro(String filtro)
        {

            var strSql = "SELECT nombre, descripcion, id_practica, importe from practica WHERE  "+ filtro;

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            return resultadoConsulta;
        }

    }
}
