﻿using System;
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
            txtNombre.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = txtPorcentaje.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
            txtCodigo.Enabled = false;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = txtCodigo.Text = txtPorcentaje.Text = "";
        }
        private void cargarGrilla(DataGridView grilla, IList<ObraSocial> lista)
        {
            grilla.Rows.Clear();
            foreach (ObraSocial p in lista)
            {
                grilla.Rows.Add(p.Codigo, p.Nombre,p.Porcentaje);
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
            else { MessageBox.Show("No seleccionó ninguna fila!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        private void actualizarCampos(int codigo)
        {
            oObraSocial = oObraSocialService.recuperarObraSocialPorCodigo(codigo);
            txtCodigo.Text = oObraSocial.Codigo.ToString();
            txtNombre.Text = oObraSocial.Nombre;
            txtPorcentaje.Text = oObraSocial.Porcentaje.ToString();

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

            if (MessageBox.Show("¿Está seguro de eliminar esta Obra Social?\n" + txtNombre.Text,"Eliminar obra social", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limpiarCampos();
                oObraSocialService.bajaObraSocial(oObraSocial.Codigo);
                cargarGrilla(grdObraSocial, oObraSocialService.recuperarObraSocial());
            }
            else
            {
                MessageBox.Show("No se ha eliminado la obra social", "Borrado cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtNombre.Focus();
            var fila = grdObraSocial.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdObraSocial.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show( "No seleccionó ninguna fila!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                habilitar(false);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (oObraSocialService.validarObraSocial(txtNombre.Text, txtPorcentaje.Text))
            {
                oObraSocial.Nombre = txtNombre.Text;
                oObraSocial.Porcentaje = Convert.ToSingle(txtPorcentaje.Text);
                if (this.esNuevo)
                {
                    sentenciaYCarga(oObraSocial, grdObraSocial, oObraSocialService, esNuevo);
                }
                else
                {
                    oObraSocial.Codigo = Convert.ToInt32(txtCodigo.Text);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
