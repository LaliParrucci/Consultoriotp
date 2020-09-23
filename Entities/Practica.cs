using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Entities
{
    public class Practica
    {
        //private string nombre, descripcion;
        //private int id_practica, importe;
        //private Boolean borrado;

        //public string Nombre { get => nombre; set => nombre = value; }
        //public string Descripcion { get => descripcion; set => descripcion = value; }
        //public int Importe { get => importe; set => importe = value; }
        //public int Id_practica { get => id_practica; set => id_practica = value; }
        //public Boolean Borrado { get => borrado; set => borrado = value; }

        public int Id_practica { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Importe { get; set; }
        public bool Borrado { get; set; }
    }
}
