using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Modelos
{
    public class Estudiantes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Codigo { get; set; }


        public Estudiantes() { }

        public Estudiantes(string nombre, string apellido, string codigo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Codigo = codigo;
        }
    }
}
