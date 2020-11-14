namespace Consultorio.GUILayer
{
    partial class frmInformeMontosOOSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeMontosOOSS));
            this.consultorioOdontologicoTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Consultorio_OdontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.dsMontosOOSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvMontos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMontosOOSSBindingSource)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorioOdontologicoTodasBindingSource
            // 
            this.consultorioOdontologicoTodasBindingSource.DataSource = this.Consultorio_OdontologicoTodas;
            this.consultorioOdontologicoTodasBindingSource.Position = 0;
            // 
            // Consultorio_OdontologicoTodas
            // 
            this.Consultorio_OdontologicoTodas.DataSetName = "Consultorio_OdontologicoTodas";
            this.Consultorio_OdontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMontosOOSSBindingSource
            // 
            this.dsMontosOOSSBindingSource.DataSource = this.Consultorio_OdontologicoTodas;
            this.dsMontosOOSSBindingSource.Position = 0;
            // 
            // rpvMontos
            // 
            this.rpvMontos.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Informes.informeMontosOOSS.rdlc";
            this.rpvMontos.Location = new System.Drawing.Point(13, 137);
            this.rpvMontos.Name = "rpvMontos";
            this.rpvMontos.ServerReport.BearerToken = null;
            this.rpvMontos.Size = new System.Drawing.Size(775, 529);
            this.rpvMontos.TabIndex = 0;
            this.rpvMontos.Load += new System.EventHandler(this.rpvMontos_Load);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(680, 53);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(89, 27);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.btnGenerar);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(13, 13);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(775, 118);
            this.grpFiltros.TabIndex = 2;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(111, 77);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(336, 26);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha hasta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha desde: ";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(111, 31);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(336, 26);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            // 
            // frmInformeMontosOOSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 727);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.rpvMontos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformeMontosOOSS";
            this.Text = "Visualizador de Informe";
            this.Load += new System.EventHandler(this.frmInformeMontosOOSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioOdontologicoTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consultorio_OdontologicoTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMontosOOSSBindingSource)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMontos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource dsMontosOOSSBindingSource;
        private consultorio_odontologicoTodas Consultorio_OdontologicoTodas;
        private System.Windows.Forms.BindingSource consultorioOdontologicoTodasBindingSource;
    }
}