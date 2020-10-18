using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class PacienteE
    {
        private int dni;
        private string telefono;
        private string nombre;
        private string apellido;
        private string domicilio;
        private string email;
        private bool borrado;

        public int Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Email { get => email; set => email = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
