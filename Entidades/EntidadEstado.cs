using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadEstado
    {
        private int idEstados;
        private string estado;

        public EntidadEstado(string estado)
        {
            this.estado = estado;
        }

        public EntidadEstado(int idEstados, string estado)
        {
            this.idEstados = idEstados;
            this.estado = estado;
        }

        public int IdEstados { get => idEstados; set => idEstados = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
