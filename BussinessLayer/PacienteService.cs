using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Entities;
using Consultorio.DataAccessLayer;
using System.Windows.Forms;

namespace Consultorio.BusinessLayer
{
    class PacienteService
    {
        private PacienteDao oPacienteDao;
        private Paciente oPaciente = new Paciente();
        public PacienteService()
        {
            oPacienteDao = new PacienteDao();
        }
        public IList<Paciente> recuperarPaciente()
        {
            return oPacienteDao.GetAll();
        }

        public Paciente recuperarPacientePorDni(int dni)
        {
            return oPacienteDao.GetPaciente(dni);
        }

        public bool validarPaciente()
        {
            if (oPaciente.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío...");
                return false;
            } //SEGUIR VALIDACIONES
            return true;
        }
        public bool existePaciente(int dni)
        {
            if (oPacienteDao.GetPaciente(dni) != null) { return true; }
            return false;
        }
        public void altaPaciente(Paciente ob, bool esAlta)
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
    }
}
