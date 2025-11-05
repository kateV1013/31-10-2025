using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class EstudiantesController
    {
        private List<Estudiantes> estudiantes = new List<Estudiantes>();

        public bool Agregar(string nombre, string codigo)
        {

            try
            {
                Estudiantes estudiante = new Estudiantes(nombre, codigo);
                estudiantes.Add(estudiante);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Estudiantes> GetEstudiantes()
        {
            return estudiantes;
        }

        public Estudiantes GetEstudiante(string codigo)
        {
            return estudiantes.Find(e => e.Codigo == codigo);
        }

        public bool Eliminar(string nombre, string codigo)
        {
            var estudiante = estudiantes.Find(e => e.Nombre == nombre && e.Codigo == codigo);
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
                return true;
            }
            return false;
        }

        public List<Estudiantes> Buscar(string dato)
        {
            var resultado = estudiantes.Where(e => e.Nombre.Contains(dato) || e.Codigo.Contains(dato)).ToList();
            return resultado;
        }
    }
}