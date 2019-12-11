namespace Presentacion
{
    partial class FormularioPersona
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.RBtnHombre = new System.Windows.Forms.RadioButton();
            this.RBtnMujer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCurp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(12, 38);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(303, 27);
            this.textNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // textApellidoP
            // 
            this.textApellidoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoP.Location = new System.Drawing.Point(12, 94);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(140, 27);
            this.textApellidoP.TabIndex = 2;
            // 
            // textApellidoM
            // 
            this.textApellidoM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoM.Location = new System.Drawing.Point(175, 94);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(140, 27);
            this.textApellidoM.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha De Nacimiento";
            // 
            // TimeFechaNacimiento
            // 
            this.TimeFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFechaNacimiento.Location = new System.Drawing.Point(16, 159);
            this.TimeFechaNacimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.TimeFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TimeFechaNacimiento.Name = "TimeFechaNacimiento";
            this.TimeFechaNacimiento.Size = new System.Drawing.Size(299, 27);
            this.TimeFechaNacimiento.TabIndex = 6;
            this.TimeFechaNacimiento.ValueChanged += new System.EventHandler(this.TimeFechaNacimiento_ValueChanged);
            // 
            // RBtnHombre
            // 
            this.RBtnHombre.AutoSize = true;
            this.RBtnHombre.Checked = true;
            this.RBtnHombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnHombre.Location = new System.Drawing.Point(16, 215);
            this.RBtnHombre.Name = "RBtnHombre";
            this.RBtnHombre.Size = new System.Drawing.Size(90, 25);
            this.RBtnHombre.TabIndex = 7;
            this.RBtnHombre.TabStop = true;
            this.RBtnHombre.Text = "Hombre";
            this.RBtnHombre.UseVisualStyleBackColor = true;
            this.RBtnHombre.CheckedChanged += new System.EventHandler(this.RBtnHombre_CheckedChanged);
            // 
            // RBtnMujer
            // 
            this.RBtnMujer.AutoSize = true;
            this.RBtnMujer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnMujer.Location = new System.Drawing.Point(112, 215);
            this.RBtnMujer.Name = "RBtnMujer";
            this.RBtnMujer.Size = new System.Drawing.Size(71, 25);
            this.RBtnMujer.TabIndex = 8;
            this.RBtnMujer.TabStop = true;
            this.RBtnMujer.Text = "Mujer";
            this.RBtnMujer.UseVisualStyleBackColor = true;
            this.RBtnMujer.CheckedChanged += new System.EventHandler(this.RBtnMujer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Curp";
            // 
            // textCurp
            // 
            this.textCurp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurp.Location = new System.Drawing.Point(12, 267);
            this.textCurp.Name = "textCurp";
            this.textCurp.Size = new System.Drawing.Size(303, 27);
            this.textCurp.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Matricula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FormularioPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 451);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCurp);
            this.Controls.Add(this.label5);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimeFechaNacimiento;
        private System.Windows.Forms.RadioButton RBtnHombre;
        private System.Windows.Forms.RadioButton RBtnMujer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCurp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}