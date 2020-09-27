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

namespace Consultorio.GUILayer
{
    public partial class frmAbmInsumo : Form
    {
        public frmAbmInsumo()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        bool esNuevo = false;
        Insumo oInsumo = new Insumo();
        InsumoService oInsumoService = new InsumoService();

        private void habilitar(bool x)
        {
            txtNombre.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
            txtId.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtNombre.Text = txtId.Text = txtStock.Text = "";
        }

        private void cargarGrilla(DataGridView grilla, IList<Insumo> lista)
        {
            grilla.Rows.Clear();
            foreach (Insumo p in lista)
            {
                grilla.Rows.Add(p.Id, p.Nombre, p.Stock);
            }
        }


        private void frmAbmInsumo_Load(object sender, EventArgs e)
        {
            cargarGrilla(grdInsumo, oInsumoService.recuperarInsumo());
            habilitar(false);
        }



        private void sentenciaYCarga(Insumo ob, DataGridView grilla, InsumoService obS, bool esAlta)
        {
            obS.altaInsumo(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarInsumo());
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            habilitar(true);
            limpiarCampos();
            this.txtNombre.Focus();
            esNuevo = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            habilitar(false);
            esNuevo = false;
            limpiarCampos();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            this.txtNombre.Focus();

            if (MessageBox.Show("¿Está seguro de eliminar a este Insumo?\n" + txtNombre.Text, "INSUMO ELIMINANDO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limpiarCampos();
                oInsumoService.bajaInsumo(oInsumo.Id);
                cargarGrilla(grdInsumo, oInsumoService.recuperarInsumo());
            }
            else
            {
                MessageBox.Show("No se ha eliminado al Insumo", "Borrado cancelado", MessageBoxButtons.OK);
            }
            habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (oInsumoService.validarInsumo(txtNombre.Text, txtStock.Text))
            {
                oInsumo.Nombre = txtNombre.Text;
                oInsumo.Stock = Convert.ToInt32(txtStock.Text);
                if (this.esNuevo)
                {
                    sentenciaYCarga(oInsumo, grdInsumo, oInsumoService, esNuevo);                    
                }
                else
                {
                    oInsumo.Id = Convert.ToInt32(txtId.Text);
                    sentenciaYCarga(oInsumo, grdInsumo, oInsumoService, esNuevo);
                }
            }
            habilitar(false);
            limpiarCampos();
            esNuevo = false;
        }

        private void actualizarCampos(int id)
        {
            oInsumo = oInsumoService.recuperarInsumoPorId(id);
            txtNombre.Text = oInsumo.Nombre;
            txtId.Text = oInsumo.Id.ToString();
            txtStock.Text = oInsumo.Stock.ToString();
        }

        private void grdInsumo_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdInsumo.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdInsumo.CurrentRow.Cells[0].Value);
            }
            else { MessageBox.Show("No seleccionó ninguna fila!!"); }
        }
    }
}
