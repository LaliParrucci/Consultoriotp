using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class Turno
    {
        private int num_turno;
        private DateTime fecha;
        private string hora;
        private int id_paciente;
        private int id_profesional;
        private string estado;
        private bool borrado;
        private int id_obra_social;

        public int Num_turno { get => num_turno; set => num_turno = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
        public int Id_profesional { get => id_profesional; set => id_profesional = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public int Id_obra_social { get => id_obra_social; set => id_obra_social = value; }
    }
}
