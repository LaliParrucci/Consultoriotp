namespace Consultorio.GUILayer
{
    partial class frmReportePrXOb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePrXOb));
            this.consultorioOdontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Consultorio_OdontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.obrasocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultorioOdontologicoTodasBindingSource
            // 
            this.consultorioOdontologicoTodasBindingSource.DataSource = this.Consultorio_OdontologicoTodas;
            this.consultorioOdontologicoTodasBindingSource.Position = 0;
            // 
            // Consultorio_OdontologicoTodas
            // 
            this.Consultorio_OdontologicoTodas.DataSetName = "Consultorio_OdontologicoTodas";
            this.Consultorio_OdontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsPracticas";
            reportDataSource1.Value = this.consultorioOdontologicoTodasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.rpPrXOb.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 184);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(665, 424);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.lblHasta);
            this.gbxFiltros.Controls.Add(this.lblDesde);
            this.gbxFiltros.Controls.Add(this.fechaHasta);
            this.gbxFiltros.Controls.Add(this.fechaDesde);
            this.gbxFiltros.Controls.Add(this.cboObraSocial);
            this.gbxFiltros.Controls.Add(this.btnGenerar);
            this.gbxFiltros.Controls.Add(this.lblObraSocial);
            this.gbxFiltros.Location = new System.Drawing.Point(13, 13);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(661, 163);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(446, 62);
            this.cboObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(158, 26);
            this.cboObraSocial.TabIndex = 4;
            this.cboObraSocial.SelectedIndexChanged += new System.EventHandler(this.cboObraSocial_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(565, 127);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 28);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(348, 65);
            this.lblObraSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(90, 18);
            this.lblObraSocial.TabIndex = 1;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(110, 35);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 24);
            this.fechaDesde.TabIndex = 5;
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(110, 93);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 24);
            this.fechaHasta.TabIndex = 6;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(7, 35);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(97, 18);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Fecha desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(7, 93);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(97, 18);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Fecha hasta :";
            // 
            // frmReportePrXOb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 623);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportePrXOb";
            this.Text = "Visualizador de practicas";
            this.Load += new System.EventHandler(this.frmReportePrXOb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.BindingSource obrasocialBindingSource;
        private consultorio_odontologicoTodas Consultorio_OdontologicoTodas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.BindingSource consultorioOdontologicoTodasBindingSource;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
    }
}