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

namespace Presentacion
{
    public partial class FormularioVerGrupos : Form
    {
        Datos.Grupo grupo = new Grupo();

        public FormularioVerGrupos()
        {
            InitializeComponent();
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarDataGrid()
        {
            dataAlumnos.DataSource = grupo.Mostrar(TextClaveGrupo.Text);
        } 

        private void FormularioVerGrupos_Load(object sender, EventArgs e)
        {
            llenarDataGrid();
        }
    }
}
