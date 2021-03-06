﻿namespace Consultorio.GUILayer
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoTurnos));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rpvTurnosDiarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(476, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(83, 35);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(192, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(261, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // rpvTurnosDiarios
            // 
            reportDataSource1.Name = "DataSetTodas";
            reportDataSource1.Value = this.consultorioodontologicoTodasBindingSource;
            this.rpvTurnosDiarios.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvTurnosDiarios.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.lstTurnosDiarios.rdlc";
            this.rpvTurnosDiarios.Location = new System.Drawing.Point(0, 0);
            this.rpvTurnosDiarios.Name = "rpvTurnosDiarios";
            this.rpvTurnosDiarios.ServerReport.BearerToken = null;
            this.rpvTurnosDiarios.Size = new System.Drawing.Size(690, 375);
            this.rpvTurnosDiarios.TabIndex = 3;
            this.rpvTurnosDiarios.Load += new System.EventHandler(this.rpvTurnosDiarios_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvTurnosDiarios);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 375);
            this.panel1.TabIndex = 5;
            // 
            // consultorio_odontologicoTodas
            // 
            this.consultorio_odontologicoTodas.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultorioodontologicoTodasBindingSource
            // 
            this.consultorioodontologicoTodasBindingSource.DataSource = this.consultorio_odontologicoTodas;
            this.consultorioodontologicoTodasBindingSource.Position = 0;
            // 
            // frmListadoTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoTurnos";
            this.Text = "Listado de turnos diarios";
            this.Load += new System.EventHandler(this.frmListadoTurnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTurnosDiarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
    }
}