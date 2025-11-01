using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    //Create, Read, Update, Delate
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();
        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(nombre, codigo);
                carreras.Add(carrera);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Carrera> GetCarreras()
        {
            return carreras;
        }
        public Carrera GetCarrera(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }
        public Boolean Eliminar(string codigo, string nombre)
        {
            Carrera carrera = GetCarrera(codigo, nombre);
            if (carrera != null)
            {
                carreras.Remove(carrera);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Obtiene todas las carreras registradas
        /// </summary>
        /// <returns></returns>
        public List<Carrera> GetAll()
        {
            return carreras;
        }
        /// <summary>
        /// Busca un elemento y muesta todos los registros encontrados
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public List<Carrera> GetAll(string dato)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == dato || c.Nombre == dato);
            return carreras;
        }
        public Carrera GetAll(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        } 
        public Boolean GetEliminar(string nombre, string codigo)
        {
            Carrera carrera = GetAll(codigo, nombre);
            if (carrera != null)
            {
                carreras.Remove(carrera);
                return true;
            }
            return false;
        }
        public List<Carrera> GetCarreras(string dato)
        {
            return carreras.FindAll(c => c.Codigo == dato || c.Nombre == dato);
        }
    }
}
