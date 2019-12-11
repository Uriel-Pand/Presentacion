namespace Presentacion
{
    partial class FormularioMaterias
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
            this.TextMateria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextHrsT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextHrsP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextCreditos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboCarrera = new System.Windows.Forms.ComboBox();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtecpeaDataSet = new Presentacion.bdtecpeaDataSet();
            this.carrerasTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.carrerasTableAdapter();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TextMateria
            // 
            this.TextMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMateria.Location = new System.Drawing.Point(16, 94);
            this.TextMateria.Name = "TextMateria";
            this.TextMateria.Size = new System.Drawing.Size(336, 27);
            this.TextMateria.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Materia:";
            // 
            // TextID
            // 
            this.TextID.Enabled = false;
            this.TextID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID.Location = new System.Drawing.Point(16, 40);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(336, 27);
            this.TextID.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID Materia:";
            // 
            // TextHrsT
            // 
            this.TextHrsT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHrsT.Location = new System.Drawing.Point(16, 148);
            this.TextHrsT.Name = "TextHrsT";
            this.TextHrsT.Size = new System.Drawing.Size(336, 27);
            this.TextHrsT.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Horas Tecnicas:";
            // 
            // TextHrsP
            // 
            this.TextHrsP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHrsP.Location = new System.Drawing.Point(16, 202);
            this.TextHrsP.Name = "TextHrsP";
            this.TextHrsP.Size = new System.Drawing.Size(336, 27);
            this.TextHrsP.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Horas Practicas:";
            // 
            // TextCreditos
            // 
            this.TextCreditos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCreditos.Location = new System.Drawing.Point(16, 256);
            this.TextCreditos.Name = "TextCreditos";
            this.TextCreditos.Size = new System.Drawing.Size(336, 27);
            this.TextCreditos.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "Creditos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Carrera:";
            // 
            // ComboCarrera
            // 
            this.ComboCarrera.DataSource = this.carrerasBindingSource;
            this.ComboCarrera.DisplayMember = "carrera";
            this.ComboCarrera.FormattingEnabled = true;
            this.ComboCarrera.Location = new System.Drawing.Point(16, 310);
            this.ComboCarrera.Name = "ComboCarrera";
            this.ComboCarrera.Size = new System.Drawing.Size(336, 29);
            this.ComboCarrera.TabIndex = 71;
            this.ComboCarrera.ValueMember = "id_carreras";
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "carreras";
            this.carrerasBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // bdtecpeaDataSet
            // 
            this.bdtecpeaDataSet.DataSetName = "bdtecpeaDataSet";
            this.bdtecpeaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(28, 397);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(303, 31);
            this.BtnCancelar.TabIndex = 73;
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
            this.BtnAceptar.Location = new System.Drawing.Point(28, 360);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(303, 31);
            this.BtnAceptar.TabIndex = 72;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FormularioMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 440);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.ComboCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextCreditos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextHrsP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextHrsT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextMateria);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormularioMaterias";
            this.Text = "FormularioMaterias";
            this.Load += new System.EventHandler(this.FormularioMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextMateria;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextHrsT;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextHrsP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TextCreditos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private bdtecpeaDataSetTableAdapters.carrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        public System.Windows.Forms.ComboBox ComboCarrera;
    }
}