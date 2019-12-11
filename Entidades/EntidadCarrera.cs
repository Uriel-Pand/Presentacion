using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCarrera
    {
        private int idCarrera;
        private string carrera;
        private string coordinador;

        public EntidadCarrera(string carrera, string coordinador)
        {
            this.Carrera = carrera;
            this.Coordinador = coordinador;
        }

        public EntidadCarrera(int idCarrera, string carrera, string coordinador)
        {
            this.IdCarrera = idCarrera;
            this.Carrera = carrera;
            this.Coordinador = coordinador;
        }

        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Coordinador { get => coordinador; set => coordinador = value; }
    }
}
