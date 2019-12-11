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
    public partial class FormularioAsignarMaterias : Form
    {
        GrupoAlumno materia = new GrupoAlumno();
        EntidadGrupoAlumno alumno;
        public FormularioAsignarMaterias()
        {
            InitializeComponent();
        }


        #region procesar


        public void ProcesarAceptar()
        {
            
            this.Close();
        }


        public void ProcesarCancelar()
        {
            this.Close();
        }

        #endregion

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ProcesarAceptar();
        }

        private void FormularioAsignarMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.vista_grupos' Puede moverla o quitarla según sea necesario.
            this.vista_gruposTableAdapter.Fill(this.bdtecpeaDataSet.vista_grupos);
            MostrarmisMaterias();
            llenarObjeto();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMateria();
        }

        public void AgregarMateria()
        {
            llenarObjeto();
            InsertarMateria();
            MostrarmisMaterias();
        }

        public void DeleteMateria()
        {
            alumno.ClaveGrupo = dataGridMateriasAsignadas.CurrentRow.Cells[0].Value.ToString();
            if (EliminarMateria() == 1)
            {
                MostrarmisMaterias();
            }
            else
            {
                MessageBox.Show("Este alumno ya esta siendo evaluado en esta materia", "Aviso");
            }
           
        }

        public void InsertarMateria()
        {
            materia.InsertGrupoAlumno(alumno);
        }

        public int EliminarMateria()
        {
            return materia.DeleteGrupoAlumno(alumno);
        }

        public void MostrarmisMaterias()
        {
            dataGridMateriasAsignadas.DataSource = materia.MostrarMisMaterias(TextMatricula.Text);
        }

        public void llenarObjeto()
        {
            alumno = new EntidadGrupoAlumno(
                matricula: TextMatricula.Text,
                claveGrupo: dataGridMaterias.CurrentRow.Cells[0].Value.ToString()
                );
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DeleteMateria();
        }
    }
}
