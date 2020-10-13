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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.rpPrXOb.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 307);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cboObraSocial);
            this.gbxFiltros.Controls.Add(this.lblObraSocial);
            this.gbxFiltros.Location = new System.Drawing.Point(9, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(779, 118);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(254, 42);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(65, 13);
            this.lblObraSocial.TabIndex = 1;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(325, 39);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(188, 21);
            this.cboObraSocial.TabIndex = 2;
            // 
            // frmReportePrXOb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportePrXOb";
            this.Text = "Visualizador de practicas";
            this.Load += new System.EventHandler(this.frmReportePrXOb_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cboObraSocial;
    }
}