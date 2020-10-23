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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnObrasSociales = new FontAwesome.Sharp.IconButton();
            this.btnInsumos = new FontAwesome.Sharp.IconButton();
            this.btnPractica = new FontAwesome.Sharp.IconButton();
            this.btnProfesionales = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.ibtnSoporte = new FontAwesome.Sharp.IconButton();
            this.btnTurno = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.ibtnTransacciones = new FontAwesome.Sharp.IconButton();
            this.pnlTitulobarra = new System.Windows.Forms.Panel();
            this.btnInicioSesion = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.btnActualFromHijo = new FontAwesome.Sharp.IconPictureBox();
            this.pnlSombra = new System.Windows.Forms.Panel();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlTitulobarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualFromHijo)).BeginInit();
            this.pnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.pnlLogo.Controls.Add(this.BtnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = global::Consultorio.Properties.Resources.Logo_completo;
            this.BtnHome.Location = new System.Drawing.Point(21, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(159, 134);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 4;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnObrasSociales);
            this.pnlMenu.Controls.Add(this.btnInsumos);
            this.pnlMenu.Controls.Add(this.btnPractica);
            this.pnlMenu.Controls.Add(this.btnProfesionales);
            this.pnlMenu.Controls.Add(this.btnPacientes);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.ibtnSoporte);
            this.pnlMenu.Controls.Add(this.btnTurno);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.ibtnTransacciones);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 650);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnReportes.IconSize = 32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 520);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Rotation = 0D;
            this.btnReportes.Size = new System.Drawing.Size(200, 40);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnObrasSociales
            // 
            this.btnObrasSociales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObrasSociales.FlatAppearance.BorderSize = 0;
            this.btnObrasSociales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrasSociales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnObrasSociales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnObrasSociales.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnObrasSociales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnObrasSociales.IconSize = 32;
            this.btnObrasSociales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrasSociales.Location = new System.Drawing.Point(0, 480);
            this.btnObrasSociales.Name = "btnObrasSociales";
            this.btnObrasSociales.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnObrasSociales.Rotation = 0D;
            this.btnObrasSociales.Size = new System.Drawing.Size(200, 40);
            this.btnObrasSociales.TabIndex = 10;
            this.btnObrasSociales.Text = "Obras Sociales";
            this.btnObrasSociales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrasSociales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrasSociales.UseVisualStyleBackColor = true;
            this.btnObrasSociales.Click += new System.EventHandler(this.btnObrasSociales_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnInsumos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnInsumos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnInsumos.IconSize = 32;
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.Location = new System.Drawing.Point(0, 440);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInsumos.Rotation = 0D;
            this.btnInsumos.Size = new System.Drawing.Size(200, 40);
            this.btnInsumos.TabIndex = 9;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnPractica
            // 
            this.btnPractica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPractica.FlatAppearance.BorderSize = 0;
            this.btnPractica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPractica.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPractica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPractica.IconChar = FontAwesome.Sharp.IconChar.Magic;
            this.btnPractica.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPractica.IconSize = 32;
            this.btnPractica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPractica.Location = new System.Drawing.Point(0, 400);
            this.btnPractica.Name = "btnPractica";
            this.btnPractica.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPractica.Rotation = 0D;
            this.btnPractica.Size = new System.Drawing.Size(200, 40);
            this.btnPractica.TabIndex = 8;
            this.btnPractica.Text = "Prácticas";
            this.btnPractica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPractica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPractica.UseVisualStyleBackColor = true;
            this.btnPractica.Click += new System.EventHandler(this.btnPractica_Click);
            // 
            // btnProfesionales
            // 
            this.btnProfesionales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesionales.FlatAppearance.BorderSize = 0;
            this.btnProfesionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProfesionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnProfesionales.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnProfesionales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnProfesionales.IconSize = 32;
            this.btnProfesionales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesionales.Location = new System.Drawing.Point(0, 360);
            this.btnProfesionales.Name = "btnProfesionales";
            this.btnProfesionales.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProfesionales.Rotation = 0D;
            this.btnProfesionales.Size = new System.Drawing.Size(200, 40);
            this.btnProfesionales.TabIndex = 7;
            this.btnProfesionales.Text = "Profesionales";
            this.btnProfesionales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesionales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfesionales.UseVisualStyleBackColor = true;
            this.btnProfesionales.Click += new System.EventHandler(this.btnProfesionales_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPacientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnPacientes.IconSize = 32;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 320);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPacientes.Rotation = 0D;
            this.btnPacientes.Size = new System.Drawing.Size(200, 40);
            this.btnPacientes.TabIndex = 6;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnUsuarios.IconSize = 32;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 280);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // ibtnSoporte
            // 
            this.ibtnSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSoporte.FlatAppearance.BorderSize = 0;
            this.ibtnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSoporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSoporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSoporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ibtnSoporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnSoporte.IconColor = System.Drawing.Color.Black;
            this.ibtnSoporte.IconSize = 16;
            this.ibtnSoporte.Location = new System.Drawing.Point(0, 250);
            this.ibtnSoporte.Name = "ibtnSoporte";
            this.ibtnSoporte.Rotation = 0D;
            this.ibtnSoporte.Size = new System.Drawing.Size(200, 30);
            this.ibtnSoporte.TabIndex = 4;
            this.ibtnSoporte.Text = "Soporte";
            this.ibtnSoporte.UseVisualStyleBackColor = true;
            // 
            // btnTurno
            // 
            this.btnTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnTurno.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnTurno.IconSize = 32;
            this.btnTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.Location = new System.Drawing.Point(0, 210);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTurno.Rotation = 0D;
            this.btnTurno.Size = new System.Drawing.Size(200, 40);
            this.btnTurno.TabIndex = 3;
            this.btnTurno.Text = "Turnos";
            this.btnTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 170);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsulta.Rotation = 0D;
            this.btnConsulta.Size = new System.Drawing.Size(200, 40);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // ibtnTransacciones
            // 
            this.ibtnTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTransacciones.FlatAppearance.BorderSize = 0;
            this.ibtnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTransacciones.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ibtnTransacciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnTransacciones.IconColor = System.Drawing.Color.Black;
            this.ibtnTransacciones.IconSize = 16;
            this.ibtnTransacciones.Location = new System.Drawing.Point(0, 140);
            this.ibtnTransacciones.Name = "ibtnTransacciones";
            this.ibtnTransacciones.Rotation = 0D;
            this.ibtnTransacciones.Size = new System.Drawing.Size(200, 30);
            this.ibtnTransacciones.TabIndex = 0;
            this.ibtnTransacciones.Text = "Consultas";
            this.ibtnTransacciones.UseVisualStyleBackColor = true;
            // 
            // pnlTitulobarra
            // 
            this.pnlTitulobarra.AutoSize = true;
            this.pnlTitulobarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.pnlTitulobarra.Controls.Add(this.btnInicioSesion);
            this.pnlTitulobarra.Controls.Add(this.btnSalir);
            this.pnlTitulobarra.Controls.Add(this.btnMax);
            this.pnlTitulobarra.Controls.Add(this.btnMini);
            this.pnlTitulobarra.Controls.Add(this.lblTituloFormHijo);
            this.pnlTitulobarra.Controls.Add(this.btnActualFromHijo);
            this.pnlTitulobarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulobarra.Location = new System.Drawing.Point(200, 0);
            this.pnlTitulobarra.Name = "pnlTitulobarra";
            this.pnlTitulobarra.Size = new System.Drawing.Size(750, 69);
            this.pnlTitulobarra.TabIndex = 4;
            this.pnlTitulobarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulobarra_MouseDown);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnInicioSesion.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnInicioSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnInicioSesion.IconSize = 32;
            this.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.Location = new System.Drawing.Point(581, 29);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Rotation = 0D;
            this.btnInicioSesion.Size = new System.Drawing.Size(169, 34);
            this.btnInicioSesion.TabIndex = 5;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::Consultorio.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconSize = 16;
            this.btnSalir.Location = new System.Drawing.Point(727, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(23, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::Consultorio.Properties.Resources.maximize_size_option;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMax.IconColor = System.Drawing.Color.Black;
            this.btnMax.IconSize = 16;
            this.btnMax.Location = new System.Drawing.Point(698, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rotation = 0D;
            this.btnMax.Size = new System.Drawing.Size(23, 23);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackgroundImage = global::Consultorio.Properties.Resources.minimize;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMini.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMini.IconColor = System.Drawing.Color.Black;
            this.btnMini.IconSize = 16;
            this.btnMini.Location = new System.Drawing.Point(669, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Rotation = 0D;
            this.btnMini.Size = new System.Drawing.Size(23, 23);
            this.btnMini.TabIndex = 2;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.lblTituloFormHijo.Location = new System.Drawing.Point(72, 15);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(90, 33);
            this.lblTituloFormHijo.TabIndex = 1;
            this.lblTituloFormHijo.Text = "Inicio";
            // 
            // btnActualFromHijo
            // 
            this.btnActualFromHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.btnActualFromHijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnActualFromHijo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnActualFromHijo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.btnActualFromHijo.IconSize = 60;
            this.btnActualFromHijo.Location = new System.Drawing.Point(6, 6);
            this.btnActualFromHijo.Name = "btnActualFromHijo";
            this.btnActualFromHijo.Size = new System.Drawing.Size(60, 60);
            this.btnActualFromHijo.TabIndex = 0;
            this.btnActualFromHijo.TabStop = false;
            // 
            // pnlSombra
            // 
            this.pnlSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.pnlSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSombra.Location = new System.Drawing.Point(200, 69);
            this.pnlSombra.Name = "pnlSombra";
            this.pnlSombra.Size = new System.Drawing.Size(750, 9);
            this.pnlSombra.TabIndex = 5;
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(177)))));
            this.pnlInicio.Controls.Add(this.pbInicio);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.Location = new System.Drawing.Point(200, 78);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(750, 572);
            this.pnlInicio.TabIndex = 6;
            // 
            // pbInicio
            // 
            this.pbInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(177)))));
            this.pbInicio.Image = global::Consultorio.Properties.Resources.Logo_completo;
            this.pbInicio.Location = new System.Drawing.Point(165, 62);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(416, 348);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 5;
            this.pbInicio.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlSombra);
            this.Controls.Add(this.pnlTitulobarra);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitulobarra.ResumeLayout(false);
            this.pnlTitulobarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualFromHijo)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton ibtnTransacciones;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private FontAwesome.Sharp.IconButton btnTurno;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnObrasSociales;
        private FontAwesome.Sharp.IconButton btnInsumos;
        private FontAwesome.Sharp.IconButton btnPractica;
        private FontAwesome.Sharp.IconButton btnProfesionales;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton ibtnSoporte;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel pnlTitulobarra;
        private FontAwesome.Sharp.IconPictureBox btnActualFromHijo;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.Panel pnlSombra;
        private System.Windows.Forms.Panel pnlInicio;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnMax;
        private System.Windows.Forms.PictureBox pbInicio;
        private FontAwesome.Sharp.IconButton btnInicioSesion;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}

