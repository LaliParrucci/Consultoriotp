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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.consultorio_odontologicoDataSet31 = new Consultorio.consultorio_odontologicoDataSet3();
            this.profesionalBlindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter1 = new Consultorio.consultorio_odontologicoDataSet3TableAdapters.profesionalTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBlindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfesional);
            this.groupBox1.Controls.Add(this.cboProfesional);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.rpPrXP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 160);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(772, 278);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(679, 101);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboProfesional
            // 
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(310, 51);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(201, 21);
            this.cboProfesional.TabIndex = 1;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(242, 54);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(62, 13);
            this.lblProfesional.TabIndex = 2;
            this.lblProfesional.Text = "Profesional:";
            // 
            // consultorio_odontologicoDataSet31
            // 
            this.consultorio_odontologicoDataSet31.DataSetName = "consultorio_odontologicoDataSet3";
            this.consultorio_odontologicoDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionalTableAdapter1
            // 
            this.profesionalTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReportePrXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportePrXP";
            this.Text = "Listado de Practicas por Profesional";
            this.Load += new System.EventHandler(this.frmReportePrXP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBlindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Button btnGenerar;
        private consultorio_odontologicoDataSet3 consultorio_odontologicoDataSet31;
        private System.Windows.Forms.BindingSource profesionalBlindingSource;
        private consultorio_odontologicoDataSet3TableAdapters.profesionalTableAdapter profesionalTableAdapter1;
    }
}