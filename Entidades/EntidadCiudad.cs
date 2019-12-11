using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCiudad
    {
        private int idCiudad;
        private string ciudada;

        public EntidadCiudad(string ciudada)
        {
            this.Ciudada = ciudada;
        }

        public EntidadCiudad(int idCiudad, string ciudada)
        {
            this.IdCiudad = idCiudad;
            this.Ciudada = ciudada;
        }

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Ciudada { get => ciudada; set => ciudada = value; }
    }
}
