using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Modelos
{
    public class Docentes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Docentes() { }
        public Docentes(string nombre, string apellido)
        {
            Apellido = apellido;
            Nombre = nombre;
        }
    }
}
