using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class ActualizarInformacion : Form
    {
        #region Campos
        private EntidadPersona persona;
        private Personas personas = new Personas();
        private bool isEstudiante = false;
        private Contacto contactos = new Contacto();
        private EntidadContacto contacto;
        string fecha;
        string sexo;
        #endregion

        #region SetsyGets
        public EntidadPersona Persona { get => persona; set => persona = value; }
        public Personas Personas { get => personas; set => personas = value; }
        public bool IsEstudiante { get => isEstudiante; set => isEstudiante = value; }
        public Contacto Contactos { get => contactos; set => contactos = value; }
        public EntidadContacto Contacto { get => contacto; set => contacto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        #endregion

        public ActualizarInformacion()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Actualizar();
            this.Close();
        }

        public void procesarInfoPersona()
        {
            if (IsEstudiante)
                Persona = Personas.MostrarPersonaaAlumno(TextMatricula.Text);
            else
                Persona = Personas.MostrarPersonaProfesor(TextMatricula.Text);
        }

        public void procesarInfoContacto()
        {
            Contacto = Contactos.MostrarPersonaaContacto(Persona.Id_persona);
        }

        public void llenarCampos()
        {
            TimeFechaNacimiento.Value = Convert.ToDateTime(Persona.Fecha_nacimiento);
            ComboEstado.SelectedItem = Contacto.Estado;
            ComboCiudad.SelectedItem = Contacto.Ciudad;
            ComboCalle.SelectedItem = Contacto.Calle;
            ComboColonia.SelectedItem = Contacto.Colonia;
            TextTelefono.Text = Contacto.Telefono.ToString();
            TextNExt.Text = Contacto.Numero_exterior.ToString();
            TextNInt.Text = Contacto.Numero_interior;
            Sexo = Persona.Sexo;
            CheckedSexo();
        }

        public void CheckedSexo()
        {
            if(Sexo == "F")
            {
                RBtnHombre.Checked = false;
                RBtnMujer.Checked = true;
            }

        }

        public void llenarObjetoPersona()
        {
            Persona.Nombre = textNombre.Text;
            Persona.Apellido_paterno = textApellidoP.Text;
            Persona.Apellido_materno = textApellidoM.Text;
            Persona.Fecha_nacimiento = Fecha;
        }

        public void llenarObjetoContacto()
        {
            Contacto.Estado = ComboEstado.Text;
            Contacto.Ciudad = ComboCiudad.Text;
            Contacto.Colonia = ComboColonia.Text;
            Contacto.Calle = ComboCiudad.Text;
            Contacto.Numero_exterior = Convert.ToInt32(TextNExt.Text);
            Contacto.Numero_interior = TextNInt.Text;
            Contacto.Telefono = Convert.ToInt64(TextTelefono.Text);
        }

        public void llenarObjetos()
        {
            llenarObjetoContacto();
            llenarObjetoPersona();
        }

        public void Actualizar()
        {
            llenarObjetos();
            Contactos.UpdatePersonaContactoConNumeroInt(Contacto);
            Personas.UpdatePersona(Persona);
        }

        private void ActualizarInformacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.calles' Puede moverla o quitarla según sea necesario.
            this.callesTableAdapter.Fill(this.bdtecpeaDataSet.calles);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.colonias' Puede moverla o quitarla según sea necesario.
            this.coloniasTableAdapter.Fill(this.bdtecpeaDataSet.colonias);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.bdtecpeaDataSet.ciudades);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.bdtecpeaDataSet.estados);
            procesarInfoPersona();
            Persona.Matricula = TextMatricula.Text;
            procesarInfoContacto();
            llenarCampos();
        }

        private void TimeFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            Fecha = TimeFechaNacimiento.Value.Year + "/"
                + TimeFechaNacimiento.Value.Month + "/" +
                TimeFechaNacimiento.Value.Day;
        }

        private void RBtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "H";
        }

        private void RBtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "M";
        }

        private void BtnCmabiar_Click(object sender, EventArgs e)
        {
            if (IsEstudiante)
            {
                FormularioAsignarCarrera formulario = new FormularioAsignarCarrera();
                formulario.IsActualizacion = true;
                formulario.Persona = persona;
                formulario.ShowDialog();
            }
            else
            {
                FormularioProfesorAcademia formulario = new FormularioProfesorAcademia();
                formulario.IsActualizar = true;
                formulario.Persona = persona;
                formulario.ShowDialog();
            }
        }
    }
}
