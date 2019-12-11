using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadCalle
    {
        private int idCalle;
        private string calle;

        public EntidadCalle(string calle)
        {
            this.calle = calle;
        }

        public EntidadCalle(int idCalle, string calle)
        {
            this.IdCalle = idCalle;
            this.Calle = calle;
        }

        public int IdCalle { get => idCalle; set => idCalle = value; }
        public string Calle { get => calle; set => calle = value; }
    }
}
