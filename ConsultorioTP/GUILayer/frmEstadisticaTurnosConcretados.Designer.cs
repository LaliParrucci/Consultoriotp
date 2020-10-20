namespace Consultorio.GUILayer
{
    partial class frmEstadisticaTurnosConcretados
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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.rpvTurnosConcretados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnConsultar);
            this.gbxFiltros.Controls.Add(this.lblFechaHasta);
            this.gbxFiltros.Controls.Add(this.dtpHasta);
            this.gbxFiltros.Controls.Add(this.dtpDesde);
            this.gbxFiltros.Controls.Add(this.lblPeriodo);
            this.gbxFiltros.Controls.Add(this.lblFechaDesde);
            this.gbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxFiltros.Size = new System.Drawing.Size(984, 197);
            this.gbxFiltros.TabIndex = 3;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(786, 134);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(144, 46);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(465, 77);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(153, 29);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(618, 69);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(168, 33);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(224, 69);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(164, 33);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(33, 37);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(106, 29);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Período";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(64, 77);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(163, 29);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // rpvTurnosConcretados
            // 
            this.rpvTurnosConcretados.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.estadisticaTurnosConcretados.rdlc";
            this.rpvTurnosConcretados.Location = new System.Drawing.Point(57, 208);
            this.rpvTurnosConcretados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvTurnosConcretados.Name = "rpvTurnosConcretados";
            this.rpvTurnosConcretados.ServerReport.BearerToken = null;
            this.rpvTurnosConcretados.Size = new System.Drawing.Size(926, 505);
            this.rpvTurnosConcretados.TabIndex = 4;
            this.rpvTurnosConcretados.Load += new System.EventHandler(this.rpvTurnosConcretados_Load);
            // 
            // frmEstadisticaTurnosConcretados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 749);
            this.Controls.Add(this.rpvTurnosConcretados);
            this.Controls.Add(this.gbxFiltros);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstadisticaTurnosConcretados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador estadística de turnos concretados";
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTurnosConcretados;
    }
}