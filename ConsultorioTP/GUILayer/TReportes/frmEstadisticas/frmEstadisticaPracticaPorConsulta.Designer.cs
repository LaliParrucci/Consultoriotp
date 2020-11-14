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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaPracticaPorConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDsd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHst = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboPractica = new System.Windows.Forms.ComboBox();
            this.practicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioodontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.practicaTableAdapter = new Consultorio.GUILayer.consultorio_odontologicoTodasTableAdapters.practicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpDsd
            // 
            this.dtpDsd.Location = new System.Drawing.Point(159, 91);
            this.dtpDsd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDsd.Name = "dtpDsd";
            this.dtpDsd.Size = new System.Drawing.Size(135, 20);
            this.dtpDsd.TabIndex = 4;
            this.dtpDsd.ValueChanged += new System.EventHandler(this.dtpDsd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpHst
            // 
            this.dtpHst.Location = new System.Drawing.Point(406, 87);
            this.dtpHst.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHst.Name = "dtpHst";
            this.dtpHst.Size = new System.Drawing.Size(135, 20);
            this.dtpHst.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(557, 129);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 30);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboPractica
            // 
            this.cboPractica.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.practicaBindingSource, "nombre", true));
            this.cboPractica.DataSource = this.practicaBindingSource;
            this.cboPractica.FormattingEnabled = true;
            this.cboPractica.Location = new System.Drawing.Point(279, 31);
            this.cboPractica.Margin = new System.Windows.Forms.Padding(2);
            this.cboPractica.Name = "cboPractica";
            this.cboPractica.Size = new System.Drawing.Size(113, 21);
            this.cboPractica.TabIndex = 9;
            this.cboPractica.SelectedIndexChanged += new System.EventHandler(this.cboProfesional_SelectedIndexChanged);
            // 
            // practicaBindingSource
            // 
            this.practicaBindingSource.DataMember = "practica";
            this.practicaBindingSource.DataSource = this.consultorioodontologicoTodasBindingSource;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Práctica:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esPracticaPorConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 174);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(666, 293);
            this.reportViewer1.TabIndex = 11;
            // 
            // practicaTableAdapter
            // 
            this.practicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstadisticaPracticaPorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 479);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPractica);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpHst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDsd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEstadisticaPracticaPorConsulta";
            this.Text = "Visualización de estadísticas de prácticas por consulta";
            this.Load += new System.EventHandler(this.frmEstadisticaPracticaPorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
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
        private System.Windows.Forms.BindingSource consultorioodontologicoTodasBindingSource;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
        private System.Windows.Forms.BindingSource practicaBindingSource;
        private consultorio_odontologicoTodasTableAdapters.practicaTableAdapter practicaTableAdapter;
    }
}