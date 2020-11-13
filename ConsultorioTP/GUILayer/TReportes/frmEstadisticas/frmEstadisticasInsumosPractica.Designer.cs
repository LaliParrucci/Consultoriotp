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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblPractica = new System.Windows.Forms.Label();
            this.cboPracticas = new System.Windows.Forms.ComboBox();
            this.rpInsumo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultorio_odontologicoTodas = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.practicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaTableAdapter = new Consultorio.GUILayer.consultorio_odontologicoTodasTableAdapters.practicaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.lblPractica.Location = new System.Drawing.Point(263, 66);
            this.lblPractica.Name = "lblPractica";
            this.lblPractica.Size = new System.Drawing.Size(49, 13);
            this.lblPractica.TabIndex = 1;
            this.lblPractica.Text = "Practica:";
            this.lblPractica.Click += new System.EventHandler(this.lblPractica_Click);
            // 
            // cboPracticas
            // 
            this.cboPracticas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.practicaBindingSource, "nombre", true));
            this.cboPracticas.DataSource = this.practicaBindingSource;
            this.cboPracticas.FormattingEnabled = true;
            this.cboPracticas.Location = new System.Drawing.Point(318, 63);
            this.cboPracticas.Name = "cboPracticas";
            this.cboPracticas.Size = new System.Drawing.Size(143, 21);
            this.cboPracticas.TabIndex = 0;
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
            // consultorio_odontologicoTodas
            // 
            this.consultorio_odontologicoTodas.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicaBindingSource
            // 
            this.practicaBindingSource.DataMember = "practica";
            this.practicaBindingSource.DataSource = this.consultorio_odontologicoTodas;
            // 
            // practicaTableAdapter
            // 
            this.practicaTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblPractica;
        private System.Windows.Forms.ComboBox cboPracticas;
        private Microsoft.Reporting.WinForms.ReportViewer rpInsumo;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas;
        private System.Windows.Forms.BindingSource practicaBindingSource;
        private consultorio_odontologicoTodasTableAdapters.practicaTableAdapter practicaTableAdapter;
    }
}