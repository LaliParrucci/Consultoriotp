namespace Consultorio
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mspInicio = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInicio = new System.Windows.Forms.Label();
            this.gbxTransaccion = new System.Windows.Forms.GroupBox();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.btnTurno = new System.Windows.Forms.Button();
            this.gbxSoporte = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.mspInicio.SuspendLayout();
            this.gbxTransaccion.SuspendLayout();
            this.gbxSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mspInicio
            // 
            this.mspInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem});
            this.mspInicio.Location = new System.Drawing.Point(0, 0);
            this.mspInicio.Name = "mspInicio";
            this.mspInicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mspInicio.Size = new System.Drawing.Size(861, 24);
            this.mspInicio.TabIndex = 0;
            this.mspInicio.Text = "menuStrip1";
            this.mspInicio.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mspInicio_ItemClicked);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(6, 43);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(90, 33);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // gbxTransaccion
            // 
            this.gbxTransaccion.Controls.Add(this.lblConsultas);
            this.gbxTransaccion.Controls.Add(this.btnConsulta);
            this.gbxTransaccion.Controls.Add(this.lblTurnos);
            this.gbxTransaccion.Controls.Add(this.btnTurno);
            this.gbxTransaccion.Location = new System.Drawing.Point(12, 115);
            this.gbxTransaccion.Name = "gbxTransaccion";
            this.gbxTransaccion.Size = new System.Drawing.Size(837, 189);
            this.gbxTransaccion.TabIndex = 2;
            this.gbxTransaccion.TabStop = false;
            this.gbxTransaccion.Text = "Consultas";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Location = new System.Drawing.Point(273, 123);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(89, 20);
            this.lblConsultas.TabIndex = 3;
            this.lblConsultas.Text = "Consultas";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackgroundImage = global::Consultorio.Properties.Resources.comfortable;
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(281, 41);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(70, 70);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Location = new System.Drawing.Point(22, 123);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(157, 20);
            this.lblTurnos.TabIndex = 1;
            this.lblTurnos.Text = "Gestión de Turnos";
            // 
            // btnTurno
            // 
            this.btnTurno.BackgroundImage = global::Consultorio.Properties.Resources.lista_de_verificacion;
            this.btnTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Location = new System.Drawing.Point(67, 41);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(70, 70);
            this.btnTurno.TabIndex = 0;
            this.btnTurno.UseVisualStyleBackColor = true;
            // 
            // gbxSoporte
            // 
            this.gbxSoporte.Controls.Add(this.label3);
            this.gbxSoporte.Controls.Add(this.btnPacientes);
            this.gbxSoporte.Controls.Add(this.label1);
            this.gbxSoporte.Controls.Add(this.btnUsuarios);
            this.gbxSoporte.Location = new System.Drawing.Point(12, 323);
            this.gbxSoporte.Name = "gbxSoporte";
            this.gbxSoporte.Size = new System.Drawing.Size(837, 189);
            this.gbxSoporte.TabIndex = 3;
            this.gbxSoporte.TabStop = false;
            this.gbxSoporte.Text = "Soporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gestión de pacientes";
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackgroundImage = global::Consultorio.Properties.Resources.equipo;
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Location = new System.Drawing.Point(281, 41);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(70, 70);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de usuarios";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::Consultorio.Properties.Resources.people;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(67, 41);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(70, 70);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = global::Consultorio.Properties.Resources.Logo;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(776, 24);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(85, 85);
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(207)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(861, 527);
            this.Controls.Add(this.gbxSoporte);
            this.Controls.Add(this.gbxTransaccion);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.mspInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspInicio;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mspInicio.ResumeLayout(false);
            this.mspInicio.PerformLayout();
            this.gbxTransaccion.ResumeLayout(false);
            this.gbxTransaccion.PerformLayout();
            this.gbxSoporte.ResumeLayout(false);
            this.gbxSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspInicio;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.GroupBox gbxTransaccion;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.GroupBox gbxSoporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPacientes;
    }
}

