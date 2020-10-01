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
        private string semana;
        private string hora;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Semana { get => semana; set => semana = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
