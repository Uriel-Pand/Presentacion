using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCalificacion
    {
        private int idCalificacion;
        private string idGruposAlumno;
        private float calificacion;
        private int tema;

        public EntidadCalificacion(string idGruposAlumno, float calificacion, int tema)
        {
            this.IdGruposAlumno = idGruposAlumno;
            this.Calificacion = calificacion;
            this.Tema = tema;
        }

        public EntidadCalificacion(int idCalificacion, string idGruposAlumno, float calificacion, int tema)
        {
            this.IdCalificacion = idCalificacion;
            this.IdGruposAlumno = idGruposAlumno;
            this.Calificacion = calificacion;
            this.Tema = tema;
        }

        public int IdCalificacion { get => idCalificacion; set => idCalificacion = value; }
        public string IdGruposAlumno { get => idGruposAlumno; set => idGruposAlumno = value; }
        public float Calificacion { get => calificacion; set => calificacion = value; }
        public int Tema { get => tema; set => tema = value; }
    }
}
