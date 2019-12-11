using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadGrupoAlumno
    {
        private int idGrupoAlumno;
        private string matricula;
        private string claveGrupo;

        public EntidadGrupoAlumno(string matricula, string claveGrupo)
        {
            this.matricula = matricula;
            this.claveGrupo = claveGrupo;
        }

        public EntidadGrupoAlumno(int idGrupoAlumno, string matricula, string claveGrupo)
        {
            this.IdGrupoAlumno = idGrupoAlumno;
            this.Matricula = matricula;
            this.ClaveGrupo = claveGrupo;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string ClaveGrupo { get => claveGrupo; set => claveGrupo = value; }
        public int IdGrupoAlumno { get => idGrupoAlumno; set => idGrupoAlumno = value; }
    }
}
