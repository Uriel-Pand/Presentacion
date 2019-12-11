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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_grupos' Puede moverla o quitarla según sea necesario.
            this.vista_gruposTableAdapter.Fill(this.bdtecpeaDataSet.vista_grupos);

        }

        private void BtnAsignarMaterias_Click(object sender, EventArgs e)
        {
            procesar(1);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            procesar(2);
        }

        public void procesar(int buton)
        {
            if (buton == 1)
                abrirFormVista();
            else if (buton == 2)
            {
                abrirFormNuevo();
            }
            else if (buton == 3)
            {
                abrirFormCambio();
            }
            cargar();
        }

        public void abrirFormVista()
        {
            FormularioVerGrupos formulario = new FormularioVerGrupos();
            formulario.TextClaveGrupo.Text = dataAlumnos.CurrentRow.Cells[0].Value.ToString();
            formulario.TextClaveMateria.Text = dataAlumnos.CurrentRow.Cells[1].Value.ToString();
            formulario.TextMateria.Text = dataAlumnos.CurrentRow.Cells[2].Value.ToString();
            formulario.TextCreditos.Text = dataAlumnos.CurrentRow.Cells[3].Value.ToString();
            formulario.TextCarrera.Text = dataAlumnos.CurrentRow.Cells[4].Value.ToString();
            formulario.TextEspecialida.Text = dataAlumnos.CurrentRow.Cells[5].Value.ToString();
            formulario.TextProfesor.Text = dataAlumnos.CurrentRow.Cells[6].Value.ToString();

            formulario.TextClaveGrupo.Enabled = false;
            formulario.TextClaveMateria.Enabled = false;
            formulario.TextMateria.Enabled = false;
            formulario.TextCreditos.Enabled = false;
            formulario.TextCarrera.Enabled = false;
            formulario.TextEspecialida.Enabled = false;
            formulario.TextProfesor.Enabled = false;
            formulario.ShowDialog();
        }
        public void abrirFormNuevo()
        {
            FormularioNuevoGrupo formulario = new FormularioNuevoGrupo();
            formulario.ShowDialog();
        }

        public void abrirFormCambio()
        {
            FormularioNuevoGrupo formulario = new FormularioNuevoGrupo();
            formulario.TextClaveGrupo.Text = dataAlumnos.CurrentRow.Cells[0].Value.ToString();
            formulario.TextClaveGrupo.Enabled = false;
            formulario.IsActulizar = true;
            formulario.ComboClave.SelectedItem = dataAlumnos.CurrentRow.Cells[1].Value.ToString();
            formulario.ShowDialog();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            procesar(3);
        }
    }
}
