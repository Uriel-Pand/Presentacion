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
    public partial class Materias : Form
    {
        bool isActualizar = false;

        public bool IsActualizar { get => isActualizar; set => isActualizar = value; }

        public Materias()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            cargar();

        }

        public void cargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_materias' Puede moverla o quitarla según sea necesario.
            this.vista_materiasTableAdapter.Fill(this.bdtecpeaDataSet.vista_materias);

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        public void Procesar()
        {
            if (!IsActualizar) {
                FormularioMaterias formulario = new FormularioMaterias();
                formulario.TextID.Enabled = true;
                formulario.ShowDialog();
                cargar();
            }
            else
            {
                FormularioMaterias formulario = new FormularioMaterias();
                formulario.TextID.Text = dataMaterias.CurrentRow.Cells[0].Value.ToString();
                formulario.TextMateria.Text = dataMaterias.CurrentRow.Cells[1].Value.ToString();
                formulario.TextHrsT.Text = dataMaterias.CurrentRow.Cells[2].Value.ToString();
                formulario.TextHrsP.Text = dataMaterias.CurrentRow.Cells[3].Value.ToString();
                formulario.TextCreditos.Text = dataMaterias.CurrentRow.Cells[4].Value.ToString();
                formulario.ComboCarrera.SelectedItem = dataMaterias.CurrentRow.Cells[5].Value.ToString();
                formulario.IsActualizar = true;
                formulario.ShowDialog();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            isActualizar = true;
            Procesar();
            isActualizar = false;
        }
    }
}
