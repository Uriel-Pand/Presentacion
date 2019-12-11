using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadMateria
    {

        private string idMaterias;
        private string materia;
        private int horasTeoricas;
        private int horasPracticas;
        private int creditos;
        private string idCarreras;

        public EntidadMateria(string materia, int horasTeoricas, int horasPracticas, int creditos, string idCarreras)
        {
            this.Materia = materia;
            this.HorasTeoricas = horasTeoricas;
            this.HorasPracticas = horasPracticas;
            this.Creditos = creditos;
            this.IdCarreras = idCarreras;
        }

        public EntidadMateria(string idMaterias, string materia, int horasTeoricas, int horasPracticas, int creditos, string idCarreras)
        {
            this.IdMaterias = idMaterias;
            this.Materia = materia;
            this.HorasTeoricas = horasTeoricas;
            this.HorasPracticas = horasPracticas;
            this.Creditos = creditos;
            this.IdCarreras = idCarreras;
        }

        public string IdMaterias { get => idMaterias; set => idMaterias = value; }
        public string Materia { get => materia; set => materia = value; }
        public int HorasTeoricas { get => horasTeoricas; set => horasTeoricas = value; }
        public int HorasPracticas { get => horasPracticas; set => horasPracticas = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        public string IdCarreras { get => idCarreras; set => idCarreras = value; }
    }
}
