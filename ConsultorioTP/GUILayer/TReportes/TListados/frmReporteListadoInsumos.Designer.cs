namespace Consultorio.GUILayer
{
    partial class frmReporteListadoInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteListadoInsumos));
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.gpbInsumos = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rpvReporteInsumos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            this.gpbInsumos.SuspendLayout();
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
            // gpbInsumos
            // 
            this.gpbInsumos.Controls.Add(this.textBox2);
            this.gpbInsumos.Controls.Add(this.textBox1);
            this.gpbInsumos.Controls.Add(this.label2);
            this.gpbInsumos.Controls.Add(this.label1);
            this.gpbInsumos.Controls.Add(this.btnConsultar);
            this.gpbInsumos.Location = new System.Drawing.Point(8, 8);
            this.gpbInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInsumos.Name = "gpbInsumos";
            this.gpbInsumos.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInsumos.Size = new System.Drawing.Size(667, 106);
            this.gpbInsumos.TabIndex = 0;
            this.gpbInsumos.TabStop = false;
            this.gpbInsumos.Text = "Filtros";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 40);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock desde:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(554, 67);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 34);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Generar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rpvReporteInsumos
            // 
            reportDataSource1.Name = "DataInsumos";
            reportDataSource1.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpvReporteInsumos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporteInsumos.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.ReporteListadoInsumos.rdlc";
            this.rpvReporteInsumos.Location = new System.Drawing.Point(8, 118);
            this.rpvReporteInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.rpvReporteInsumos.Name = "rpvReporteInsumos";
            this.rpvReporteInsumos.ServerReport.BearerToken = null;
            this.rpvReporteInsumos.Size = new System.Drawing.Size(667, 292);
            this.rpvReporteInsumos.TabIndex = 1;
            this.rpvReporteInsumos.Load += new System.EventHandler(this.rpvReporteInsumos_Load);
            // 
            // frmReporteListadoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 417);
            this.Controls.Add(this.rpvReporteInsumos);
            this.Controls.Add(this.gpbInsumos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporteListadoInsumos";
            this.Text = "Listado de Insumos por stock";
            this.Load += new System.EventHandler(this.frmReporteListadoInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            this.gpbInsumos.ResumeLayout(false);
            this.gpbInsumos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInsumos;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteInsumos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
    }
}