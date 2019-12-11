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

namespace Presentacion
{
    public partial class FormularioContacto : Form
    {
        #region campos
        int id_Persona;
        bool isAlumno;
        bool terminado = false;
        #endregion

        #region SetsyGets
        public int Id_Persona { get => id_Persona; set => id_Persona = value; }
        public bool IsAlumno { get => isAlumno; set => isAlumno = value; }
        public bool Terminado { get => terminado; set => terminado = value; }

        #endregion

        #region AbrirForm
        public FormularioContacto()
        {
            InitializeComponent();
        }

        public void AbrirFormularios()
        {
            if (IsAlumno)
            {
                FormularioAsignarCarrera formulario = new FormularioAsignarCarrera();
                formulario.ShowDialog();
                if (formulario.Terminacion)
                {
                    Terminado = true;
                    this.Close();
                }
            }
            else
            {
                FormularioProfesorAcademia formulario = new FormularioProfesorAcademia();
                formulario.ShowDialog();
                if (formulario.Terminado)
                {
                    Terminado = true;
                    this.Close();
                }
            }
        }

        #endregion

        #region eventosClick
        private void Button2_Click(object sender, EventArgs e)
        {
            ProcesarSolicitudCancelar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProcesarSolicitudAceptar();
        }

        private void ComboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboEstado.SelectedIndex >= 1)
                ComboCiudad.Enabled = true;
            else
            {
                ComboCiudad.Enabled = false;
                ComboColonia.Enabled = false;
                ComboCalle.Enabled = false;

                //ComboCiudad.SelectedIndex = 0;   
                //ComboColonia.SelectedIndex = 0;
                //ComboCalle.SelectedIndex = 0;
            }
        }

        private void ComboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCiudad.SelectedIndex >= 1)
                ComboColonia.Enabled = true;
            else
            {
                ComboColonia.Enabled = false;
                ComboCalle.Enabled = false;
                ComboColonia.SelectedIndex = 0;
                ComboCalle.SelectedIndex = 0;
            }
        }

        private void ComboColonia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboColonia.SelectedIndex >= 1)
                ComboCalle.Enabled = true;
            else
            {
                ComboCalle.Enabled = false;
                ComboCalle.SelectedIndex = 0;
            }
        }

        #endregion

        #region ProcesarSolicitud
        public void ProcesarSolicitudAceptar()
        {
            if (ValidacionConjunta())
            {
                Incersion();
                AbrirFormularios();
            }
        }

        public void ProcesarSolicitudCancelar()
        {
            Delete();
            this.Close();
        }
        
        #endregion

        #region AltayBaja

        public void Incersion()
        {
            //REGISTRAR A LA PERSONA COMPLETAMENTE
            //Hacer insercion
            EntidadContacto contacto = new EntidadContacto(
                            Id_Persona,
                            ComboEstado.SelectedItem.ToString(),
                            ComboCiudad.SelectedItem.ToString(),
                            ComboColonia.SelectedItem.ToString(),
                            ComboCalle.SelectedItem.ToString(),
                            Convert.ToInt32(TextNExt.Text),
                            TextNInt.Text,
                            Convert.ToInt64(TextTelefono.Text)
                           );
        }

        public void Delete()
        {
            //Eliminar el registro de persona
        }

        #endregion

        #region Validacion
        private bool ValidacionConjunta()
        {
            if (ValidarComboBox(ComboEstado) &&
                ValidarComboBox(ComboCiudad) &&
                ValidarComboBox(ComboColonia) &&
                ValidarComboBox(ComboCalle) &&
                ValidarTextBox(TextNExt) &&
                ValidarTextBox(TextNInt))
                return true;
            return false;
        }


        private bool ValidarTextBox(TextBox text)
        {
            if (text.Text.Equals("")) return false;

            return true;
        }

        private bool ValidarComboBox(ComboBox box)
        {
            if (box.SelectedIndex == 0) return false;

            return true;
        }

        #endregion

        #region EventosTeclado
        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ValidacionConjunta())
                if (e.KeyCode == Keys.Enter)
                {
                    ProcesarSolicitudAceptar();
                }
        }
        #endregion

    }
}
