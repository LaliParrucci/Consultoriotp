using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class ProfesionalE
    {
        private int matricula;
        private string nombre;
        private string apellido;
        private string domicilio;
        private bool borrado;
        private string especialidad;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
