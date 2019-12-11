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
    public partial class FormularioMaterias : Form
    {

        bool isActualizar = false;
        EntidadMateria materia;
        Datos.Materia datosMaterias = new Datos.Materia();

        public EntidadMateria Materia { get => materia; set => materia = value; }
        public bool IsActualizar { get => isActualizar; set => isActualizar = value; }

        public FormularioMaterias()
        {
            InitializeComponent();
        }

        private void FormularioMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdtecpeaDataSet.carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.bdtecpeaDataSet.carreras);

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
            this.Close();
        }
        public void Procesar()
        {
            if (ValidacionConjunta())
            {
                if (!IsActualizar)
                {
                    InsertarMateria();
                    AbriFormularioMateria();

                }
                else
                {
                    InsertarMateria();
                    AbriFormularioMateria();
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AbriFormularioMateria()
        {
                this.Close();
        }
        public void InsertarMateria()
        {
            Materia = new EntidadMateria(TextID.Text,
                   TextMateria.Text, Convert.ToInt32(TextHrsT.Text),
                   Convert.ToInt32(TextHrsP.Text), Convert.ToInt32(TextCreditos.Text),ComboCarrera.Text
                   );

            datosMaterias.InsertMateria(Materia);
        }


        private bool ValidacionConjunta()
        {
            if (validacionSeparada(TextMateria) &&
                validacionSeparada(TextHrsT) &&
                validacionSeparada(TextHrsP) &&
                validacionSeparada(TextCreditos)
                )
                return true;
            return false;
        }

        private bool validacionSeparada(TextBox text)
        {
            if (text.Text.Equals("")) return false;

            return true;
        }

    }
}
