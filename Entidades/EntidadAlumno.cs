using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadAlumno
    {
        private string matricula;
        private int status;
        private string idPersona;

        public EntidadAlumno(int status, string idPersona)
        {
            this.Status = status;
            this.IdPersona = idPersona;
        }

        public EntidadAlumno(string matricula, int status, string idPersona)
        {
            this.Matricula = matricula;
            this.Status = status;
            this.IdPersona = idPersona;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public int Status { get => status; set => status = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }
    }
}
