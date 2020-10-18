namespace Consultorio.GUILayer
{
    partial class frmReportePrXP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Consultorio_OdontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.consultorioOdontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfesional);
            this.groupBox1.Controls.Add(this.cboProfesional);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(842, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(261, 51);
            this.lblProfesional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(87, 18);
            this.lblProfesional.TabIndex = 2;
            this.lblProfesional.Text = "Profesional:";
            // 
            // cboProfesional
            // 
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(356, 48);
            this.cboProfesional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(197, 26);
            this.cboProfesional.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(593, 97);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(97, 30);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "dsPractica";
            reportDataSource1.Value = this.consultorioOdontologicoTodasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.rpPrXP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 176);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 322);
            this.reportViewer1.TabIndex = 1;
            // 
            // Consultorio_OdontologicoTodas
            // 
            this.Consultorio_OdontologicoTodas.DataSetName = "Consultorio_OdontologicoTodas";
            this.Consultorio_OdontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultorioOdontologicoTodasBindingSource
            // 
            this.consultorioOdontologicoTodasBindingSource.DataSource = this.Consultorio_OdontologicoTodas;
            this.consultorioOdontologicoTodasBindingSource.Position = 0;
            // 
            // frmReportePrXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 526);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReportePrXP";
            this.Text = "Listado de Practicas por Profesional";
            this.Load += new System.EventHandler(this.frmReportePrXP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Button btnGenerar;
        private consultorio_odontologicoTodas Consultorio_OdontologicoTodas;
        private System.Windows.Forms.BindingSource consultorioOdontologicoTodasBindingSource;
        //private consultorio_odontologicoDataSet3TableAdapters.profesionalTableAdapter profesionalTableAdapter1;
    }
}