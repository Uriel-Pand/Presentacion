using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadProfesor
    {
        private int idProfesor;
        private string personas;
        private int estatus;

        public EntidadProfesor(string personas, int estatus)
        {
            this.personas = personas;
            this.estatus = estatus;
        }

        public EntidadProfesor(int idProfesor, string personas, int estatus)
        {
            this.IdProfesor = idProfesor;
            this.Personas = personas;
            this.Estatus = estatus;
        }

        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Personas { get => personas; set => personas = value; }
        public int Estatus { get => estatus; set => estatus = value; }

    }
}
