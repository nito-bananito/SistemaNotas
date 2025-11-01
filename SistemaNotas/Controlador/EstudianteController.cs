using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaNotas.Modelos;

namespace SistemaNotas.Controlador
{
    public class EstudianteController
    {
        private List<Estudiantes> estudiantes = new List<Estudiantes>();
        public Boolean Agregar1(string nombre, string apellido, string codigo)
        {
            try
            {
                Estudiantes estudiante = new Estudiantes(nombre, apellido, codigo);
                estudiantes.Add(estudiante);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// odtiene todos los registros de carreras
        /// </summary>
        /// <returns></returns>

        public List<Estudiantes> GetEstudiantes()
        {
            return estudiantes;
        }

        public List<Estudiantes> GetEstudiantes(string dato)
        {
            return estudiantes.FindAll(c => c.Nombre.Contains(dato) || c.Apellido.Contains(dato));

        }

        public Estudiantes GetEstudiantes(string codigo, string nombre, string apellido)
        {
            Estudiantes estudiante = estudiantes.Find(c => c.Codigo == codigo);
            return estudiante;
        }

        public Boolean Eliminar1(string codigo, string nombre, string apellido)
        {
            Estudiantes estudiante = GetEstudiantes(codigo, nombre, apellido);
            if ( estudiante == null)
            {
                return false;
            }
            estudiantes.Remove(estudiante);
            return true;
        }
    }
}
