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
            this.gpbInsumos = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gpbInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInsumos
            // 
            this.gpbInsumos.Controls.Add(this.textBox2);
            this.gpbInsumos.Controls.Add(this.textBox1);
            this.gpbInsumos.Controls.Add(this.label2);
            this.gpbInsumos.Controls.Add(this.label1);
            this.gpbInsumos.Controls.Add(this.button1);
            this.gpbInsumos.Location = new System.Drawing.Point(11, 10);
            this.gpbInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInsumos.Name = "gpbInsumos";
            this.gpbInsumos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInsumos.Size = new System.Drawing.Size(889, 130);
            this.gpbInsumos.TabIndex = 0;
            this.gpbInsumos.TabStop = false;
            this.gpbInsumos.Text = "Filtros";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 49);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock desde:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.ReporteListadoInsumos.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(11, 145);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(889, 359);
            this.reportViewer2.TabIndex = 1;
            // 
            // frmReporteListadoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 513);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.gpbInsumos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteListadoInsumos";
            this.Text = "Listado de Insumos por stock";
            this.Load += new System.EventHandler(this.frmReporteListadoInsumos_Load);
            this.gpbInsumos.ResumeLayout(false);
            this.gpbInsumos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInsumos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}