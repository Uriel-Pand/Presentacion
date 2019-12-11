namespace Presentacion
{
    partial class FormularioContacto
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCiudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboCalle = new System.Windows.Forms.ComboBox();;
            this.label5 = new System.Windows.Forms.Label();
            this.ComboColonia = new System.Windows.Forms.ComboBox();
            this.TextNExt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextNInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextMatricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TextNombre
            // 
            this.TextNombre.Enabled = false;
            this.TextNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(95, 52);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(387, 27);
            this.TextNombre.TabIndex = 1;
            // 
            // ComboEstado
            // 
            this.ComboEstado.DisplayMember = "estado";
            this.ComboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(95, 91);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(145, 29);
            this.ComboEstado.TabIndex = 2;
            this.ComboEstado.ValueMember = "id_estados";
            this.ComboEstado.SelectedIndexChanged += new System.EventHandler(this.ComboEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad:";
            // 
            // ComboCiudad
            // 
            this.ComboCiudad.DisplayMember = "ciudada";
            this.ComboCiudad.Enabled = false;
            this.ComboCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCiudad.FormattingEnabled = true;
            this.ComboCiudad.Location = new System.Drawing.Point(337, 91);
            this.ComboCiudad.Name = "ComboCiudad";
            this.ComboCiudad.Size = new System.Drawing.Size(145, 29);
            this.ComboCiudad.TabIndex = 4;
            this.ComboCiudad.ValueMember = "id_ciudades";
            this.ComboCiudad.SelectedIndexChanged += new System.EventHandler(this.ComboCiudad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calle:";
            // 
            // ComboCalle
            // 
            this.ComboCalle.DisplayMember = "calle";
            this.ComboCalle.Enabled = false;
            this.ComboCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCalle.FormattingEnabled = true;
            this.ComboCalle.Location = new System.Drawing.Point(337, 144);
            this.ComboCalle.Name = "ComboCalle";
            this.ComboCalle.Size = new System.Drawing.Size(145, 29);
            this.ComboCalle.TabIndex = 8;
            this.ComboCalle.ValueMember = "id_calles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Colonia:";
            // 
            // ComboColonia
            // 
            this.ComboColonia.DisplayMember = "colonia";
            this.ComboColonia.Enabled = false;
            this.ComboColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboColonia.FormattingEnabled = true;
            this.ComboColonia.Location = new System.Drawing.Point(95, 144);
            this.ComboColonia.Name = "ComboColonia";
            this.ComboColonia.Size = new System.Drawing.Size(145, 29);
            this.ComboColonia.TabIndex = 6;
            this.ComboColonia.ValueMember = "id_colonias";
            this.ComboColonia.SelectedIndexChanged += new System.EventHandler(this.ComboColonia_SelectedIndexChanged);
            //
            // TextNExt
            // 
            this.TextNExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNExt.Location = new System.Drawing.Point(95, 198);
            this.TextNExt.MaxLength = 4;
            this.TextNExt.Name = "TextNExt";
            this.TextNExt.Size = new System.Drawing.Size(145, 27);
            this.TextNExt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "N° Ext:";
            // 
            // TextNInt
            // 
            this.TextNInt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNInt.Location = new System.Drawing.Point(337, 198);
            this.TextNInt.MaxLength = 4;
            this.TextNInt.Name = "TextNInt";
            this.TextNInt.Size = new System.Drawing.Size(145, 27);
            this.TextNInt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "N° Int:";
            // 
            // TextTelefono
            // 
            this.TextTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTelefono.Location = new System.Drawing.Point(95, 248);
            this.TextTelefono.MaxLength = 10;
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(387, 27);
            this.TextTelefono.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono:";
            // 
            // TextMatricula
            // 
            this.TextMatricula.Enabled = false;
            this.TextMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMatricula.Location = new System.Drawing.Point(95, 12);
            this.TextMatricula.Name = "TextMatricula";
            this.TextMatricula.Size = new System.Drawing.Size(387, 27);
            this.TextMatricula.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Matricula:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(256, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button1_KeyDown);
            // 
            // FormularioContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 344);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextMatricula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextNInt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextNExt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboColonia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboEstado);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormularioContacto";
            this.Text = "FormularioContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboColonia;
        private System.Windows.Forms.TextBox TextNExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextNInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TextNombre;
        public System.Windows.Forms.TextBox TextMatricula;
    }
}