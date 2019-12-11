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
    public partial class FormularioNuevoGrupo : Form
    {
        private bool isActulizar = false;
        private EntidadGrupo grupoe;
        private Grupo grupod = new Grupo();

        public bool IsActulizar { get => isActulizar; set => isActulizar = value; }
        public EntidadGrupo Grupoe { get => grupoe; set => grupoe = value; }
        public Grupo Grupod { get => grupod; set => grupod = value; }

        public FormularioNuevoGrupo()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void FormularioNuevoGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_profesores' Puede moverla o quitarla según sea necesario.
            this.vista_profesoresTableAdapter.Fill(this.bdtecpeaDataSet.vista_profesores);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.bdtecpeaDataSet.profesores);
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.bdtecpeaDataSet.materias);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Procesar()
        {
            llenarObjeto();
            if (!IsActulizar)
            {
                Insertar();
            }
            else
            {
                Actualizar();
            }
            this.Close();
        }

        public void Insertar()
        {
            Grupod.InsertGrupo(Grupoe);
        }

        public void Actualizar()
        {
            Grupod.UpdateGrupo(Grupoe);
        }

        public void llenarObjeto()
        {
            Grupoe = new EntidadGrupo(
                idMateria: ComboClave.SelectedValue.ToString(),
                idProfesor: ComboProfesor.SelectedValue.ToString(),
                claveGrupo: TextClaveGrupo.Text
                ); 
        }
    }
}
