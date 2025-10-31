using System;
using SistemaNotas.Modelos;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SistemaNotas.Controlador
{   
    public class CarrreraController
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

        /// <summary>
        /// odtiene todos los registros de carreras
        /// </summary>
        /// <returns></returns>

        public List<Carrera> GetCarreras()
        {
            return carreras;
        }

        public List<Carrera>GetCarreras(string dato)
        {
            return carreras.FindAll(c => c.Nombre.Contains(dato));          
        }

        public Carrera GetCarrera(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }

        public Boolean Eliminar(string codigo, string nombre)
        {
            Carrera carrera = GetCarrera(codigo, nombre);
            if (carrera == null)
            {
                return false;
            }
            carreras.Remove(carrera);
            return true;
        }
    }
}
