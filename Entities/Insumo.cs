using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    class Insumo
    {
        private int id;
        private string nombre;
        private bool borrado;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}