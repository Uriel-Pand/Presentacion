using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadLocalidad
    {
        private int idLocalidad;
        private string idEstado;
        private string idCiudad;

        public EntidadLocalidad(string idEstado, string idCiudad)
        {
            this.IdEstado = idEstado;
            this.IdCiudad = idCiudad;
        }

        public EntidadLocalidad(int idLocalidad, string idEstado, string idCiudad)
        {
            this.IdLocalidad = idLocalidad;
            this.IdEstado = idEstado;
            this.IdCiudad = idCiudad;
        }

        public int IdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public string IdEstado { get => idEstado; set => idEstado = value; }
        public string IdCiudad { get => idCiudad; set => idCiudad = value; }
    }
}
