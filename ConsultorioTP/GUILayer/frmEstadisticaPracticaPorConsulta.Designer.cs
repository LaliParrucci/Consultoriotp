namespace Consultorio.GUILayer
{
    partial class frmEstadisticaPracticaPorConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDsd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHst = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboPractica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpDsd
            // 
            this.dtpDsd.Location = new System.Drawing.Point(238, 140);
            this.dtpDsd.Name = "dtpDsd";
            this.dtpDsd.Size = new System.Drawing.Size(200, 26);
            this.dtpDsd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpHst
            // 
            this.dtpHst.Location = new System.Drawing.Point(609, 134);
            this.dtpHst.Name = "dtpHst";
            this.dtpHst.Size = new System.Drawing.Size(200, 26);
            this.dtpHst.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(836, 198);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(144, 46);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboPractica
            // 
            this.cboPractica.FormattingEnabled = true;
            this.cboPractica.Location = new System.Drawing.Point(419, 48);
            this.cboPractica.Name = "cboPractica";
            this.cboPractica.Size = new System.Drawing.Size(167, 28);
            this.cboPractica.TabIndex = 9;
            this.cboPractica.SelectedIndexChanged += new System.EventHandler(this.cboProfesional_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Practica:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esPracticaPorConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 274);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1011, 452);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmEstadisticaPracticaPorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 737);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPractica);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpHst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDsd);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticaPracticaPorConsulta";
            this.Text = "Visualizacion de estadisticas de practicas por consulta";
            this.Load += new System.EventHandler(this.frmEstadisticaPracticaPorConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDsd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHst;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboPractica;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}