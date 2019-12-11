using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadContacto
    {
        #region campos

        int id_Persona;
        string estado;
        string ciudad;
        string colonia;
        string calle;
        int numero_exterior;
        string numero_interior;
        long telefono;
        #endregion

        #region Constructores
        public EntidadContacto() { }

        public EntidadContacto(string estado, string ciudad, string colonia, string calle, int numero_exterior, string numero_interior, long telefono)
        {
            this.Estado = estado;
            this.Ciudad = ciudad;
            this.Colonia = colonia;
            this.Calle = calle;
            this.Numero_exterior = numero_exterior;
            this.Numero_interior = numero_interior;
            this.Telefono = telefono;
        }

        public EntidadContacto(int id_Persona, string estado, string ciudad, string colonia, string calle, int numero_exterior, string numero_interior, long telefono)
        {
            this.Id_Persona = id_Persona;
            this.Estado = estado;
            this.Ciudad = ciudad;
            this.Colonia = colonia;
            this.Calle = calle;
            this.Numero_exterior = numero_exterior;
            this.Numero_interior = numero_interior;
            this.Telefono = telefono;
        }

        #endregion

        #region SetsyGets
        public int Id_Persona { get => id_Persona; set => id_Persona = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero_exterior { get => numero_exterior; set => numero_exterior = value; }
        public string Numero_interior { get => numero_interior; set => numero_interior = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region Query
        public static readonly string ALTA = "";

        public static readonly string BAJA = "";

        public static readonly string CAMBIO = "";

        public static readonly string LECTURA = "";


        #endregion
    }
}
