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
    public partial class frmAbmProfesional : Form
    {
        bool esNuevo = false;
        ProfesionalE oProfesional = new ProfesionalE();
        ProfesionalService oProfesionalService = new ProfesionalService();

        public frmAbmProfesional()
        {
            InitializeComponent();
        }
        private void habilitar(bool x)
        {
            txtNombre.Enabled = txtApellido.Enabled = txtDomicilio.Enabled = btnGrabar.Enabled = txtEspecialidad.Enabled = btnCancelar.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
            txtMatricula.Enabled = false;
        }
        private void limpiarCampos()
        {
            txtMatricula.Text = txtNombre.Text = txtApellido.Text = txtDomicilio.Text = txtEspecialidad.Text = "";
        }
        private void cargarGrilla(DataGridView grilla, IList<ProfesionalE> lista)
        {
            grilla.Rows.Clear();
            foreach (ProfesionalE p in lista)
            {
                grilla.Rows.Add(p.Matricula, p.Nombre, p.Apellido, p.Especialidad, p.Domicilio);
            }
        }

        private void frmAbmProfesional_Load(object sender, EventArgs e)
        {
            cargarGrilla(grdProfesional, oProfesionalService.recuperarProfesional());
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

            if (MessageBox.Show("Está seguro que quiere elimminar este profesional? \n" + txtNombre.Text, "Eliminar profesional",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                limpiarCampos();
                oProfesionalService.bajaProfesional(oProfesional.Matricula);
                cargarGrilla(grdProfesional, oProfesionalService.recuperarProfesional());
            }
            else
            {
                MessageBox.Show("No se ha eliminado al profesional", "Borrado cancelado", MessageBoxButtons.OK);
            }
            habilitar(false);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            this.txtNombre.Focus();
            var fila = grdProfesional.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdProfesional.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna fila!","Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                habilitar(false);
            }
        }
        private void grdProfesional_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdProfesional.CurrentRow.Cells[0].Value;
            if(fila != null)
            {
                actualizarCampos((int)grdProfesional.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show( "No seleccionó ninguna fila!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                habilitar(false);
            }

        }
        private void actualizarCampos(int matricula)
        {
            oProfesional = oProfesionalService.recuperarProfesionalPorMatricula(matricula);
            txtMatricula.Text = oProfesional.Matricula.ToString();
            txtNombre.Text = oProfesional.Nombre;
            txtApellido.Text = oProfesional.Apellido;
            txtEspecialidad.Text = oProfesional.Especialidad;
            txtDomicilio.Text = oProfesional.Domicilio;
        }

        private void sentenciaYCarga(ProfesionalE ob, DataGridView grilla, ProfesionalService obS, bool esAlta)
        {
            obS.altaProfesional(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarProfesional());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            oProfesional.Nombre = txtNombre.Text;
            oProfesional.Apellido = txtApellido.Text;
            oProfesional.Especialidad = txtEspecialidad.Text;
            oProfesional.Domicilio = txtDomicilio.Text;

            if (oProfesionalService.validarProfesional(oProfesional.Nombre, oProfesional.Apellido))
            {
                if (this.esNuevo)
                {                     
                    sentenciaYCarga(oProfesional, grdProfesional, oProfesionalService, esNuevo);
                    
                }
                else
                {
                    oProfesional.Matricula = Convert.ToInt32(grdProfesional.CurrentRow.Cells["matricula"].Value);
                    sentenciaYCarga(oProfesional, grdProfesional, oProfesionalService, esNuevo);
                }
            }
            habilitar(false);
            esNuevo = false;
            cargarGrilla(grdProfesional, oProfesionalService.recuperarProfesional());
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
