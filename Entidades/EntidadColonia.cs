using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadColonia
    {
        private int idColonia;
        private string colonia;

        public EntidadColonia(string colonia)
        {
            this.colonia = colonia;
        }

        public EntidadColonia(int idColonia, string colonia)
        {
            this.IdColonia = idColonia;
            this.Colonia = colonia;
        }

        public int IdColonia { get => idColonia; set => idColonia = value; }
        public string Colonia { get => colonia; set => colonia = value; }
    }
}
