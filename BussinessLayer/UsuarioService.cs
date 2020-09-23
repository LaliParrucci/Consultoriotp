using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.DataAccessLayer;
using Consultorio.Entities;

namespace Consultorio.BusinessLayer
{
    class UsuarioService
    {
        private UsuarioDao oUsuarioDao;
        private UsuarioE oUsuario = new UsuarioE();

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }

        public UsuarioE validarUsuario(string usuario, string password)
        {
            UsuarioE usr = oUsuarioDao.recuperarUsuario(usuario);

            if (usr != null)
            {
                if (usr.Contraseña.Equals(password))
                {
                    return usr;
                }
            }

            return null;
        }

        public UsuarioE recuperarUsuario(string nombreUsuario)
        {
            return oUsuarioDao.recuperarUsuario(nombreUsuario);
        }

        internal IList<UsuarioE> recuperarUsuario()
        {
            return oUsuarioDao.GetAll();
        }

        internal void bajaUsuario(int id_usuario)
        {
            oUsuarioDao.baja(id_usuario);
        }

        internal UsuarioE recuperarUsuarioPorId(int id_usuario)
        {
            return oUsuarioDao.GetUsuario(id_usuario);
        }

        internal void altaUsuario(UsuarioE ob, bool esAlta)
        {
            int id = ob.Id_usuario;
            string nom = ob.Nombre_usuario;
            string contra = ob.Contraseña;
            oUsuarioDao.actualizacion(id, nom, contra, esAlta);
        }

        internal bool validarCampo()
        {
            if (oUsuario.Nombre_usuario == string.Empty)
            {
                MessageBox.Show("El nomobre está vacio...");
                return false;
            }
            if (oUsuario.Contraseña == string.Empty)
            {
                MessageBox.Show("El apellido está vacío...");
                return false;
            }
            return true;
        }
    }
}
