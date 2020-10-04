namespace Consultorio.GUILayer
{
    partial class frmRegistrarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTurno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.chDisponibles = new System.Windows.Forms.CheckBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoProfesional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFechas = new System.Windows.Forms.Panel();
            this.grdTurnosDisp = new System.Windows.Forms.DataGridView();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlTitulo.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnosDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obra Social:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Turno";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(750, 50);
            this.pnlTitulo.TabIndex = 2;
            // 
            // chDisponibles
            // 
            this.chDisponibles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chDisponibles.AutoSize = true;
            this.chDisponibles.Location = new System.Drawing.Point(237, 23);
            this.chDisponibles.Name = "chDisponibles";
            this.chDisponibles.Size = new System.Drawing.Size(104, 22);
            this.chDisponibles.TabIndex = 0;
            this.chDisponibles.Text = "Disponibles";
            this.chDisponibles.UseVisualStyleBackColor = true;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.txtFecha);
            this.pnlCuerpo.Controls.Add(this.label9);
            this.pnlCuerpo.Controls.Add(this.groupBox2);
            this.pnlCuerpo.Controls.Add(this.cboObraSocial);
            this.pnlCuerpo.Controls.Add(this.label1);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 50);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(750, 105);
            this.pnlCuerpo.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFecha.Location = new System.Drawing.Point(448, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(225, 24);
            this.txtFecha.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtNombreProfesional);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtApellidoProfesional);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Profesional";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreProfesional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreProfesional.Location = new System.Drawing.Point(93, 27);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(175, 24);
            this.txtNombreProfesional.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // txtApellidoProfesional
            // 
            this.txtApellidoProfesional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtApellidoProfesional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApellidoProfesional.Location = new System.Drawing.Point(93, 57);
            this.txtApellidoProfesional.Name = "txtApellidoProfesional";
            this.txtApellidoProfesional.Size = new System.Drawing.Size(175, 24);
            this.txtApellidoProfesional.TabIndex = 1;
            this.txtApellidoProfesional.Click += new System.EventHandler(this.txtApellidoProfesional_Click);
            this.txtApellidoProfesional.Enter += new System.EventHandler(this.txtApellidoProfesional_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido:";
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(448, 28);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(225, 26);
            this.cboObraSocial.TabIndex = 0;
            // 
            // calendario
            // 
            this.calendario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendario.Location = new System.Drawing.Point(18, 23);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 1;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(323, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(142, 86);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(521, 45);
            this.txtObservaciones.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Location = new System.Drawing.Point(169, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 26);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Turno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(360, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 53);
            this.panel2.TabIndex = 5;
            // 
            // pnlFechas
            // 
            this.pnlFechas.Controls.Add(this.grdTurnosDisp);
            this.pnlFechas.Controls.Add(this.calendario);
            this.pnlFechas.Controls.Add(this.chDisponibles);
            this.pnlFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFechas.Location = new System.Drawing.Point(0, 155);
            this.pnlFechas.Name = "pnlFechas";
            this.pnlFechas.Size = new System.Drawing.Size(750, 211);
            this.pnlFechas.TabIndex = 14;
            // 
            // grdTurnosDisp
            // 
            this.grdTurnosDisp.AllowUserToAddRows = false;
            this.grdTurnosDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdTurnosDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTurnosDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lunes,
            this.Hora,
            this.Paciente,
            this.disponibilidad});
            this.grdTurnosDisp.Location = new System.Drawing.Point(237, 51);
            this.grdTurnosDisp.Name = "grdTurnosDisp";
            this.grdTurnosDisp.Size = new System.Drawing.Size(495, 134);
            this.grdTurnosDisp.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(142, 26);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(175, 24);
            this.txtDni.TabIndex = 17;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(142, 56);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(175, 24);
            this.txtPaciente.TabIndex = 18;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Fecha";
            this.Lunes.Name = "Lunes";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            // 
            // disponibilidad
            // 
            this.disponibilidad.HeaderText = "Disponible";
            this.disponibilidad.Name = "disponibilidad";
            this.disponibilidad.Width = 120;
            // 
            // frmRegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(750, 572);
            this.Controls.Add(this.pnlFechas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarTurno";
            this.Load += new System.EventHandler(this.frmRegistrarTurno_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlFechas.ResumeLayout(false);
            this.pnlFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnosDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.CheckBox chDisponibles;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApellidoProfesional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlFechas;
        private System.Windows.Forms.DataGridView grdTurnosDisp;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disponibilidad;
    }
}