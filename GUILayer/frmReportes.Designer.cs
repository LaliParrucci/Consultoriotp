namespace Consultorio.GUILayer
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.pnlTitulo1 = new System.Windows.Forms.Panel();
            this.pnlCuerpoListados = new System.Windows.Forms.Panel();
            this.pnlTitulo2 = new System.Windows.Forms.Panel();
            this.pnlCuerpoEstadisticas = new System.Windows.Forms.Panel();
            this.lblListados = new System.Windows.Forms.Label();
            this.lblEstadis = new System.Windows.Forms.Label();
            this.lblLpXo1 = new System.Windows.Forms.Label();
            this.lblpXo2 = new System.Windows.Forms.Label();
            this.btnPXO = new System.Windows.Forms.Button();
            this.pnlTitulo1.SuspendLayout();
            this.pnlCuerpoListados.SuspendLayout();
            this.pnlTitulo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo1
            // 
            this.pnlTitulo1.Controls.Add(this.lblListados);
            this.pnlTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo1.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo1.Name = "pnlTitulo1";
            this.pnlTitulo1.Size = new System.Drawing.Size(734, 50);
            this.pnlTitulo1.TabIndex = 0;
            // 
            // pnlCuerpoListados
            // 
            this.pnlCuerpoListados.Controls.Add(this.lblLpXo1);
            this.pnlCuerpoListados.Controls.Add(this.btnPXO);
            this.pnlCuerpoListados.Controls.Add(this.lblpXo2);
            this.pnlCuerpoListados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCuerpoListados.Location = new System.Drawing.Point(0, 50);
            this.pnlCuerpoListados.Name = "pnlCuerpoListados";
            this.pnlCuerpoListados.Size = new System.Drawing.Size(734, 236);
            this.pnlCuerpoListados.TabIndex = 1;
            // 
            // pnlTitulo2
            // 
            this.pnlTitulo2.Controls.Add(this.lblEstadis);
            this.pnlTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo2.Location = new System.Drawing.Point(0, 286);
            this.pnlTitulo2.Name = "pnlTitulo2";
            this.pnlTitulo2.Size = new System.Drawing.Size(734, 50);
            this.pnlTitulo2.TabIndex = 2;
            // 
            // pnlCuerpoEstadisticas
            // 
            this.pnlCuerpoEstadisticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCuerpoEstadisticas.Location = new System.Drawing.Point(0, 336);
            this.pnlCuerpoEstadisticas.Name = "pnlCuerpoEstadisticas";
            this.pnlCuerpoEstadisticas.Size = new System.Drawing.Size(734, 236);
            this.pnlCuerpoEstadisticas.TabIndex = 3;
            // 
            // lblListados
            // 
            this.lblListados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListados.AutoSize = true;
            this.lblListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListados.Location = new System.Drawing.Point(12, 9);
            this.lblListados.Name = "lblListados";
            this.lblListados.Size = new System.Drawing.Size(132, 33);
            this.lblListados.TabIndex = 0;
            this.lblListados.Text = "Listados";
            // 
            // lblEstadis
            // 
            this.lblEstadis.AutoSize = true;
            this.lblEstadis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadis.Location = new System.Drawing.Point(12, 10);
            this.lblEstadis.Name = "lblEstadis";
            this.lblEstadis.Size = new System.Drawing.Size(184, 33);
            this.lblEstadis.TabIndex = 0;
            this.lblEstadis.Text = "Estadísticas";
            // 
            // lblLpXo1
            // 
            this.lblLpXo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLpXo1.AutoSize = true;
            this.lblLpXo1.Location = new System.Drawing.Point(403, 68);
            this.lblLpXo1.Name = "lblLpXo1";
            this.lblLpXo1.Size = new System.Drawing.Size(117, 18);
            this.lblLpXo1.TabIndex = 0;
            this.lblLpXo1.Text = "Listado Paciente";
            // 
            // lblpXo2
            // 
            this.lblpXo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpXo2.AutoSize = true;
            this.lblpXo2.Location = new System.Drawing.Point(407, 86);
            this.lblpXo2.Name = "lblpXo2";
            this.lblpXo2.Size = new System.Drawing.Size(113, 18);
            this.lblpXo2.TabIndex = 1;
            this.lblpXo2.Text = "por Odontologo";
            // 
            // btnPXO
            // 
            this.btnPXO.BackgroundImage = global::Consultorio.Properties.Resources.equipo;
            this.btnPXO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPXO.FlatAppearance.BorderSize = 0;
            this.btnPXO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPXO.Location = new System.Drawing.Point(429, 10);
            this.btnPXO.Name = "btnPXO";
            this.btnPXO.Size = new System.Drawing.Size(60, 60);
            this.btnPXO.TabIndex = 2;
            this.btnPXO.UseVisualStyleBackColor = true;
            this.btnPXO.Click += new System.EventHandler(this.btnPXO_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(177)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(734, 572);
            this.Controls.Add(this.pnlCuerpoEstadisticas);
            this.Controls.Add(this.pnlTitulo2);
            this.Controls.Add(this.pnlCuerpoListados);
            this.Controls.Add(this.pnlTitulo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo1.ResumeLayout(false);
            this.pnlTitulo1.PerformLayout();
            this.pnlCuerpoListados.ResumeLayout(false);
            this.pnlCuerpoListados.PerformLayout();
            this.pnlTitulo2.ResumeLayout(false);
            this.pnlTitulo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo1;
        private System.Windows.Forms.Panel pnlCuerpoListados;
        private System.Windows.Forms.Panel pnlTitulo2;
        private System.Windows.Forms.Panel pnlCuerpoEstadisticas;
        private System.Windows.Forms.Label lblListados;
        private System.Windows.Forms.Label lblLpXo1;
        private System.Windows.Forms.Button btnPXO;
        private System.Windows.Forms.Label lblpXo2;
        private System.Windows.Forms.Label lblEstadis;
    }
}