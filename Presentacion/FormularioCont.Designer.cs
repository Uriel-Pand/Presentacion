namespace Presentacion
{
    partial class FormularioCont
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
            this.TextMatricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextNInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextNExt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboCalle = new System.Windows.Forms.ComboBox();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtecpeaDataSet = new Presentacion.bdtecpeaDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboColonia = new System.Windows.Forms.ComboBox();
            this.coloniasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.ComboCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.estadosTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.estadosTableAdapter();
            this.ciudadesTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.ciudadesTableAdapter();
            this.coloniasTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.coloniasTableAdapter();
            this.callesTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.callesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextMatricula
            // 
            this.TextMatricula.Enabled = false;
            this.TextMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMatricula.Location = new System.Drawing.Point(16, 33);
            this.TextMatricula.Name = "TextMatricula";
            this.TextMatricula.Size = new System.Drawing.Size(336, 27);
            this.TextMatricula.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 58;
            this.label9.Text = "Matricula:";
            // 
            // TextTelefono
            // 
            this.TextTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTelefono.Location = new System.Drawing.Point(16, 271);
            this.TextTelefono.MaxLength = 10;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(336, 27);
            this.TextTelefono.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Telefono:";
            // 
            // TextNInt
            // 
            this.TextNInt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNInt.Location = new System.Drawing.Point(207, 209);
            this.TextNInt.MaxLength = 4;
            this.TextNInt.Name = "TextNInt";
            this.TextNInt.Size = new System.Drawing.Size(145, 27);
            this.TextNInt.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "N° Int:";
            // 
            // TextNExt
            // 
            this.TextNExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNExt.Location = new System.Drawing.Point(16, 208);
            this.TextNExt.MaxLength = 4;
            this.TextNExt.Name = "TextNExt";
            this.TextNExt.Size = new System.Drawing.Size(145, 27);
            this.TextNExt.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "N° Ext:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 51;
            this.label10.Text = "Calle:";
            // 
            // ComboCalle
            // 
            this.ComboCalle.DataSource = this.callesBindingSource;
            this.ComboCalle.DisplayMember = "calle";
            this.ComboCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCalle.FormattingEnabled = true;
            this.ComboCalle.Location = new System.Drawing.Point(207, 152);
            this.ComboCalle.Name = "ComboCalle";
            this.ComboCalle.Size = new System.Drawing.Size(145, 29);
            this.ComboCalle.TabIndex = 50;
            this.ComboCalle.ValueMember = "id_calles";
            // 
            // callesBindingSource
            // 
            this.callesBindingSource.DataMember = "calles";
            this.callesBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // bdtecpeaDataSet
            // 
            this.bdtecpeaDataSet.DataSetName = "bdtecpeaDataSet";
            this.bdtecpeaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Colonia:";
            // 
            // ComboColonia
            // 
            this.ComboColonia.DataSource = this.coloniasBindingSource;
            this.ComboColonia.DisplayMember = "colonia";
            this.ComboColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboColonia.FormattingEnabled = true;
            this.ComboColonia.Location = new System.Drawing.Point(16, 152);
            this.ComboColonia.Name = "ComboColonia";
            this.ComboColonia.Size = new System.Drawing.Size(145, 29);
            this.ComboColonia.TabIndex = 48;
            this.ComboColonia.ValueMember = "id_colonias";
            // 
            // coloniasBindingSource
            // 
            this.coloniasBindingSource.DataMember = "colonias";
            this.coloniasBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ciudad:";
            // 
            // ComboCiudad
            // 
            this.ComboCiudad.DataSource = this.ciudadesBindingSource;
            this.ComboCiudad.DisplayMember = "ciudada";
            this.ComboCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCiudad.FormattingEnabled = true;
            this.ComboCiudad.Location = new System.Drawing.Point(207, 89);
            this.ComboCiudad.Name = "ComboCiudad";
            this.ComboCiudad.Size = new System.Drawing.Size(145, 29);
            this.ComboCiudad.TabIndex = 46;
            this.ComboCiudad.ValueMember = "id_ciudades";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "ciudades";
            this.ciudadesBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Estado:";
            // 
            // ComboEstado
            // 
            this.ComboEstado.DataSource = this.estadosBindingSource;
            this.ComboEstado.DisplayMember = "estado";
            this.ComboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(16, 89);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(145, 29);
            this.ComboEstado.TabIndex = 44;
            this.ComboEstado.ValueMember = "id_estados";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(27, 355);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(303, 31);
            this.BtnCancelar.TabIndex = 61;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(27, 318);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(303, 31);
            this.BtnAceptar.TabIndex = 60;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // coloniasTableAdapter
            // 
            this.coloniasTableAdapter.ClearBeforeFill = true;
            // 
            // callesTableAdapter
            // 
            this.callesTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 415);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TextMatricula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextNInt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextNExt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComboCalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ComboColonia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ComboCiudad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ComboEstado);
            this.Name = "FormularioCont";
            this.Text = "FormularioCont";
            this.Load += new System.EventHandler(this.FormularioCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextMatricula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextNInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextNExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboColonia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboCiudad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private bdtecpeaDataSetTableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private bdtecpeaDataSetTableAdapters.ciudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource coloniasBindingSource;
        private bdtecpeaDataSetTableAdapters.coloniasTableAdapter coloniasTableAdapter;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private bdtecpeaDataSetTableAdapters.callesTableAdapter callesTableAdapter;
    }
}