using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;

namespace Presentacion
{
    public partial class FormularioPersona : Form
    {
        #region campos
        string sexo = "H";
        string fecha = "";
        bool isEstudiante;
        EntidadPersona Persona;
        Personas datosPersona = new Personas();
        #endregion

        #region SetsyGets
        public bool IsEstudiante { get => isEstudiante; set => isEstudiante = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public EntidadPersona Persona1 { get => Persona; set => Persona = value; }
        public Personas DatosPersona { get => datosPersona; set => datosPersona = value; }
        #endregion

        public FormularioPersona()
        {
            InitializeComponent();
        }
        #region SEXO
        private void RBtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "H";
        }

        private void RBtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "M";
        }
        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        public void Procesar()
        {
            if (ValidacionConjunta())
            {
                if (IsEstudiante)
                {
                    InsertarAlumno();
                    AbriFormularioEstudiante();
                }
                else
                {
                    InsertarProfesor();
                    AbriFormularioProfesor();
                }
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia");
            }
        }

        public void AbriFormularioEstudiante()
        {
            FormularioCont formulario = new FormularioCont();
            formulario.Persona = Persona1;
            formulario.IsAlumno = true;
            formulario.ShowDialog();

            if (formulario.Terminado)
            {
                this.Close();
            }

        }
        public void AbriFormularioProfesor()
        {
            FormularioCont formulario = new FormularioCont();
            formulario.Persona = Persona1;
            formulario.ShowDialog();

            if (formulario.Terminado)
            {
                this.Close();
            }
        }

        public void InsertarAlumno()
        {
            Persona1 = new EntidadPersona(
                   textNombre.Text, textApellidoP.Text,
                   textApellidoM.Text, Sexo, Fecha, textCurp.Text
                   );
            Persona1 = DatosPersona.InsertPersonaAlumno(Persona1);
        }

        public void InsertarProfesor()
        {
            Persona1 = new EntidadPersona(
                   textNombre.Text, textApellidoP.Text,
                   textApellidoM.Text, Sexo, Fecha, textCurp.Text
                   );
            Persona1 = DatosPersona.InsertPersonaProfesor(Persona1);
        }


        #region Validacion

        private void TimeFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            Fecha = TimeFechaNacimiento.Value.Year + "/"
                + TimeFechaNacimiento.Value.Month + "/" +
                TimeFechaNacimiento.Value.Day;
        }


        private bool ValidacionConjunta()
        {
            if (validacionSeparada(textApellidoM) &&
                validacionSeparada(textApellidoP) &&
                validacionSeparada(textNombre) &&
                validacionSeparada(textCurp) &&
                !Fecha.Equals(""))
                return true;
            return false;
        }

        private bool validacionSeparada(TextBox text)
        {
            if (text.Text.Equals("")) return false;

            return true;
        }
        #endregion
    }
}
