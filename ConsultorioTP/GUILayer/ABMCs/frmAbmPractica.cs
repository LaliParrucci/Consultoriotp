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
    public partial class frmAbmPractica : Form
    {
        bool esNuevo = false;
        Practica oPractica = new Practica();
        PracticaService oPracticaService = new PracticaService();
        public frmAbmPractica()
        {
            InitializeComponent();
        }

        private void frmAbmPractica_Load(object sender, EventArgs e)
        {
            //LlenarCombo(cboCod, oPracticaService.recuperarPracticas(), "nombre", "id_practica");
            habilitar(false);

            cargarGrilla(grdPractica, oPracticaService.recuperarPracticas());
        }

        private void cargarGrilla(DataGridView grilla, IList<Practica> lista)
        {
            grilla.Rows.Clear();
            foreach (Practica p in lista)
            {
                grilla.Rows.Add(p.Id_practica, p.Nombre, p.Descripcion, p.Importe);
            }
        }

        private void habilitar(bool x)
        {
            txtNombre.Enabled = txtDesc.Enabled = txtImp.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = x;
            btnAlta.Enabled = btnModif.Enabled = btnBaja.Enabled = btnSalir.Enabled = !x;
            txtCodigo.Enabled = false;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = txtDesc.Text = txtImp.Text = txtCodigo.Text = "";
            txtCodigo.Enabled = false;
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            oPractica.Nombre = txtNombre.Text;
            oPractica.Descripcion = txtDesc.Text;
            if (txtImp.Text == "") { oPractica.Importe = 0; }
            else
            {
                try
                {
                    oPractica.Importe = Convert.ToInt32(txtImp.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor válido para el importe de la práctica", "Importe inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (oPracticaService.validarPractica(oPractica))
            {
                sentenciaYCarga(oPractica, grdPractica, oPracticaService, esNuevo);
            }
            habilitar(false);
            esNuevo = false;
        }

        private void sentenciaYCarga(Practica ob, DataGridView grilla, PracticaService obS, bool esAlta)
        {
            obS.altaPractica(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarPracticas());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            esNuevo = false;
            limpiarCampos();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiarCampos();
            this.txtNombre.Focus();
            esNuevo = true;
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtNombre.Focus();

            if (MessageBox.Show("¿Está seguro de eliminar esta práctica?\n" + txtNombre.Text,"Eliminar práctica", 
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)  //si el resultado del dialogo del MB es YES
            {
                limpiarCampos();
                oPracticaService.bajaPractica(oPractica.Id_practica);
                cargarGrilla(grdPractica, oPracticaService.recuperarPracticas());
            }
            else
            {
                MessageBox.Show("No se ha eliminado la práctica","Borrado cancelado",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            habilitar(false);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtCodigo.Enabled = false;
            this.txtNombre.Focus();
            var fila = grdPractica.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdPractica.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna fila!!","Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                habilitar(false);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grdPractica_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdPractica.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdPractica.CurrentRow.Cells[0].Value);
            }
            else { MessageBox.Show( "No seleccionó ninguna fila!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void actualizarCampos(int id)
        {
            oPractica = oPracticaService.recuperarPracticasPorId(id);
            txtDesc.Text = oPractica.Descripcion;
            txtImp.Text = oPractica.Importe.ToString();
            txtNombre.Text = oPractica.Nombre;
            txtCodigo.Text = oPractica.Id_practica.ToString();
        }
    }
}
