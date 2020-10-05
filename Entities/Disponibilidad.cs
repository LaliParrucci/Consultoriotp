using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class Disponibilidad
    {
        private int matricula;
        private string fecha;
        private string hora;
        private int paciente;
        private bool disponible;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Paciente { get => paciente; set => paciente = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
    }
}
