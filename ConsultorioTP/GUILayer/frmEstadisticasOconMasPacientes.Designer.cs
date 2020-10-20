namespace Consultorio.GUILayer
{
    partial class frmEstadisticasOconMasPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticasOconMasPacientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.rpOmP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(179, 37);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 24);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(510, 37);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 24);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(687, 80);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 36);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // consultorio_odontologicoTodas
            // 
            this.consultorio_odontologicoTodas.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpOmP
            // 
            reportDataSource1.Name = "DataSetOdont";
            reportDataSource1.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpOmP.LocalReport.DataSources.Add(reportDataSource1);
            this.rpOmP.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esOconMasPaciente.rdlc";
            this.rpOmP.Location = new System.Drawing.Point(12, 142);
            this.rpOmP.Name = "rpOmP";
            this.rpOmP.ServerReport.BearerToken = null;
            this.rpOmP.Size = new System.Drawing.Size(784, 469);
            this.rpOmP.TabIndex = 6;
            // 
            // consultorioodontologicoTodasBindingSource
            // 
            this.consultorioodontologicoTodasBindingSource.DataSource = this.consultorio_odontologicoTodas;
            this.consultorioodontologicoTodasBindingSource.Position = 0;
            // 
            // frmEstadisticasOconMasPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.rpOmP);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstadisticasOconMasPacientes";
            this.Text = "Visualizador estadísticas Odontólogos";
            this.Load += new System.EventHandler(this.frmEstadisticasOconMasPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
        private Microsoft.Reporting.WinForms.ReportViewer rpOmP;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
    }
}