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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePXO));
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(786, 123);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 328);
            this.reportViewer1.TabIndex = 1;
            // 
            // frmReportePXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbxFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReportePXO";
            this.Text = "Visualizador de Listado";
            this.Load += new System.EventHandler(this.frmReportePXO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}