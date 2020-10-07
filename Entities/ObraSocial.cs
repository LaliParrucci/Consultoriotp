using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class ObraSocial
    {
        private int codigo;
        private string nombre;
        private bool borrado;
        private float porcentaje;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
