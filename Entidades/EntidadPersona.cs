using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadPersona
    {
        #region Campos
        string matricula;
        string nombre;
        string apellido_paterno;
        string apellido_materno;
        string sexo;
        string fecha_nacimiento;
        string curp;
        int id_persona;
        string carrera;
        string especialidad;
        #endregion;

        #region Constructors
        public EntidadPersona()
        { }

        public EntidadPersona(string nombre, string apellido_paterno, string apellido_materno, string sexo, string fecha_nacimiento, string curp)
        {
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.curp = curp;
        }

        public EntidadPersona(string nombre, string apellido_paterno, string apellido_materno, string sexo, string fecha_nacimiento, string curp, int id_persona)
        {
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.curp = curp;
            this.id_persona = id_persona;
        }

        public EntidadPersona(string matricula, string nombre, string apellido_paterno, string apellido_materno, string sexo, string fecha_nacimiento, string curp, int id_persona)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.sexo = sexo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.curp = curp;
            this.id_persona = id_persona;
        }
        #endregion

        #region SetsyGets
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Curp { get => curp; set => curp = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        #endregion

        #region Query
        public static readonly string ALTA = "";

        public static readonly string BAJA = "";

        public static readonly string CAMBIO = "";

        public static readonly string LECTURA = "";

        
        #endregion


    }
}
