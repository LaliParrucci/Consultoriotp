namespace Consultorio.GUILayer
{
    partial class frmEstadisticasInsumosPractica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblPractica = new System.Windows.Forms.Label();
            this.cboPracticas = new System.Windows.Forms.ComboBox();
            this.rpInsumo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.insumoTableAdapter1 = new Consultorio.GUILayer.consultorio_odontologicoTodasTableAdapters.insumoTableAdapter();
            this.consultorio_odontologicoTodas1 = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.insumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.lblDesde);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Controls.Add(this.fechaDesde);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.lblPractica);
            this.groupBox1.Controls.Add(this.cboPracticas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(410, 51);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(71, 13);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Fecha Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(52, 51);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(74, 13);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Fecha Desde:";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(487, 51);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 4;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(132, 51);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(686, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // lblPractica
            // 
            this.lblPractica.AutoSize = true;
            this.lblPractica.Location = new System.Drawing.Point(283, 120);
            this.lblPractica.Name = "lblPractica";
            this.lblPractica.Size = new System.Drawing.Size(49, 13);
            this.lblPractica.TabIndex = 1;
            this.lblPractica.Text = "Practica:";
            // 
            // cboPracticas
            // 
            this.cboPracticas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.insumoBindingSource, "nombre", true));
            this.cboPracticas.DataSource = this.insumoBindingSource;
            this.cboPracticas.FormattingEnabled = true;
            this.cboPracticas.Location = new System.Drawing.Point(338, 117);
            this.cboPracticas.Name = "cboPracticas";
            this.cboPracticas.Size = new System.Drawing.Size(121, 21);
            this.cboPracticas.TabIndex = 0;
            this.cboPracticas.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // rpInsumo
            // 
            this.rpInsumo.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esInsumoPractica.rdlc";
            this.rpInsumo.Location = new System.Drawing.Point(12, 173);
            this.rpInsumo.Name = "rpInsumo";
            this.rpInsumo.ServerReport.BearerToken = null;
            this.rpInsumo.Size = new System.Drawing.Size(776, 265);
            this.rpInsumo.TabIndex = 1;
            // 
            // insumoTableAdapter1
            // 
            this.insumoTableAdapter1.ClearBeforeFill = true;
            // 
            // consultorio_odontologicoTodas1
            // 
            this.consultorio_odontologicoTodas1.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insumoBindingSource
            // 
            this.insumoBindingSource.DataMember = "insumo";
            this.insumoBindingSource.DataSource = this.consultorio_odontologicoTodas1;
            // 
            // frmEstadisticasInsumosPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpInsumo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstadisticasInsumosPractica";
            this.Text = "frmEstadiscticasInsumosPractica";
            this.Load += new System.EventHandler(this.frmEstadisticasInsumosPractica_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblPractica;
        private System.Windows.Forms.ComboBox cboPracticas;
        private Microsoft.Reporting.WinForms.ReportViewer rpInsumo;
        private consultorio_odontologicoTodasTableAdapters.insumoTableAdapter insumoTableAdapter1;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas1;
        private System.Windows.Forms.BindingSource insumoBindingSource;
    }
}