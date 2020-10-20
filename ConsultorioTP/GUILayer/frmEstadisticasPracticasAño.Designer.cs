namespace Consultorio.GUILayer
{
    partial class frmEstadisticasPracticasAño
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
            this.rpPracticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.consultorio_odontologicoTodas1 = new Consultorio.GUILayer.consultorio_odontologicoTodas();
            this.consultorioodontologicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpPracticas
            // 
            this.rpPracticas.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esPracticasAño.rdlc";
            this.rpPracticas.Location = new System.Drawing.Point(12, 192);
            this.rpPracticas.Name = "rpPracticas";
            this.rpPracticas.ServerReport.BearerToken = null;
            this.rpPracticas.Size = new System.Drawing.Size(776, 246);
            this.rpPracticas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(316, 61);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 0;
            this.lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(351, 58);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(136, 20);
            this.txtAño.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(677, 134);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // consultorio_odontologicoTodas1
            // 
            this.consultorio_odontologicoTodas1.DataSetName = "consultorio_odontologicoTodas";
            this.consultorio_odontologicoTodas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEstadisticasPracticasAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpPracticas);
            this.Name = "frmEstadisticasPracticasAño";
            this.Text = "Visualizador estadísticas de prácticas";
            this.Load += new System.EventHandler(this.frmEstadisticasPracticasAño_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_odontologicoTodas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioodontologicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPracticas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Button btnGenerar;
        private consultorio_odontologicoTodas consultorio_odontologicoTodas1;
        private System.Windows.Forms.BindingSource consultorioodontologicoBindingSource;
    }
}