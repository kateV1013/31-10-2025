using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class DocenteController
    {
        private List<string> docentes = new List<string>();
    }
    public Boolean Agregar(string nombre)
    {
        try
        {
            docentes.Add(nombre);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        }
    }
