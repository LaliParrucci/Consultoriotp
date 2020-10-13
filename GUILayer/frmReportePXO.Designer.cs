namespace Consultorio.GUILayer
{
    partial class frmReportePXO
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePXO));
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_odontologicoTodas = new Consultorio.consultorio_odontologicoTodas();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.lblOdontologo = new System.Windows.Forms.Label();
            this.rpPXO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            this.gbxFiltros.SuspendLayout();
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
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnConsultar);
            this.gbxFiltros.Controls.Add(this.lblFechaHasta);
            this.gbxFiltros.Controls.Add(this.dtpHasta);
            this.gbxFiltros.Controls.Add(this.dtpDesde);
            this.gbxFiltros.Controls.Add(this.lblPeriodo);
            this.gbxFiltros.Controls.Add(this.lblFechaDesde);
            this.gbxFiltros.Controls.Add(this.cboProfesional);
            this.gbxFiltros.Controls.Add(this.lblOdontologo);
            this.gbxFiltros.Location = new System.Drawing.Point(18, 4);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(645, 151);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(328, 85);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(96, 18);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(430, 80);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(113, 24);
            this.dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(158, 80);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(111, 24);
            this.dtpDesde.TabIndex = 4;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(17, 54);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(67, 18);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periódo";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(52, 85);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(100, 18);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // cboProfesional
            // 
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(125, 18);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(165, 26);
            this.cboProfesional.TabIndex = 1;
            // 
            // lblOdontologo
            // 
            this.lblOdontologo.AutoSize = true;
            this.lblOdontologo.Location = new System.Drawing.Point(27, 21);
            this.lblOdontologo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdontologo.Name = "lblOdontologo";
            this.lblOdontologo.Size = new System.Drawing.Size(91, 18);
            this.lblOdontologo.TabIndex = 0;
            this.lblOdontologo.Text = "Odontologo:";
            // 
            // rpPXO
            // 
            reportDataSource1.Name = "rpPXO";
            reportDataSource1.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpPXO.LocalReport.DataSources.Add(reportDataSource1);
            this.rpPXO.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.rpPXO.rdlc";
            this.rpPXO.Location = new System.Drawing.Point(18, 163);
            this.rpPXO.Margin = new System.Windows.Forms.Padding(4);
            this.rpPXO.Name = "rpPXO";
            this.rpPXO.ServerReport.BearerToken = null;
            this.rpPXO.Size = new System.Drawing.Size(645, 415);
            this.rpPXO.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(542, 114);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Colsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmReportePXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 591);
            this.Controls.Add(this.rpPXO);
            this.Controls.Add(this.gbxFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmReportePXO";
            this.Text = "Visualizador de Listado";
            this.Load += new System.EventHandler(this.frmReportePXO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private Microsoft.Reporting.WinForms.ReportViewer rpPXO;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Label lblOdontologo;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
        private System.Windows.Forms.Button btnConsultar;
    }
}