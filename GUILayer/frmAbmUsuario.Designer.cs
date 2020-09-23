namespace Consultorio.GUILayer.Usuario
{
    partial class frmAbmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbmUsuario));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(661, 69);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.txtContraseña);
            this.pnlCuerpo.Controls.Add(this.txtNombre);
            this.pnlCuerpo.Controls.Add(this.txtId);
            this.pnlCuerpo.Controls.Add(this.lblContraseña);
            this.pnlCuerpo.Controls.Add(this.lblNombre);
            this.pnlCuerpo.Controls.Add(this.lblIdUsuario);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 69);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(661, 122);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Location = new System.Drawing.Point(455, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(122, 24);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(148, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(325, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 24);
            this.txtId.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(360, 66);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 18);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Usuario:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(237, 21);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(82, 18);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID Usuario:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnGrabar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 400);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(661, 77);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackgroundImage = global::Consultorio.Properties.Resources.cerrar_sesion;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(597, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 52);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackgroundImage = global::Consultorio.Properties.Resources.cancel__1_;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(345, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 52);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrabar.BackgroundImage = global::Consultorio.Properties.Resources.save;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Location = new System.Drawing.Point(287, 13);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(52, 52);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackgroundImage = global::Consultorio.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(137, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 52);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.BackgroundImage = global::Consultorio.Properties.Resources.cancel;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(79, 13);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(52, 52);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackgroundImage = global::Consultorio.Properties.Resources.anadir;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(12, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(52, 52);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.grdUsuario);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 191);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(661, 209);
            this.pnlGrilla.TabIndex = 3;
            // 
            // grdUsuario
            // 
            this.grdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.contraseña});
            this.grdUsuario.Location = new System.Drawing.Point(23, 26);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.Size = new System.Drawing.Size(602, 150);
            this.grdUsuario.TabIndex = 0;
            this.grdUsuario.SelectionChanged += new System.EventHandler(this.grdUsuario_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // contraseña
            // 
            this.contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            // 
            // frmAbmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(661, 477);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAbmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbmUsuario";
            this.Load += new System.EventHandler(this.frmAbmUsuarios_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
    }
}