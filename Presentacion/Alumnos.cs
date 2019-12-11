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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormularioPersona formulario = new FormularioPersona();
            formulario.IsEstudiante = true;
            formulario.ShowDialog();
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarInformacion formulario = new ActualizarInformacion();
            formulario.TextMatricula.Text = dataAlumnos.CurrentRow.Cells[0].Value.ToString();
            formulario.textNombre.Text = dataAlumnos.CurrentRow.Cells[1].Value.ToString();
            formulario.textApellidoP.Text = dataAlumnos.CurrentRow.Cells[2].Value.ToString();
            formulario.textApellidoM.Text = dataAlumnos.CurrentRow.Cells[3].Value.ToString();
            formulario.BtnCmabiar.Text += "Carrera";
            formulario.IsEstudiante = true;
            formulario.ShowDialog();
            cargar();
        }

        private void BtnAsignarMaterias_Click(object sender, EventArgs e)
        {
            FormularioAsignarMaterias formulario = new FormularioAsignarMaterias();
            formulario.TextMatricula.Text = dataAlumnos.CurrentRow.Cells[0].Value.ToString();
            formulario.ShowDialog();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

            cargar();
        }

        public void cargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_alumno' Puede moverla o quitarla según sea necesario.
            this.vista_alumnoTableAdapter.Fill(this.bdtecpeaDataSet.vista_alumno);
        }
    }
}
