using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using System.Data;

namespace Consultorio.DataAccessLayer
{
    class UsuarioDao
    {
        private Usuario MappingUsuario(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                Id_usuario = Convert.ToInt32(row["id_usuario"]),
                Nombre_usuario = row["nombre_usuario"].ToString(),
                Contraseña = row["contraseña"].ToString()
            };

            return oUsuario;
        }

        public Usuario recuperarUsuario(string pUsuario)
        {
            String consultaSql = string.Concat("SELECT id_usuario, nombre_usuario, contraseña ",
                                               "FROM Usuario ",
                                               "WHERE borrado= 0 AND nombre_usuario= '", pUsuario, "'");
            var TablaResultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (TablaResultado.Rows.Count > 0)
            {
                return MappingUsuario(TablaResultado.Rows[0]);
            }

            return null;
        }
    }
}
