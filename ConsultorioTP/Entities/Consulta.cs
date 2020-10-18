using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class Consulta
    {
        private int id_consulta;
        private DateTime fecha;
        private int id_paciente;
        private string practicas_realizadas;
        private bool cobrado;
        private int id_profesional;
        private float monto;
        private int num_turno;
        private string observacion;

        public int Id_consulta { get => id_consulta; set => id_consulta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string Practicas_realizadas { get => practicas_realizadas; set => practicas_realizadas = value; }
        public bool Cobrado { get => cobrado; set => cobrado = value; }
        public int Id_profesional { get => id_profesional; set => id_profesional = value; }
        public float Monto { get => monto; set => monto = value; }
        public int Num_turno { get => num_turno; set => num_turno = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
