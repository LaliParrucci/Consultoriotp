namespace Consultorio.GUILayer
{
    partial class frmEstadisticasPracticasMes
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
            this.rpPracticasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.desdeDesde = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpPracticasMes
            // 
            this.rpPracticasMes.LocalReport.ReportEmbeddedResource = "Consultorio.GUILayer.Estadisticas.esPracticasMes.rdlc";
            this.rpPracticasMes.Location = new System.Drawing.Point(18, 295);
            this.rpPracticasMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpPracticasMes.Name = "rpPracticasMes";
            this.rpPracticasMes.ServerReport.BearerToken = null;
            this.rpPracticasMes.Size = new System.Drawing.Size(1163, 377);
            this.rpPracticasMes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Controls.Add(this.dptFecha);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.desdeDesde);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1164, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dptFecha
            // 
            this.dptFecha.Location = new System.Drawing.Point(216, 59);
            this.dptFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(298, 26);
            this.dptFecha.TabIndex = 3;
            this.dptFecha.ValueChanged += new System.EventHandler(this.dptFecha_ValueChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(776, 100);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(158, 56);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // desdeDesde
            // 
            this.desdeDesde.AutoSize = true;
            this.desdeDesde.Location = new System.Drawing.Point(43, 64);
            this.desdeDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desdeDesde.Name = "desdeDesde";
            this.desdeDesde.Size = new System.Drawing.Size(106, 20);
            this.desdeDesde.TabIndex = 0;
            this.desdeDesde.Text = "Fecha desde:";
            // 
            // fechaHasta
            // 
            this.fechaHasta.AutoSize = true;
            this.fechaHasta.Location = new System.Drawing.Point(43, 146);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(102, 20);
            this.fechaHasta.TabIndex = 4;
            this.fechaHasta.Text = "Fecha hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 146);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // frmEstadisticasPracticasMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpPracticasMes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstadisticasPracticasMes";
            this.Text = "frmEstadisticasPracticasMes";
            this.Load += new System.EventHandler(this.frmEstadisticasPracticasMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPracticasMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label desdeDesde;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fechaHasta;
    }
}