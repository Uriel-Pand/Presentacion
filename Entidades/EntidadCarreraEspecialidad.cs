using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCarreraEspecialidad
    {
        private int idCarreraEspecialidad;
        private string idEspecialidad;
        private string idCarrera;

        public EntidadCarreraEspecialidad(string idEspecialidad, string idCarrera)
        {
            this.IdEspecialidad = idEspecialidad;
            this.IdCarrera = idCarrera;
        }

        public EntidadCarreraEspecialidad(int idCarreraEspecialidad, string idEspecialidad, string idCarrera)
        {
            this.IdCarreraEspecialidad = idCarreraEspecialidad;
            this.IdEspecialidad = idEspecialidad;
            this.IdCarrera = idCarrera;
        }

        public int IdCarreraEspecialidad { get => idCarreraEspecialidad; set => idCarreraEspecialidad = value; }
        public string IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string IdCarrera { get => idCarrera; set => idCarrera = value; }
    }
}
