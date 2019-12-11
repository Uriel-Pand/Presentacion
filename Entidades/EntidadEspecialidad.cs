using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadEspecialidad
    {
        private int idEspecialidad;
        private string especialidad;

        public EntidadEspecialidad(string especialidad)
        {
            this.Especialidad = especialidad;
        }

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
