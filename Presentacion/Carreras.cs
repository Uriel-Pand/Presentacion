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
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_carreras' Puede moverla o quitarla según sea necesario.
            this.vista_carrerasTableAdapter.Fill(this.bdtecpeaDataSet.vista_carreras);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormularioCarrera formulario = new FormularioCarrera();
            formulario.ShowDialog();
            Cargar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            FormularioCarrera formulario = new FormularioCarrera();

            formulario.ShowDialog();
        }
    }
}
