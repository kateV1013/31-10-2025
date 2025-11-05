using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class DocenteController
    {
        private List<Docentes> docentes = new List<Docentes>();

        public bool Agregar(string nombre, string apellido)
        {
            try
            {
                Docentes docente = new Docentes(nombre, apellido);
                docentes.Add(docente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Docentes> GetDocentes()
        {
            return docentes;
        }
        public Docentes GetDocente(string nombre)
        {
            Docentes docente = docentes.Find(d => d.Nombre == nombre);
            return docente;
        }
        public bool Eliminar(string nombre, string apellido)
        {   
           var docente = docentes.Find(d => d.Nombre == nombre && d.Apellido == apellido);
            if (docente != null)
            {
                docentes.Remove(docente);
                return true;
            }
            return false;
        }
        public List<Docentes> Buscar(string dato)
        {
            var resultado = docentes.Where(d => d.Nombre.Contains(dato) || d.Apellido.Contains(dato)).ToList();
            return resultado;
        }


    }
}
