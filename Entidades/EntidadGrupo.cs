using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadGrupo
    {
        private string claveGrupo;
        private string idMateria;
        private string idProfesor;

        public EntidadGrupo(string idMateria, string idProfesor)
        {
            this.IdMateria = idMateria;
            this.IdProfesor = idProfesor;
        }

        public EntidadGrupo(string claveGrupo, string idMateria, string idProfesor)
        {
            this.ClaveGrupo = claveGrupo;
            this.IdMateria = idMateria;
            this.IdProfesor = idProfesor;
        }

        public string ClaveGrupo { get => claveGrupo; set => claveGrupo = value; }
        public string IdMateria { get => idMateria; set => idMateria = value; }
        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
    }
}
