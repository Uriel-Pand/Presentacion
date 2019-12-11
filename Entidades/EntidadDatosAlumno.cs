using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadDatosAlumno
    {
        private string matricula;
        private string idCarreraEspecialidad;

        public EntidadDatosAlumno(string matricula, string idCarreraEspecialidad)
        {
            this.Matricula = matricula;
            this.IdCarreraEspecialidad = idCarreraEspecialidad;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string IdCarreraEspecialidad { get => idCarreraEspecialidad; set => idCarreraEspecialidad = value; }
    }
}
