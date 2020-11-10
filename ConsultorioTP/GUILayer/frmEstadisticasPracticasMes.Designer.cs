namespace Consultorio.GUILayer
{
    partial class frmEstadisticasPracticasMes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.rpPracticasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaHastaa = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta = new System.Windows.Forms.Label();
            this.fechaDesdee = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.desdeDesde = new System.Windows.Forms.Label();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new Consultorio.GUILayer.consultorio_odontologicoTodasTableAdapters.profesionalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultorioodontologicoTodasBindingSource
            // 
            this.consultorioodontologicoTodasBindingSource.DataSource = this.consultorio_odontologicoTodas;
            this.consultorioodontologicoTodasBindingSource.Position = 0;
            // 
            // consultorio_odontologicoTodas
            // 
            this.consultorio_odontologicoTodas.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpPracticasMes
            // 
            reportDataSource2.Name = "DatosPractica";
            reportDataSource2.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpPracticasMes.LocalReport.DataSources.Add(reportDataSource2);
            this.rpPracticasMes.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esPracticasMes.rdlc";
            this.rpPracticasMes.Location = new System.Drawing.Point(12, 192);
            this.rpPracticasMes.Name = "rpPracticasMes";
            this.rpPracticasMes.ServerReport.BearerToken = null;
            this.rpPracticasMes.Size = new System.Drawing.Size(776, 246);
            this.rpPracticasMes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfesional);
            this.groupBox1.Controls.Add(this.cboProfesional);
            this.groupBox1.Controls.Add(this.fechaHastaa);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Controls.Add(this.fechaDesdee);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.desdeDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // fechaHastaa
            // 
            this.fechaHastaa.Location = new System.Drawing.Point(144, 95);
            this.fechaHastaa.Name = "fechaHastaa";
            this.fechaHastaa.Size = new System.Drawing.Size(200, 20);
            this.fechaHastaa.TabIndex = 5;
            // 
            // fechaHasta
            // 
            this.fechaHasta.AutoSize = true;
            this.fechaHasta.Location = new System.Drawing.Point(29, 95);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(69, 13);
            this.fechaHasta.TabIndex = 4;
            this.fechaHasta.Text = "Fecha hasta:";
            // 
            // fechaDesdee
            // 
            this.fechaDesdee.Location = new System.Drawing.Point(144, 38);
            this.fechaDesdee.Name = "fechaDesdee";
            this.fechaDesdee.Size = new System.Drawing.Size(200, 20);
            this.fechaDesdee.TabIndex = 3;
            this.fechaDesdee.ValueChanged += new System.EventHandler(this.dptFecha_ValueChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(665, 120);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 36);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // desdeDesde
            // 
            this.desdeDesde.AutoSize = true;
            this.desdeDesde.Location = new System.Drawing.Point(29, 42);
            this.desdeDesde.Name = "desdeDesde";
            this.desdeDesde.Size = new System.Drawing.Size(72, 13);
            this.desdeDesde.TabIndex = 0;
            this.desdeDesde.Text = "Fecha desde:";
            // 
            // cboProfesional
            // 
            this.cboProfesional.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.profesionalBindingSource, "nombre", true));
            this.cboProfesional.DataSource = this.profesionalBindingSource;
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(492, 65);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(121, 21);
            this.cboProfesional.TabIndex = 6;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(424, 68);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(62, 13);
            this.lblProfesional.TabIndex = 7;
            this.lblProfesional.Text = "Profesional:";
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "profesional";
            this.profesionalBindingSource.DataSource = this.consultorioodontologicoTodasBindingSource;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstadisticasPracticasMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpPracticasMes);
            this.Name = "frmEstadisticasPracticasMes";
            this.Text = "frmEstadisticasPracticasMes";
            this.Load += new System.EventHandler(this.frmEstadisticasPracticasMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPracticasMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label desdeDesde;
        private System.Windows.Forms.DateTimePicker fechaDesdee;
        private System.Windows.Forms.DateTimePicker fechaHastaa;
        private System.Windows.Forms.Label fechaHasta;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private consultorio_odontologicoTodasTableAdapters.profesionalTableAdapter profesionalTableAdapter;
    }
}