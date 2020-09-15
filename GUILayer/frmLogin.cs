using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.BusinessLayer;
using Consultorio.Entities;

namespace Consultorio.GUILayer
{
    public partial class frmLogin : Form
    {
        private UsuarioService oUsuarioService;

        private Usuario usr;
        private Form f;


        public frmLogin()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService(); 
        }

        internal Usuario Usr { get => usr; set => usr = value; }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtContraseña.Focus();
                return;
            }
            if (this.txtUsuario.Text == string.Empty && this.txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Usr = oUsuarioService.validarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (Usr != null)
            {
                MessageBox.Show("Bienvenido " + Usr.Nombre_usuario + "!", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(this, new EventArgs());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
