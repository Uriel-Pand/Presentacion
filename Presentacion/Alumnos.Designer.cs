namespace Presentacion
{
    partial class Alumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAsignarMaterias = new System.Windows.Forms.Button();
            this.bdtecpeaDataSet = new Presentacion.bdtecpeaDataSet();
            this.bdtecpeaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaalumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_alumnoTableAdapter = new Presentacion.bdtecpeaDataSetTableAdapters.vista_alumnoTableAdapter();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaalumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.AutoGenerateColumns = false;
            this.dataAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(116)))), ((int)(((byte)(148)))));
            this.dataAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopaternoDataGridViewTextBoxColumn,
            this.apellidomaternoDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataAlumnos.DataSource = this.vistaalumnoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataAlumnos.EnableHeadersVisualStyles = false;
            this.dataAlumnos.GridColor = System.Drawing.Color.White;
            this.dataAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.Size = new System.Drawing.Size(869, 370);
            this.dataAlumnos.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(625, 410);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(113, 28);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(744, 410);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(113, 28);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Actulizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Brown;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(12, 376);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(113, 28);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAsignarMaterias
            // 
            this.BtnAsignarMaterias.BackColor = System.Drawing.Color.Crimson;
            this.BtnAsignarMaterias.FlatAppearance.BorderSize = 0;
            this.BtnAsignarMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAsignarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsignarMaterias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignarMaterias.Location = new System.Drawing.Point(625, 376);
            this.BtnAsignarMaterias.Name = "BtnAsignarMaterias";
            this.BtnAsignarMaterias.Size = new System.Drawing.Size(232, 28);
            this.BtnAsignarMaterias.TabIndex = 4;
            this.BtnAsignarMaterias.Text = "Asignar Materias";
            this.BtnAsignarMaterias.UseVisualStyleBackColor = false;
            this.BtnAsignarMaterias.Click += new System.EventHandler(this.BtnAsignarMaterias_Click);
            // 
            // bdtecpeaDataSet
            // 
            this.bdtecpeaDataSet.DataSetName = "bdtecpeaDataSet";
            this.bdtecpeaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdtecpeaDataSetBindingSource
            // 
            this.bdtecpeaDataSetBindingSource.DataSource = this.bdtecpeaDataSet;
            this.bdtecpeaDataSetBindingSource.Position = 0;
            // 
            // vistaalumnoBindingSource
            // 
            this.vistaalumnoBindingSource.DataMember = "vista_alumno";
            this.vistaalumnoBindingSource.DataSource = this.bdtecpeaDataSet;
            // 
            // vista_alumnoTableAdapter
            // 
            this.vista_alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidopaternoDataGridViewTextBoxColumn
            // 
            this.apellidopaternoDataGridViewTextBoxColumn.DataPropertyName = "apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.HeaderText = "apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.Name = "apellidopaternoDataGridViewTextBoxColumn";
            // 
            // apellidomaternoDataGridViewTextBoxColumn
            // 
            this.apellidomaternoDataGridViewTextBoxColumn.DataPropertyName = "apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.HeaderText = "apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.Name = "apellidomaternoDataGridViewTextBoxColumn";
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(869, 479);
            this.Controls.Add(this.BtnAsignarMaterias);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.dataAlumnos);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdtecpeaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaalumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAlumnos;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAsignarMaterias;
        private System.Windows.Forms.BindingSource bdtecpeaDataSetBindingSource;
        private bdtecpeaDataSet bdtecpeaDataSet;
        private System.Windows.Forms.BindingSource vistaalumnoBindingSource;
        private bdtecpeaDataSetTableAdapters.vista_alumnoTableAdapter vista_alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}