namespace Presentacion
{
    partial class FormularioAsignarMaterias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridMateriasAsignadas = new System.Windows.Forms.DataGridView();
            this.dataGridMaterias = new System.Windows.Forms.DataGridView();
            this.clavegruposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateriasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistagruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdtecpeaDataSet = new Presentacion.bdtecpeaDataSet();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vista_gruposTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.vista_gruposTableAdapter();
            this.TextMatricula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistagruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMateriasAsignadas
            // 
            this.dataGridMateriasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMateriasAsignadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(116)))), ((int)(((byte)(148)))));
            this.dataGridMateriasAsignadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMateriasAsignadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMateriasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMateriasAsignadas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridMateriasAsignadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridMateriasAsignadas.EnableHeadersVisualStyles = false;
            this.dataGridMateriasAsignadas.GridColor = System.Drawing.Color.White;
            this.dataGridMateriasAsignadas.Location = new System.Drawing.Point(0, 0);
            this.dataGridMateriasAsignadas.Name = "dataGridMateriasAsignadas";
            this.dataGridMateriasAsignadas.Size = new System.Drawing.Size(1123, 149);
            this.dataGridMateriasAsignadas.TabIndex = 6;
            // 
            // dataGridMaterias
            // 
            this.dataGridMaterias.AutoGenerateColumns = false;
            this.dataGridMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(116)))), ((int)(((byte)(148)))));
            this.dataGridMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavegruposDataGridViewTextBoxColumn,
            this.idmateriasDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.creditosDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn});
            this.dataGridMaterias.DataSource = this.vistagruposBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMaterias.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridMaterias.EnableHeadersVisualStyles = false;
            this.dataGridMaterias.GridColor = System.Drawing.Color.White;
            this.dataGridMaterias.Location = new System.Drawing.Point(0, 165);
            this.dataGridMaterias.Name = "dataGridMaterias";
            this.dataGridMaterias.Size = new System.Drawing.Size(781, 177);
            this.dataGridMaterias.TabIndex = 7;
            // 
            // clavegruposDataGridViewTextBoxColumn
            // 
            this.clavegruposDataGridViewTextBoxColumn.DataPropertyName = "clave_grupos";
            this.clavegruposDataGridViewTextBoxColumn.HeaderText = "clave_grupos";
            this.clavegruposDataGridViewTextBoxColumn.Name = "clavegruposDataGridViewTextBoxColumn";
            // 
            // idmateriasDataGridViewTextBoxColumn
            // 
            this.idmateriasDataGridViewTextBoxColumn.DataPropertyName = "id_materias";
            this.idmateriasDataGridViewTextBoxColumn.HeaderText = "id_materias";
            this.idmateriasDataGridViewTextBoxColumn.Name = "idmateriasDataGridViewTextBoxColumn";
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            this.creditosDataGridViewTextBoxColumn.DataPropertyName = "creditos";
            this.creditosDataGridViewTextBoxColumn.HeaderText = "creditos";
            this.creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "carrera";
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            this.profesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistagruposBindingSource
            // 
            this.vistagruposBindingSource.DataMember = "vista_grupos";
            this.vistagruposBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // bdtecpeaDataSet
            // 
            this.bdtecpeaDataSet.DataSetName = "bdtecpeaDataSet";
            this.bdtecpeaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(808, 311);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(303, 31);
            this.BtnAceptar.TabIndex = 62;
            this.BtnAceptar.Text = "Listo";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(808, 237);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(303, 31);
            this.BtnAgregar.TabIndex = 64;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(808, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 31);
            this.button1.TabIndex = 65;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // vista_gruposTableAdapter
            // 
            this.vista_gruposTableAdapter.ClearBeforeFill = true;
            // 
            // TextMatricula
            // 
            this.TextMatricula.Enabled = false;
            this.TextMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMatricula.Location = new System.Drawing.Point(808, 187);
            this.TextMatricula.Name = "TextMatricula";
            this.TextMatricula.Size = new System.Drawing.Size(303, 27);
            this.TextMatricula.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(804, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 66;
            this.label9.Text = "Matricula:";
            // 
            // FormularioAsignarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 364);
            this.ControlBox = false;
            this.Controls.Add(this.TextMatricula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.dataGridMaterias);
            this.Controls.Add(this.dataGridMateriasAsignadas);
            this.Name = "FormularioAsignarMaterias";
            this.Text = "FormularioAsignarMaterias";
            this.Load += new System.EventHandler(this.FormularioAsignarMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistagruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMateriasAsignadas;
        private System.Windows.Forms.DataGridView dataGridMaterias;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button1;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource vistagruposBindingSource;
        private bdtecpeaDataSetTableAdapters.vista_gruposTableAdapter vista_gruposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavegruposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox TextMatricula;
        private System.Windows.Forms.Label label9;
    }
}