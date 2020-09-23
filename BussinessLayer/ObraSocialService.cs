using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using Consultorio.DataAccessLayer;
using System.Windows.Forms;

namespace Consultorio.BussinessLayer
{
    class ObraSocialService
    {
        private ObraSocialDao oObraSocialDao;
        private ObraSocial oObraSocial = new ObraSocial();

        public ObraSocialService()
        {
            oObraSocialDao = new ObraSocialDao();
        }
        public IList<ObraSocial> recuperarObraSocial()
        {
            
            return oObraSocialDao.GetAll();
        }
        public ObraSocial recuperarObraSocialPorCodigo(int codigo)
        {
            return oObraSocialDao.GetObraSocial(codigo);
        }
        public bool validarObraSocial()
        {
            if (oObraSocial.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío...");
                return false;
            } 
            return true;
        }
        public bool existeObraSocial(int codigo)
        {
            if (oObraSocialDao.GetObraSocial(codigo) != null) { return true; }
            return false;
        }
        public void altaObraSocial(ObraSocial ob, bool esAlta)
        {
            string nombre = ob.Nombre;           
            int codigo = ob.Codigo;
            oObraSocialDao.actualizar(codigo, nombre, esAlta);
        }
        public void bajaObraSocial(int codigo)
        {
            oObraSocialDao.baja(codigo);
        }
    }


}
