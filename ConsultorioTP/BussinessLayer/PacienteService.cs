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
    class PacienteService
    {
        private PacienteDao oPacienteDao;
        private PacienteE oPaciente = new PacienteE();
        public PacienteService()
        {
            oPacienteDao = new PacienteDao();
        }
        public IList<PacienteE> recuperarPaciente()
        {
            return oPacienteDao.GetAll();
        }

        public PacienteE recuperarPacientePorDni(int dni)
        {
            return oPacienteDao.GetPaciente(dni);
        }

        public bool validarPaciente(PacienteE obPaciente)
        {
            if (obPaciente.Nombre == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre para el paciente", "Nombre de paciente vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (obPaciente.Apellido == string.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido para el paciente", "Apellido de paciente vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool existePaciente(int dni)
        {
            if (oPacienteDao.GetPaciente(dni) != null) { return true; }
            return false;
        }
        public void altaPaciente(PacienteE ob, bool esAlta)
        {
            string nom = ob.Nombre;
            string ape = ob.Apellido;
            string tl = ob.Telefono;
            int dni = ob.Dni;
            string dom = ob.Domicilio;
            string email = ob.Email;
            oPacienteDao.actualizacion(nom, ape, tl, dni, dom, email, esAlta);
        }

        public void bajaPaciente(int dni)
        {
            oPacienteDao.baja(dni);
        }

        internal IList<PacienteE> recuperarPacientePorNA(string nom, string ape)
        {
            return oPacienteDao.GetPacientePorNA(nom, ape);
        }

        internal DataTable recuperarPacientePorFecha(string profesional, DateTime desde, DateTime hasta)
        {
            return oPacienteDao.recuperarPacientePorFecha(profesional, desde, hasta);
        }
    }
}
