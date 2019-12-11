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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region Formularios
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.Dock = DockStyle.Fill;

                formulario.BringToFront();             
            }
            else
            {

                formulario.BringToFront();
                formulario = new Forms();
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        #endregion


        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Alumnos>();
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Profesores>();
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Materias>();
        }

        private void BtnGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Grupos>();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Carreras>();
        }
    }
}
