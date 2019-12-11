using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad_datos_profesor
    {
        #region Campos
        string matricula;
        string academia;
        #endregion

        #region Constructores
        public Entidad_datos_profesor(string matricula, string academia)
        {
            this.Matricula = matricula;
            this.Academia = academia;
        }
        #endregion

        #region SetsyGets
        public string Matricula { get => matricula; set => matricula = value; }
        public string Academia { get => academia; set => academia = value; }
        #endregion
    }
}
