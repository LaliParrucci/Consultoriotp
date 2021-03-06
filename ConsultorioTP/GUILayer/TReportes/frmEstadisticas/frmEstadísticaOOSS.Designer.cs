﻿namespace Consultorio.GUILayer
{
    partial class frmEstadísticaOOSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadísticaOOSS));
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.rpvEstadisticaOOSS = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.gbxFiltros.Location = new System.Drawing.Point(1, 0);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(634, 128);
            this.gbxFiltros.TabIndex = 2;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(529, 98);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(82, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(310, 50);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(96, 18);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(412, 45);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(113, 24);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(149, 45);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(111, 24);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.Value = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(22, 24);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(67, 18);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Período";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(43, 50);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(100, 18);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // rpvEstadisticaOOSS
            // 
            this.rpvEstadisticaOOSS.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.estadisticaOOSSMasUsadas.rdlc";
            this.rpvEstadisticaOOSS.Location = new System.Drawing.Point(1, 135);
            this.rpvEstadisticaOOSS.Name = "rpvEstadisticaOOSS";
            this.rpvEstadisticaOOSS.ServerReport.BearerToken = null;
            this.rpvEstadisticaOOSS.Size = new System.Drawing.Size(634, 318);
            this.rpvEstadisticaOOSS.TabIndex = 3;
            this.rpvEstadisticaOOSS.Load += new System.EventHandler(this.rpvEstadisticaOOSS_Load);
            // 
            // frmEstadísticaOOSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 453);
            this.Controls.Add(this.rpvEstadisticaOOSS);
            this.Controls.Add(this.gbxFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadísticaOOSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizador estadística de Obras Sociales más utilizadas";
            this.Load += new System.EventHandler(this.frmEstadísticaOOSS_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEstadisticaOOSS;
        private System.Windows.Forms.Button btnConsultar;
    }
}