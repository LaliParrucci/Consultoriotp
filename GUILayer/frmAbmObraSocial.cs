using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.BussinessLayer;
using Consultorio.Entities;

namespace Consultorio.GUILayer
{
    public partial class frmAbmObraSocial : Form
    {
        bool esNuevo = false;
        ObraSocial oObraSocial = new ObraSocial();
        ObraSocialService oObraSocialService = new ObraSocialService();
        public frmAbmObraSocial()
        {
            InitializeComponent();
        }
        private void habilitar(bool x)
        {
            txtNombre.Enabled = txtCodigo.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = txtCodigo.Text = "";
        }
        private void cargarGrilla(DataGridView grilla, IList<ObraSocial> lista)
        {
            grilla.Rows.Clear();
            foreach (ObraSocial p in lista)
            {
                grilla.Rows.Add(p.Codigo, p.Nombre);
            }
        }
        private void frmAbmObraSocial_Load(object sender, EventArgs e)
        {
            cargarGrilla(grdObraSocial, oObraSocialService.recuperarObraSocial()); //asi lo llamo al metodo
            habilitar(false);
        }
        private void grdObraSocial_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdObraSocial.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdObraSocial.CurrentRow.Cells[0].Value);
            }
        }
        private void actualizarCampos(int codigo)
        {
            oObraSocial = oObraSocialService.recuperarObraSocialPorCodigo(codigo);
            txtCodigo.Text = oObraSocial.Codigo.ToString();
            txtNombre.Text = oObraSocial.Nombre;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiarCampos();
            this.txtCodigo.Focus();
            esNuevo = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Focus();

            if (MessageBox.Show("¿Está seguro de eliminar a esta Obra Social?\n" + txtNombre.Text, "ELIMINADA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limpiarCampos();
                oObraSocialService.bajaObraSocial(oObraSocial.Codigo);
                cargarGrilla(grdObraSocial, oObraSocialService.recuperarObraSocial());
            }
            else
            {
                MessageBox.Show("No se ha eliminado la obra social", "Borrado cancelado", MessageBoxButtons.OK);
            }
            habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            oObraSocial.Codigo = Convert.ToInt32(txtCodigo.Text);
            oObraSocial.Nombre = txtNombre.Text;

            //;
            if (oObraSocialService.validarObraSocial())
            {
                if (this.esNuevo)
                {
                    if (!oObraSocialService.existeObraSocial(oObraSocial.Codigo))
                    {
                        sentenciaYCarga(oObraSocial, grdObraSocial, oObraSocialService, esNuevo);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Ya existe la obra social! No puede cargarla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sentenciaYCarga(oObraSocial, grdObraSocial, oObraSocialService, esNuevo);
                }
            }
            habilitar(false);
            esNuevo = false;
        }
        private void sentenciaYCarga(ObraSocial ob, DataGridView grilla, ObraSocialService obS, bool esAlta)
        {
            obS.altaObraSocial(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarObraSocial());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            esNuevo = false;
            limpiarCampos();
        }
    }
}
