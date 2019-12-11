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
    public partial class FormularioAsignarCarrera : Form
    {
        private bool terminacion = false;
        private EntidadPersona persona;
        private Datos_Alumno datos_alumno= new Datos_Alumno();
        private EntidadContacto contacto;
        private Contacto DatoContacto = new Contacto();
        private bool isActualizacion = false;
 

        public FormularioAsignarCarrera()
        {
            InitializeComponent();
        }

        public bool Terminacion { get => terminacion; set => terminacion = value; }
        public EntidadPersona Persona { get => persona; set => persona = value; }
        public EntidadContacto Contacto { get => contacto; set => contacto = value; }
        public bool IsActualizacion { get => isActualizacion; set => isActualizacion = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(!IsActualizacion)
                Delete();

            this.Close();

        }

        public void Procesar()
        {
            llenarObjeto();
            if (!isActualizacion)
            {
                Insertar();
            }
            else
            {
                Actulizar();
            }
            Terminacion = true;
            this.Close();
        }

        public void Delete()
        {
            DatoContacto.DeletePersonaContacto(Contacto);
        }

        public void Insertar()
        {
            
            datos_alumno.InsertDatosAlumno(Persona); 
        }

        private void FormularioAsignarCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.bdtecpeaDataSet.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.bdtecpeaDataSet.carreras);
        }

        public void Actulizar()
        {
            datos_alumno.UpdateDatosAlumno(Persona);
        }

        public void llenarObjeto()
        {
            Persona.Carrera = comboBox1.Text;
            Persona.Especialidad = comboBox2.Text;
        }

    }
}
