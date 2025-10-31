using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SistemaNotas.Modelos;

namespace SistemaNotas.Controlador
{
    public class DocenteController
    {
        private List<Docente> docentes = new List<Docente>();
        public Boolean Agregar1(string nombre, string apellido, string codigo)
        {
            try
            {
                Docente docente = new Docente(nombre, apellido, codigo);
                docentes.Add(docente);
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

        public List<Docente> GetDocentes()
        {
            return docentes;
        }

        public List<Docente> GetDocentes(string dato)
        {
            return docentes.FindAll(c => c.Nombre.Contains(dato) || c.Apellido.Contains(dato));
            
        }

        public Docente GetDocentes(string codigo, string nombre, string apellido)
        {
            Docente docente = docentes.Find(c => c.Codigo == codigo);
            return docente;
        }

        public Boolean Eliminar1(string codigo, string nombre, string apellido)
        {
            Docente docente = GetDocentes(codigo, nombre, apellido);
            if (docente == null)
            {
                return false;
            }
            docentes.Remove(docente);
            return true;
        }
    }
}
