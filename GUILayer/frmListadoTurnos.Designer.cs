namespace Consultorio.GUILayer
{
    partial class frmListadoTurnos
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rpvTurnosDiarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(218, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // rpvTurnosDiarios
            // 
            this.rpvTurnosDiarios.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.lstTurnosDiarios.rdlc";
            this.rpvTurnosDiarios.Location = new System.Drawing.Point(12, 42);
            this.rpvTurnosDiarios.Name = "rpvTurnosDiarios";
            this.rpvTurnosDiarios.ServerReport.BearerToken = null;
            this.rpvTurnosDiarios.Size = new System.Drawing.Size(776, 339);
            this.rpvTurnosDiarios.TabIndex = 3;
            this.rpvTurnosDiarios.Load += new System.EventHandler(this.rpvTurnosDiarios_Load);
            // 
            // frmListadoTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.rpvTurnosDiarios);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmListadoTurnos";
            this.Text = "frmListadoTurnos";
            this.Load += new System.EventHandler(this.frmListadoTurnos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTurnosDiarios;
    }
}