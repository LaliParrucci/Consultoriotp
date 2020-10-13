using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using System.Data;
using Consultorio.Entities;
using System.Windows.Forms;

namespace Consultorio.BussinessLayer
{
    class PracticaService
    {
        private PracticaDao oPracticaDao;
        private Practica oPractica = new Practica();
        public PracticaService()
        {
            oPracticaDao = new PracticaDao();
        }
        public IList<Practica> recuperarPracticas()
        {
            return oPracticaDao.GetAll();
        }
        public DataTable recuPracticas()
        {
            return oPracticaDao.ObtenerListadoPracticas();
        }
        public DataTable recuPracticasObraSocial(int id)
        {
            return oPracticaDao.ObtenerListadoPracticasConObraSocial(id);
        }
        public Practica recuperarPracticasPorId(int id)
        {
            return oPracticaDao.GetPractica(id);
        }

        public IList<Practica> recuperarPracticasPorNom(string nom)
        {
            return oPracticaDao.GetPracticaNom(nom);
        }

        public bool validarPractica()
        {
            if (oPractica.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío...");
                return false;
            } //SEGUIR VALIDACIONES
            return true;
        }
        public bool existePractica(int id)
        {
            if (oPracticaDao.GetPractica(id) != null) { return true; }
            return false;
        }
        public void altaPractica(Practica ob, bool esAlta)
        {
            string nom = ob.Nombre;
            string desc = ob.Descripcion;
            int imp = ob.Importe;
            int id = ob.Id_practica;
            oPracticaDao.actualizacion(nom, desc, imp, id, esAlta);
        }
        public void bajaPractica(int id)
        {
            oPracticaDao.baja(id);
        }
    }
}    
