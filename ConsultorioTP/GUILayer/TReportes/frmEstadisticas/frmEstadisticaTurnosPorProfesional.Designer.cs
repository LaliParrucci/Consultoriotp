﻿namespace Consultorio.GUILayer
{
    partial class frmEstadisticaTurnosPorProfesional
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaTurnosPorProfesional));
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.rpEsTrunoPorProfesional = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.dtpDesde1 = new System.Windows.Forms.DateTimePicker();
            this.lblDesde1 = new System.Windows.Forms.Label();
            this.dtpHasta1 = new System.Windows.Forms.DateTimePicker();
            this.lblHasta1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblHasta2 = new System.Windows.Forms.Label();
            this.dtpHasta2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde2 = new System.Windows.Forms.DateTimePicker();
            this.lblDesde2 = new System.Windows.Forms.Label();
            this.dbFiltros = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            this.dbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorioodontologicoTodasBindingSource
            // 
            this.consultorioodontologicoTodasBindingSource.DataSource = this.consultorio_odontologicoTodas;
            this.consultorioodontologicoTodasBindingSource.Position = 0;
            // 
            // consultorio_odontologicoTodas
            // 
            this.consultorio_odontologicoTodas.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpEsTrunoPorProfesional
            // 
            reportDataSource1.Name = "DataSetMes1";
            reportDataSource1.Value = this.consultorioodontologicoTodasBindingSource;
            reportDataSource2.Name = "DataSetMes2";
            reportDataSource2.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpEsTrunoPorProfesional.LocalReport.DataSources.Add(reportDataSource1);
            this.rpEsTrunoPorProfesional.LocalReport.DataSources.Add(reportDataSource2);
            this.rpEsTrunoPorProfesional.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esTrunoPorProfesional.rdlc";
            this.rpEsTrunoPorProfesional.Location = new System.Drawing.Point(13, 234);
            this.rpEsTrunoPorProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.rpEsTrunoPorProfesional.Name = "rpEsTrunoPorProfesional";
            this.rpEsTrunoPorProfesional.ServerReport.BearerToken = null;
            this.rpEsTrunoPorProfesional.Size = new System.Drawing.Size(823, 376);
            this.rpEsTrunoPorProfesional.TabIndex = 0;
            this.rpEsTrunoPorProfesional.Load += new System.EventHandler(this.rpEsTrunoPorProfesional_Load);
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(297, 33);
            this.lblProfesional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(0, 18);
            this.lblProfesional.TabIndex = 1;
            // 
            // dtpDesde1
            // 
            this.dtpDesde1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde1.Location = new System.Drawing.Point(238, 57);
            this.dtpDesde1.Name = "dtpDesde1";
            this.dtpDesde1.Size = new System.Drawing.Size(111, 24);
            this.dtpDesde1.TabIndex = 4;
            this.dtpDesde1.Value = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            // 
            // lblDesde1
            // 
            this.lblDesde1.AutoSize = true;
            this.lblDesde1.Location = new System.Drawing.Point(132, 62);
            this.lblDesde1.Name = "lblDesde1";
            this.lblDesde1.Size = new System.Drawing.Size(100, 18);
            this.lblDesde1.TabIndex = 2;
            this.lblDesde1.Text = "Fecha Desde:";
            // 
            // dtpHasta1
            // 
            this.dtpHasta1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta1.Location = new System.Drawing.Point(506, 58);
            this.dtpHasta1.Name = "dtpHasta1";
            this.dtpHasta1.Size = new System.Drawing.Size(113, 24);
            this.dtpHasta1.TabIndex = 5;
            this.dtpHasta1.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            // 
            // lblHasta1
            // 
            this.lblHasta1.AutoSize = true;
            this.lblHasta1.Location = new System.Drawing.Point(404, 63);
            this.lblHasta1.Name = "lblHasta1";
            this.lblHasta1.Size = new System.Drawing.Size(96, 18);
            this.lblHasta1.TabIndex = 6;
            this.lblHasta1.Text = "Fecha Hasta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(656, 160);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 30);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(53, 33);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(86, 18);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Periódo 1:";
            // 
            // lblHasta2
            // 
            this.lblHasta2.AutoSize = true;
            this.lblHasta2.Location = new System.Drawing.Point(404, 123);
            this.lblHasta2.Name = "lblHasta2";
            this.lblHasta2.Size = new System.Drawing.Size(96, 18);
            this.lblHasta2.TabIndex = 13;
            this.lblHasta2.Text = "Fecha Hasta:";
            // 
            // dtpHasta2
            // 
            this.dtpHasta2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta2.Location = new System.Drawing.Point(506, 117);
            this.dtpHasta2.Name = "dtpHasta2";
            this.dtpHasta2.Size = new System.Drawing.Size(113, 24);
            this.dtpHasta2.TabIndex = 12;
            this.dtpHasta2.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // dtpDesde2
            // 
            this.dtpDesde2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde2.Location = new System.Drawing.Point(238, 117);
            this.dtpDesde2.Name = "dtpDesde2";
            this.dtpDesde2.Size = new System.Drawing.Size(111, 24);
            this.dtpDesde2.TabIndex = 11;
            this.dtpDesde2.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            // 
            // lblDesde2
            // 
            this.lblDesde2.AutoSize = true;
            this.lblDesde2.Location = new System.Drawing.Point(132, 122);
            this.lblDesde2.Name = "lblDesde2";
            this.lblDesde2.Size = new System.Drawing.Size(100, 18);
            this.lblDesde2.TabIndex = 10;
            this.lblDesde2.Text = "Fecha Desde:";
            // 
            // dbFiltros
            // 
            this.dbFiltros.Controls.Add(this.btnConsultar);
            this.dbFiltros.Controls.Add(this.dtpHasta2);
            this.dbFiltros.Controls.Add(this.lblHasta2);
            this.dbFiltros.Controls.Add(this.dtpDesde2);
            this.dbFiltros.Controls.Add(this.lblDesde2);
            this.dbFiltros.Controls.Add(this.label5);
            this.dbFiltros.Controls.Add(this.lblPeriodo);
            this.dbFiltros.Controls.Add(this.lblHasta1);
            this.dbFiltros.Controls.Add(this.dtpHasta1);
            this.dbFiltros.Controls.Add(this.lblDesde1);
            this.dbFiltros.Controls.Add(this.dtpDesde1);
            this.dbFiltros.Location = new System.Drawing.Point(12, 12);
            this.dbFiltros.Name = "dbFiltros";
            this.dbFiltros.Size = new System.Drawing.Size(824, 215);
            this.dbFiltros.TabIndex = 14;
            this.dbFiltros.TabStop = false;
            this.dbFiltros.Text = "Filtros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Periódo 2:";
            // 
            // frmEstadisticaTurnosPorProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 623);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.rpEsTrunoPorProfesional);
            this.Controls.Add(this.dbFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstadisticaTurnosPorProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística Turnos Por Profesional";
            this.Load += new System.EventHandler(this.frmEstadisticaTurnosPorProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            this.dbFiltros.ResumeLayout(false);
            this.dbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpEsTrunoPorProfesional;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.DateTimePicker dtpDesde1;
        private System.Windows.Forms.Label lblDesde1;
        private System.Windows.Forms.DateTimePicker dtpHasta1;
        private System.Windows.Forms.Label lblHasta1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblHasta2;
        private System.Windows.Forms.DateTimePicker dtpHasta2;
        private System.Windows.Forms.DateTimePicker dtpDesde2;
        private System.Windows.Forms.Label lblDesde2;
        private System.Windows.Forms.GroupBox dbFiltros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
    }
}