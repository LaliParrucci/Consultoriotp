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
    public partial class frmAbmPaciente : Form
    {
        bool esNuevo = false;
        Paciente oPaciente = new Paciente();
        PacienteService oPacienteService = new PacienteService();
        public frmAbmPaciente()
        {
            InitializeComponent();
        }
        private void habilitar(bool x)
        {
            txtNombre.Enabled = txtApellido.Enabled = txtTelefono.Enabled = txtDomicilio.Enabled = txtEmail.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = txtDNI.Enabled = x;
            btnNuevo.Enabled = btnEditar.Enabled = btnBorrar.Enabled = btnSalir.Enabled = !x;
        }

        private void limpiarCampos()
        {
            txtNombre.Text = txtApellido.Text = txtTelefono.Text = txtDNI.Text = txtDomicilio.Text = txtEmail.Text = "";
        }

        private void cargarGrilla(DataGridView grilla, IList<Paciente> lista)
        {
            grilla.Rows.Clear();
            foreach (Paciente p in lista)
            {
                grilla.Rows.Add(p.Dni, p.Nombre, p.Apellido, p.Telefono, p.Domicilio, p.Email);
            }
        }

        private void frmAbmPaciente_Load(object sender, EventArgs e)
        {
            cargarGrilla(grdPaciente, oPacienteService.recuperarPaciente()); //asi lo llamo al metodo
            habilitar(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiarCampos();
            this.txtDNI.Focus();
            esNuevo = true;
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Focus();

            if (MessageBox.Show("¿Está seguro de eliminar a este Paciente?\n" + txtNombre.Text, "PACIENTE ELIMINANDO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes) //si el resultado del dialogo del MB es YES
            {
                limpiarCampos();
                oPacienteService.bajaPaciente(oPaciente.Dni);
                cargarGrilla(grdPaciente, oPacienteService.recuperarPaciente());
            }
            else
            {
                MessageBox.Show("No se ha eliminado al paciente", "Borrado cancelado", MessageBoxButtons.OK);
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

        private void grdPaciente_SelectionChanged(object sender, EventArgs e)
        {
            var fila = grdPaciente.CurrentRow.Cells[0].Value;
            if (fila != null)
            {
                actualizarCampos((int)grdPaciente.CurrentRow.Cells[0].Value);
            }
        }

        private void actualizarCampos(int dni)
        {
            oPaciente = oPacienteService.recuperarPacientePorDni(dni);
            txtDNI.Text = oPaciente.Dni.ToString();
            txtNombre.Text = oPaciente.Nombre;
            txtApellido.Text = oPaciente.Apellido;
            txtTelefono.Text = oPaciente.Telefono.ToString();
            txtDomicilio.Text = oPaciente.Domicilio;
            txtEmail.Text = oPaciente.Email;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            oPaciente.Dni = Convert.ToInt32(txtDNI.Text);
            oPaciente.Nombre = txtNombre.Text;
            oPaciente.Apellido = txtApellido.Text;
            oPaciente.Telefono = txtTelefono.Text;
            oPaciente.Domicilio = txtDomicilio.Text;
            oPaciente.Email = txtEmail.Text;

            //oPractica.Id_practica = Convert.ToInt32(grdPractica.SelectedValue);
            if (oPacienteService.validarPaciente())
            {
                if (this.esNuevo)
                {
                    if (!oPacienteService.existePaciente(oPaciente.Dni))
                    {
                        sentenciaYCarga(oPaciente, grdPaciente, oPacienteService, esNuevo);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Ya existe este paciente! No puede cargarla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sentenciaYCarga(oPaciente, grdPaciente, oPacienteService, esNuevo);
                }
            }
            habilitar(false);
            esNuevo = false;
        }

        private void sentenciaYCarga(Paciente ob, DataGridView grilla, PacienteService obS, bool esAlta)
        {
            obS.altaPaciente(ob, esAlta);
            cargarGrilla(grilla, obS.recuperarPaciente());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            esNuevo = false;
            limpiarCampos();
        }
    }
}
