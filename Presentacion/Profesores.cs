using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormularioPersona formulario = new FormularioPersona();
            formulario.IsEstudiante = false;
            formulario.ShowDialog();
            Cargar();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarInformacion formulario = new ActualizarInformacion();
            formulario.TextMatricula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            formulario.textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            formulario.textApellidoP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            formulario.textApellidoM.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            formulario.BtnCmabiar.Text += "Academia";
            //formulario.BtnCambiar.Text += "Academia";
            formulario.ShowDialog();
            Cargar();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            Cargar();   
        }


        private void Cargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_profesores' Puede moverla o quitarla según sea necesario.
            this.vista_profesoresTableAdapter.Fill(this.bdtecpeaDataSet.vista_profesores);

        }

        private void BtnAsignarMaterias_Click(object sender, EventArgs e)
        {

        }
    }
}
