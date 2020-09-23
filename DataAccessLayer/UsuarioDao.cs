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
        private UsuarioE MappingUsuario(DataRow row)
        {
            UsuarioE oUsuario = new UsuarioE
            {
                Id_usuario = Convert.ToInt32(row["id_usuario"]),
                Nombre_usuario = row["nombre_usuario"].ToString(),
                Contraseña = row["contraseña"].ToString()
            };

            return oUsuario;
        }

        public UsuarioE recuperarUsuario(string pUsuario)
        {
            String consultaSql = string.Concat("SELECT id_usuario, nombre_usuario, contraseña ",
                                               "FROM usuario ",
                                               "WHERE borrado= 0 AND nombre_usuario= '", pUsuario, "'");
            var TablaResultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (TablaResultado.Rows.Count > 0)
            {
                return MappingUsuario(TablaResultado.Rows[0]);
            }

            return null;
        }

        internal void baja(int id_usuario)
        {
            string sentencia = string.Concat("UPDATE usuario SET borrado = 1 WHERE id_usuario =", id_usuario);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        internal UsuarioE GetUsuario(int id_usuario)
        {
            //Construimos la consulta sql para buscar al Usuario
            String consultaSql = string.Concat("SELECT id_usuario, nombre_usuario, contraseña", 
                                               " FROM usuario",
                                               " WHERE id_usuario = " + id_usuario);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return MappingUsuario(resultado.Rows[0]);
            }

            return null;
        }

        internal void actualizacion(int id, string nom, string contra, bool esAlta)
        {
            string sentencia;
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO usuario (nombre_usuario, contraseña, borrado) ",
                                          "VALUES ('", nom, "', '", contra, "' , 0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE usuario SET nombre_usuario = '", nom,
                                                             "', contraseña = '", contra,
                                                            "' WHERE id_usuario = ", id);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }

        internal IList<UsuarioE> GetAll()
        {
            List<UsuarioE> listadoUsuario = new List<UsuarioE>();

            var strSQL = "SELECT id_usuario, nombre_usuario, contraseña FROM usuario WHERE  borrado = 0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuario.Add(MappingUsuario(row));
            }
            return listadoUsuario;
        }

    }
}
