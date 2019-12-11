namespace Presentacion
{
    partial class ActualizarInformacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.RBtnMujer = new System.Windows.Forms.RadioButton();
            this.RBtnHombre = new System.Windows.Forms.RadioButton();
            this.TimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
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
            this.bdtecpeaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCmabiar = new System.Windows.Forms.Button();
            this.estadosTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.estadosTableAdapter();
            this.ciudadesTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.ciudadesTableAdapter();
            this.coloniasTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.coloniasTableAdapter();
            this.callesTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.callesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sexo";
            // 
            // RBtnMujer
            // 
            this.RBtnMujer.AutoSize = true;
            this.RBtnMujer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnMujer.Location = new System.Drawing.Point(112, 210);
            this.RBtnMujer.Name = "RBtnMujer";
            this.RBtnMujer.Size = new System.Drawing.Size(71, 25);
            this.RBtnMujer.TabIndex = 20;
            this.RBtnMujer.TabStop = true;
            this.RBtnMujer.Text = "Mujer";
            this.RBtnMujer.UseVisualStyleBackColor = true;
            this.RBtnMujer.CheckedChanged += new System.EventHandler(this.RBtnMujer_CheckedChanged);
            // 
            // RBtnHombre
            // 
            this.RBtnHombre.AutoSize = true;
            this.RBtnHombre.Checked = true;
            this.RBtnHombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnHombre.Location = new System.Drawing.Point(16, 210);
            this.RBtnHombre.Name = "RBtnHombre";
            this.RBtnHombre.Size = new System.Drawing.Size(90, 25);
            this.RBtnHombre.TabIndex = 19;
            this.RBtnHombre.TabStop = true;
            this.RBtnHombre.Text = "Hombre";
            this.RBtnHombre.UseVisualStyleBackColor = true;
            this.RBtnHombre.CheckedChanged += new System.EventHandler(this.RBtnHombre_CheckedChanged);
            // 
            // TimeFechaNacimiento
            // 
            this.TimeFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFechaNacimiento.Location = new System.Drawing.Point(16, 154);
            this.TimeFechaNacimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.TimeFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TimeFechaNacimiento.Name = "TimeFechaNacimiento";
            this.TimeFechaNacimiento.Size = new System.Drawing.Size(299, 27);
            this.TimeFechaNacimiento.TabIndex = 18;
            this.TimeFechaNacimiento.ValueChanged += new System.EventHandler(this.TimeFechaNacimiento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha De Nacimiento";
            // 
            // textApellidoM
            // 
            this.textApellidoM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoM.Location = new System.Drawing.Point(175, 89);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(140, 27);
            this.textApellidoM.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellidos";
            // 
            // textApellidoP
            // 
            this.textApellidoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoP.Location = new System.Drawing.Point(12, 91);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(140, 27);
            this.textApellidoP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(16, 35);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(303, 27);
            this.textNombre.TabIndex = 12;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 318);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(303, 31);
            this.BtnCancelar.TabIndex = 25;
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
            this.BtnAceptar.Location = new System.Drawing.Point(12, 267);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(303, 31);
            this.BtnAceptar.TabIndex = 24;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextMatricula
            // 
            this.TextMatricula.Enabled = false;
            this.TextMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMatricula.Location = new System.Drawing.Point(358, 33);
            this.TextMatricula.Name = "TextMatricula";
            this.TextMatricula.Size = new System.Drawing.Size(336, 27);
            this.TextMatricula.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Matricula:";
            // 
            // TextTelefono
            // 
            this.TextTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTelefono.Location = new System.Drawing.Point(358, 271);
            this.TextTelefono.MaxLength = 10;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(336, 27);
            this.TextTelefono.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Telefono:";
            // 
            // TextNInt
            // 
            this.TextNInt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNInt.Location = new System.Drawing.Point(549, 209);
            this.TextNInt.MaxLength = 4;
            this.TextNInt.Name = "TextNInt";
            this.TextNInt.Size = new System.Drawing.Size(145, 27);
            this.TextNInt.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "N° Int:";
            // 
            // TextNExt
            // 
            this.TextNExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNExt.Location = new System.Drawing.Point(358, 208);
            this.TextNExt.MaxLength = 4;
            this.TextNExt.Name = "TextNExt";
            this.TextNExt.Size = new System.Drawing.Size(145, 27);
            this.TextNExt.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "N° Ext:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Calle:";
            // 
            // ComboCalle
            // 
            this.ComboCalle.DataSource = this.callesBindingSource;
            this.ComboCalle.DisplayMember = "calle";
            this.ComboCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCalle.FormattingEnabled = true;
            this.ComboCalle.Location = new System.Drawing.Point(549, 152);
            this.ComboCalle.Name = "ComboCalle";
            this.ComboCalle.Size = new System.Drawing.Size(145, 29);
            this.ComboCalle.TabIndex = 34;
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
            this.label11.Location = new System.Drawing.Point(354, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Colonia:";
            // 
            // ComboColonia
            // 
            this.ComboColonia.DataSource = this.coloniasBindingSource;
            this.ComboColonia.DisplayMember = "colonia";
            this.ComboColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboColonia.FormattingEnabled = true;
            this.ComboColonia.Location = new System.Drawing.Point(358, 152);
            this.ComboColonia.Name = "ComboColonia";
            this.ComboColonia.Size = new System.Drawing.Size(145, 29);
            this.ComboColonia.TabIndex = 32;
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
            this.label12.Location = new System.Drawing.Point(545, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ciudad:";
            // 
            // ComboCiudad
            // 
            this.ComboCiudad.DataSource = this.ciudadesBindingSource;
            this.ComboCiudad.DisplayMember = "ciudada";
            this.ComboCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCiudad.FormattingEnabled = true;
            this.ComboCiudad.Location = new System.Drawing.Point(549, 89);
            this.ComboCiudad.Name = "ComboCiudad";
            this.ComboCiudad.Size = new System.Drawing.Size(145, 29);
            this.ComboCiudad.TabIndex = 30;
            this.ComboCiudad.ValueMember = "id_ciudades";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "ciudades";
            this.ciudadesBindingSource.DataSource = this.bdtecpeaDataSetBindingSource;
            // 
            // bdtecpeaDataSetBindingSource
            // 
            this.bdtecpeaDataSetBindingSource.DataSource = this.bdtecpeaDataSet;
            this.bdtecpeaDataSetBindingSource.Position = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Estado:";
            // 
            // ComboEstado
            // 
            this.ComboEstado.DataSource = this.estadosBindingSource;
            this.ComboEstado.DisplayMember = "estado";
            this.ComboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(358, 89);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(145, 29);
            this.ComboEstado.TabIndex = 28;
            this.ComboEstado.ValueMember = "id_estados";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // BtnCmabiar
            // 
            this.BtnCmabiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCmabiar.FlatAppearance.BorderSize = 0;
            this.BtnCmabiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCmabiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCmabiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCmabiar.ForeColor = System.Drawing.Color.White;
            this.BtnCmabiar.Location = new System.Drawing.Point(358, 318);
            this.BtnCmabiar.Name = "BtnCmabiar";
            this.BtnCmabiar.Size = new System.Drawing.Size(336, 31);
            this.BtnCmabiar.TabIndex = 44;
            this.BtnCmabiar.Text = "Cambiar de";
            this.BtnCmabiar.UseVisualStyleBackColor = false;
            this.BtnCmabiar.Click += new System.EventHandler(this.BtnCmabiar_Click);
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
            // ActualizarInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 362);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCmabiar);
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
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RBtnMujer);
            this.Controls.Add(this.RBtnHombre);
            this.Controls.Add(this.TimeFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellidoM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textApellidoP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Name = "ActualizarInformacion";
            this.Text = "Actualizar Información";
            this.Load += new System.EventHandler(this.ActualizarInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RBtnMujer;
        private System.Windows.Forms.RadioButton RBtnHombre;
        private System.Windows.Forms.DateTimePicker TimeFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
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
        public System.Windows.Forms.Button BtnCmabiar;
        public System.Windows.Forms.TextBox textApellidoM;
        public System.Windows.Forms.TextBox textApellidoP;
        public System.Windows.Forms.TextBox textNombre;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private bdtecpeaDataSetTableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource bdtecpeaDataSetBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private bdtecpeaDataSetTableAdapters.ciudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource coloniasBindingSource;
        private bdtecpeaDataSetTableAdapters.coloniasTableAdapter coloniasTableAdapter;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private bdtecpeaDataSetTableAdapters.callesTableAdapter callesTableAdapter;
    }
}