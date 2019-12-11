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
    public partial class FormularioCarrera : Form
    {
        public FormularioCarrera()
        {
            InitializeComponent();
        }

        private void FormularioCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.datos_profesores' Puede moverla o quitarla según sea necesario.
            this.datos_profesoresTableAdapter.Fill(this.bdtecpeaDataSet.datos_profesores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Insertar();
            this.Close();
        }

        public void procesar()
        {
            
        }

        public void Insertar()
        {
            EntidadCarrera carrera = new EntidadCarrera(
                TextCarrera.Text,ComboClave.Text
                );
            EntidadEspecialidad especialidad = new EntidadEspecialidad(
                TextEspecialidad.Text
                );
            Datos.Carrera DatosCarrera = new Datos.Carrera();

            DatosCarrera.InsertCarrera(carrera);

            Datos.Especialidades especialidades = new Especialidades();

            especialidades.InsertCarrera(especialidad);

            EntidadCarreraEspecialidad entidad = new EntidadCarreraEspecialidad(
                especialidad.Especialidad,carrera.Carrera
                );

            Datos.CarreraEspecialidad carrera1 = new CarreraEspecialidad();

            carrera1.InsertCarreraEspecialidad(entidad);

        }

    }
}
