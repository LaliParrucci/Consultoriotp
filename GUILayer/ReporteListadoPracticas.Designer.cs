namespace Consultorio.GUILayer
{
    partial class listadoPracticas
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
            this.gpxFiltrosPracticas = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.ReporteListadoPracticas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 228);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(982, 395);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gpxFiltrosPracticas
            // 
            this.gpxFiltrosPracticas.Location = new System.Drawing.Point(12, 12);
            this.gpxFiltrosPracticas.Name = "gpxFiltrosPracticas";
            this.gpxFiltrosPracticas.Size = new System.Drawing.Size(970, 201);
            this.gpxFiltrosPracticas.TabIndex = 2;
            this.gpxFiltrosPracticas.TabStop = false;
            this.gpxFiltrosPracticas.Text = "Filtros";
            // 
            // listadoPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 623);
            this.Controls.Add(this.gpxFiltrosPracticas);
            this.Controls.Add(this.reportViewer1);
            this.Name = "listadoPracticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Practicas";
            this.Load += new System.EventHandler(this.listadoPracticas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gpxFiltrosPracticas;
    }
}