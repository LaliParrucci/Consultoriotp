using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using Consultorio.DataAccessLayer;
using System.Windows.Forms;
using System.Data;

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
        public DataTable recuInsumos()
        {
            return oInsumoDao.ObtenerListadoInsumos();
        }
        public DataTable recuperarInsumosEstadisticas(int practica)
        {
            return oInsumoDao.obtenerDatosEstadisticas(practica);
        }
        public Insumo recuperarInsumoPorId(int id)
        {
            return oInsumoDao.GetInsumo(id);
        }

        public bool validarInsumo(string n, string s)
        {
            if (n == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre, por favor", "Nombre de insumo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try { Convert.ToInt32(s); }
            catch {
                MessageBox.Show("Ingrese una cantidad válida para el stock, por favor", "Stock asignado inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            int s = ob.Stock;
            oInsumoDao.actualizacion(nom, id, s, esAlta);
        }
        public void bajaInsumo (int id)
        {
            oInsumoDao.baja(id);
        }

    }
}