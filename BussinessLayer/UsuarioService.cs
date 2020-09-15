using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using Consultorio.Entities;

namespace Consultorio.BusinessLayer
{
    class UsuarioService
    {
        private UsuarioDao oUsuarioDao;

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }

        public Usuario validarUsuario(string usuario, string password)
        {
            Usuario usr = oUsuarioDao.recuperarUsuario(usuario);

            if (usr != null)
            {
                if (usr.Contraseña.Equals(password))
                {
                    return usr;
                }
            }

            return null;
        }

        public Usuario recuperarUsuario(string nombreUsuario)
        {
            return oUsuarioDao.recuperarUsuario(nombreUsuario);
        }
    }
}
