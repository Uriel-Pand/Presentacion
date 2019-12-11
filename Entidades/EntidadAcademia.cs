using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadAcademia
    {
        private int idAcademia;
        private string academia;

        public EntidadAcademia(string academia)
        {
            this.academia = academia;
        }

        public EntidadAcademia(int idAcademia, string academia)
        {
            this.idAcademia = idAcademia;
            this.academia = academia;
        }

        public int IdAcademia { get => idAcademia; set => idAcademia = value; }
        public string Academia { get => academia; set => academia = value; }
    }
}
