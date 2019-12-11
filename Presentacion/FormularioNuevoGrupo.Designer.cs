namespace Presentacion
{
    partial class FormularioNuevoGrupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextClaveGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboClave = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtecpeaDataSet = new Presentacion.bdtecpeaDataSet();
            this.ComboProfesor = new System.Windows.Forms.ComboBox();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.materiasTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.materiasTableAdapter();
            this.profesoresTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.profesoresTableAdapter();
            this.vistaprofesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_profesoresTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.vista_profesoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaprofesoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 88;
            this.label6.Text = "Profesor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Clave Materia:";
            // 
            // TextClaveGrupo
            // 
            this.TextClaveGrupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextClaveGrupo.Location = new System.Drawing.Point(143, 18);
            this.TextClaveGrupo.Margin = new System.Windows.Forms.Padding(5);
            this.TextClaveGrupo.MaxLength = 10;
            this.TextClaveGrupo.Name = "TextClaveGrupo";
            this.TextClaveGrupo.Size = new System.Drawing.Size(196, 27);
            this.TextClaveGrupo.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Clave Grupo:";
            // 
            // ComboClave
            // 
            this.ComboClave.DataSource = this.materiasBindingSource;
            this.ComboClave.DisplayMember = "materia";
            this.ComboClave.FormattingEnabled = true;
            this.ComboClave.Location = new System.Drawing.Point(143, 65);
            this.ComboClave.Name = "ComboClave";
            this.ComboClave.Size = new System.Drawing.Size(196, 29);
            this.ComboClave.TabIndex = 89;
            this.ComboClave.ValueMember = "id_materias";
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // bdtecpeaDataSet
            // 
            this.bdtecpeaDataSet.DataSetName = "bdtecpeaDataSet";
            this.bdtecpeaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboProfesor
            // 
            this.ComboProfesor.DataSource = this.vistaprofesoresBindingSource;
            this.ComboProfesor.DisplayMember = "nombre";
            this.ComboProfesor.FormattingEnabled = true;
            this.ComboProfesor.Location = new System.Drawing.Point(143, 108);
            this.ComboProfesor.Name = "ComboProfesor";
            this.ComboProfesor.Size = new System.Drawing.Size(196, 29);
            this.ComboProfesor.TabIndex = 90;
            this.ComboProfesor.ValueMember = "id_profesor";
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "profesores";
            this.profesoresBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 198);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(327, 31);
            this.BtnCancelar.TabIndex = 92;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(12, 152);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(327, 31);
            this.BtnAceptar.TabIndex = 91;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // vistaprofesoresBindingSource
            // 
            this.vistaprofesoresBindingSource.DataMember = "vista_profesores";
            this.vistaprofesoresBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // vista_profesoresTableAdapter
            // 
            this.vista_profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioNuevoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.ComboProfesor);
            this.Controls.Add(this.ComboClave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextClaveGrupo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioNuevoGrupo";
            this.Text = "FormularioNuevoGrupo";
            this.Load += new System.EventHandler(this.FormularioNuevoGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaprofesoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextClaveGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboProfesor;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private bdtecpeaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private bdtecpeaDataSetTableAdapters.profesoresTableAdapter profesoresTableAdapter;
        public System.Windows.Forms.ComboBox ComboClave;
        private System.Windows.Forms.BindingSource vistaprofesoresBindingSource;
        private bdtecpeaDataSetTableAdapters.vista_profesoresTableAdapter vista_profesoresTableAdapter;
    }
}