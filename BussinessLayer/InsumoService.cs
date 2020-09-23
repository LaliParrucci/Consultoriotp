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
    class InsumoService
    {
        private InsumoDao oInsumoDao;
        private Insumo oInsumo = new Insumo();
        public InsumoService()
        {
            oInsumoDao = new InsumoDao();
        }
        public IList<Insumo> recuperarInsumo()
        {
            return oInsumoDao.GetAll();
        }

        public Insumo recuperarInsumoPorId(int id)
        {
            return oInsumoDao.GetInsumo(id);
        }

        public bool validarInsumo()
        {
            if (oInsumo.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío...");
                return false;
            } //SEGUIR VALIDACIONES
            return true;
        }
        public bool existeInsumo(int id)
        {
            if (oInsumoDao.GetInsumo(id) != null) { return true; }
            return false;
        }
        public void altaInsumo(Insumo ob, bool esAlta)
        {
            string nom = ob.Nombre;
            int id = ob.Id;
            oInsumoDao.actualizacion(nom, id, esAlta);
        }
        public void bajaInsumo (int id)
        {
            oInsumoDao.baja(id);
        }

    }
}