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
    public partial class FormularioCont : Form
    {


        #region campos
        EntidadPersona persona;
        bool isAlumno;
        bool terminado = false;
        EntidadContacto contacto;
        Personas datosPersona = new Personas();
        Contacto datosContacto = new Contacto();
        #endregion

        #region SetsyGets
        public EntidadPersona Persona { get => persona; set => persona = value; }
        public bool IsAlumno { get => isAlumno; set => isAlumno = value; }
        public bool Terminado { get => terminado; set => terminado = value; }
        public Contacto DatosContacto { get => datosContacto; set => datosContacto = value; }

        #endregion

        #region AbrirForm
        public FormularioCont()
        {
            InitializeComponent();
        }

        public void AbrirFormularios()
        {
            if (IsAlumno)
            {
                FormularioAsignarCarrera formulario = new FormularioAsignarCarrera();
                formulario.Contacto = contacto;
                formulario.Persona = Persona;
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
                formulario.EntidadContacto = contacto;
                formulario.Persona = Persona;
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
            MessageBox.Show(ComboEstado.Text);
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
            else
            {
                MessageBox.Show("Aun no ha llenado Todos los elementos", "Advertencia");
            }
        }

        public void ProcesarSolicitudCancelar()
        {
            if (IsAlumno)
            {
                DeleteAlumno();
            }
            else
            {
                DeleteProfesor();
            }
            this.Close();
        }

        #endregion

        #region AltayBaja

        public void Incersion()
        {
            contacto = new EntidadContacto(
                            persona.Id_persona,
                            ComboEstado.Text,
                            ComboCiudad.Text,
                            ComboColonia.Text,
                            ComboCalle.Text,
                            Convert.ToInt32(TextNExt.Text),
                            TextNInt.Text,
                            Convert.ToInt64(TextTelefono.Text)
                           );
            if (ValidarTextBox(TextNInt))
                DatosContacto.InsertPersonaContactoConNumeroInt(contacto);
            else
                DatosContacto.InsertPersonaContactoSinNumeroInt(contacto);

        }

        public void DeleteAlumno()
        {
            datosPersona.DeletePersonaAlumno(Persona);
        }

        public void DeleteProfesor()
        {
            datosPersona.DeletePersonaProfesores(Persona);
        }

        #endregion

        #region Validacion
        private bool ValidacionConjunta()
        {
            if (ValidarTextBox(TextNExt) &&
                (ValidarTextBox(TextNInt) || true) &&
                ValidarTextBox(TextTelefono))
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

        private void FormularioCont_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.calles' Puede moverla o quitarla según sea necesario.
            this.callesTableAdapter.Fill(this.bdtecpeaDataSet.calles);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.colonias' Puede moverla o quitarla según sea necesario.
            this.coloniasTableAdapter.Fill(this.bdtecpeaDataSet.colonias);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.bdtecpeaDataSet.ciudades);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.bdtecpeaDataSet.estados);
            TextMatricula.Text = Persona.Matricula;
        }
    }
}
