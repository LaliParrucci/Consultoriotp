using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.Entities;
using Consultorio.BussinessLayer;
using Consultorio.BusinessLayer;

namespace Consultorio.GUILayer.Usuario
{
    public partial class frmAbmUsuario : Form
    {
        bool esNuevo = false;
        UsuarioE oUsuario = new UsuarioE();
        UsuarioService oUsuarioService = new UsuarioService();

        public frmAbmUsuario()
        {
            InitializeComponent();
        }

        private void habilitar(bool x)
        {
            txtNombre.Enabled = txtContraseña.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
            txtId.Enabled = false;
        }
        private void limpiarCampos()
        {
            txtId.Text = txtNombre.Text = txtContraseña.Text = "";
        }
        private void cargarGrilla(DataGridView grilla, IList<UsuarioE> lista)
        {
            grilla.Rows.Clear();
            foreach (UsuarioE p in lista)
            {
                grilla.Rows.Add(p.Id_usuario, p.Nombre_usuario, p.Contraseña);
            }
        }

        private void frmAbmUsuarios_Load(object sender, EventArgs e)
        {
            cargarGrilla(grdUsuario, oUsuarioService.recuperarUsuario());
            habilitar(false);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiarCampos();
            this.txtNombre.Focus();
            esNuevo = true;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Focus();

            if (MessageBox.Show("Está seguro que quiere elimminar este Usuario? \n" + txtNombre.Text, "USUARIO ELIMINADO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limpiarCampos();
                oUsuarioService.bajaUsuario(oUsuario.Id_usuario);
                cargarGrilla(grdUsuario, oUsuarioService.recuperarUsuario());
            }
            else
            {
                MessageBox.Show("No se ha eliminado al Usuario", "Borrado cancelado", MessageBoxButtons.OK);
            }
            habilitar(false);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtNombre.Focus();
        }
        private void grdUsuario_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdUsuario.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdUsuario.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("¡No se selecciono ninguna fila!");
            }

        }
        private void actualizarCampos(int id_usuario)
        {
            oUsuario = oUsuarioService.recuperarUsuarioPorId(id_usuario);
            txtId.Text = oUsuario.Id_usuario.ToString();
            txtNombre.Text = oUsuario.Nombre_usuario;
            txtContraseña.Text = oUsuario.Contraseña;
        }

        private void sentenciaYCarga(UsuarioE ob, DataGridView grilla, UsuarioService obS, bool esAlta)
        {
            obS.altaUsuario(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarUsuario());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            oUsuario.Nombre_usuario = txtNombre.Text;
            oUsuario.Contraseña = txtContraseña.Text;

            if (oUsuarioService.validarCampo())
            {
                if (this.esNuevo)
                {
                    sentenciaYCarga(oUsuario, grdUsuario, oUsuarioService, esNuevo);

                }
                else
                {
                    oUsuario.Id_usuario = Convert.ToInt32(grdUsuario.CurrentRow.Cells["id"].Value);
                    sentenciaYCarga(oUsuario, grdUsuario, oUsuarioService, esNuevo);
                }
            }
            habilitar(false);
            esNuevo = false;
            cargarGrilla(grdUsuario, oUsuarioService.recuperarUsuario());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            esNuevo = false;
            limpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
