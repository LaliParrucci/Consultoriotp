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
    class ProfesionalService
    {
        private ProfesionalDao oProfesionalDao;
        private ProfesionalE oProfesional = new ProfesionalE();
        public ProfesionalService()
        {
            oProfesionalDao = new ProfesionalDao();
        }

        public IList<ProfesionalE> recuperarProfesional()
        {
            return oProfesionalDao.GetAll();
        }

        public void bajaProfesional(int matricula)
        {
            oProfesionalDao.baja(matricula);
        }

        public List<ProfesionalE> recuperarProfesionalPorNombre(string nom)
        {
            return oProfesionalDao.GetProfesionalNom(nom);
        }
        public ProfesionalE recuProfesionalApe(string ape)
        {
            return oProfesionalDao.GetProfesionalPorApellido(ape);
        }

        public ProfesionalE recuperarProfesionalPorMatricula(int matricula)
        {
            return oProfesionalDao.GetProfesional(matricula);
        }

        internal bool validarProfesional()
        {
            if(oProfesional.Nombre == string.Empty)
            {
                MessageBox.Show("El nomobre está vacio...");
                return false;
            }
            if (oProfesional.Apellido == string.Empty)
            {
                MessageBox.Show("El apellido está vacío...");
                return false;
            }
            if (oProfesional.Domicilio == string.Empty)
            {
                MessageBox.Show("El domicilio está vacío...");
                return false;
            }
            return true;
        }

        internal bool existeProfesional(int matricula)
        {
            if (oProfesionalDao.GetProfesional(matricula) != null) 
            { 
                return true; 
            }
            return false;
        }

        public void altaProfesional(ProfesionalE ob, bool esAlta)
        {
            int mat = ob.Matricula;
            string nom = ob.Nombre;
            string ape = ob.Apellido;
            string esp = ob.Especialidad;
            string dom = ob.Domicilio;
            oProfesionalDao.actualizacion(mat, nom, ape, esp, dom, esAlta);
        }

        public DataTable recuperarTodos()
        {
            return oProfesionalDao.recuperarTodos();
        }
    }

}
