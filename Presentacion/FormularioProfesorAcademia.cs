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
    public partial class FormularioProfesorAcademia : Form
    {
        #region campos
        private bool terminado = false;
        private EntidadContacto entidadContacto;
        private Contacto datoContacto = new Contacto();
        private Entidad_datos_profesor datos_Profesor;
        private Datos_Profesor datosProfesor = new Datos_Profesor();
        private EntidadPersona persona;
        private bool isActualizar = false;
        #endregion
        public bool Terminado { get => terminado; set => terminado = value; }
        public EntidadContacto EntidadContacto { get => entidadContacto; set => entidadContacto = value; }
        public Contacto DatoContacto { get => datoContacto; set => datoContacto = value; }
        public Entidad_datos_profesor Datos_Profesor { get => datos_Profesor; set => datos_Profesor = value; }
        public Datos_Profesor DatosProfesor { get => datosProfesor; set => datosProfesor = value; }
        public EntidadPersona Persona { get => persona; set => persona = value; }
        public bool IsActualizar { get => isActualizar; set => isActualizar = value; }

        public FormularioProfesorAcademia()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            ProcesarSolicitudAceptar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProcesarSolicitudCancelar();
        }


        public void ProcesarSolicitudAceptar()
        {
            llenarObjeto();
            if (!isActualizar)
            {
                Insertar();
            }
            else
            {
                Update();
            }

            Terminado = true;
            this.Close();
        }
        public void ProcesarSolicitudCancelar()
        {
            if(!IsActualizar)
                Delete();
            this.Close();
        }

        public void Insertar()
        {
            
            DatosProfesor.InsertDatosProfesor(Datos_Profesor);
        }

        public void Update()
        {
            DatosProfesor.ActulizarDatosProfesor(Datos_Profesor);
        }

        public void llenarObjeto()
        {
            datos_Profesor = new Entidad_datos_profesor(
                Persona.Matricula, ComboAcademia.Text
                );
        }

        public void Delete()
        {
            DatoContacto.DeletePersonaContacto(EntidadContacto);
        }

        private void FormularioProfesorAcademia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.academias' Puede moverla o quitarla según sea necesario.
            this.academiasTableAdapter.Fill(this.bdtecpeaDataSet.academias);

        }
    }
}
