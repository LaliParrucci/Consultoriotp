using Consultorio.BussinessLayer;
using Consultorio.DataAccessLayer;
using Consultorio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.GUILayer
{
    public partial class frmRegistrarConsulta : Form
    {
        PacienteE oPaciente = new PacienteE();
        Turno oTurno = new Turno();
        ObraSocial oObraSocial = new ObraSocial();
        ObraSocialService oObraSocialService = new ObraSocialService();
        ProfesionalE oProfesionalE = new ProfesionalE();
        ProfesionalService oProfesionalService = new ProfesionalService();
        PacienteService oPacienteService = new PacienteService();
        TurnoService oTurnoService = new TurnoService();
        PracticaService oPracticaService = new PracticaService();
        Practica oPractica = new Practica();
        Consulta oConsulta = new Consulta();
        ConsultaService oConsultaService = new ConsultaService();
        int importeS;
        int[] practicas;
        float importeTotal = 500;
        public frmRegistrarConsulta()
        {
            InitializeComponent();
        }

        public void habilitar(bool x)
        {
           txtPaciente.Enabled = txtObraSocial.Enabled = txtNombreProfesional.Enabled = txtObservaciones.Enabled = cboPracticas.Enabled = txtImporte.Enabled = txtImporteTotal.Enabled = txtDescuento.Enabled = x;
        }

        private void limpiarCampos()
        {
            dgvPracticas.Rows.Clear();
            txtApellidoProfesional.Text = txtDescuento.Text = txtDni.Text = txtImporte.Text = txtImporteTotal.Text = txtNombreProfesional.Text = txtObraSocial.Text = txtObservaciones.Text = txtPaciente.Text = "";
        }

        private void frmRegistrarConsulta_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                this.habilitar(true);
                if (Service.esInt(txtDni.Text) != 0)
                {
                    oPaciente = oPacienteService.recuperarPacientePorDni(Convert.ToInt32(txtDni.Text));
                }
                else { MessageBox.Show("Ingrese un número de DNI válido", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (oPaciente != null)
                {
                    oTurno = oTurnoService.recuperarTurnoFechaDni(Convert.ToDateTime("2020-09-13"), txtDni.Text);
                    //oTurno = oTurnoService.recuperarTurnoFechaDni(DateTime.Today, txtDni.Text);
                    if (oTurno != null)
                    {
                        oObraSocial = oObraSocialService.recuperarObraSocialPorCodigo(oTurno.Id_obra_social);
                        oProfesionalE = oProfesionalService.recuperarProfesionalPorMatricula(oTurno.Id_profesional);

                        txtPaciente.Text = oPaciente.Apellido + ", " + oPaciente.Nombre;
                        txtObraSocial.Text = oObraSocial.Nombre;
                        txtNombreProfesional.Text = oProfesionalE.Nombre;
                        txtApellidoProfesional.Text = oProfesionalE.Apellido;
                        txtDescuento.Text = oObraSocial.Porcentaje.ToString();

                        cargarCombo(cboPracticas, oPracticaService.recuperarPracticas(), "nombre", "id_practica");
                    }
                    else
                    {
                        MessageBox.Show("El paciente que seleccionó no tiene ningún turno asignado", "No se encontró el turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró al paciente que busca", "Búsqueda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }


        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboPracticas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una práctica para cargar", "Seleccione una práctica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            oPractica = oPracticaService.recuperarPracticasPorId(Convert.ToInt32(cboPracticas.SelectedValue));

            cargarGrilla(dgvPracticas, oPractica);

            this.importeTotal = importeTotal + (oPractica.Importe * oObraSocial.Porcentaje);

            txtImporte.Text = oPractica.Importe.ToString();
            txtImporteTotal.Text = importeTotal.ToString();
            
        }


        private void cargarGrilla(DataGridView grilla, Practica p)
        {
            grilla.Rows.Add(p.Nombre, p.Descripcion, p.Importe);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPracticas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una práctica para eliminar", "Seleccione una práctica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow Linea = dgvPracticas.CurrentRow;
                removerGrilla(dgvPracticas, Linea);
            }
        }

        private void removerGrilla(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Remove(r);
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                practicas = new int[(dgvPracticas.Rows.Count) - 1];
                int i = 0;
                foreach (DataGridViewRow Datarow in dgvPracticas.Rows)
                {
                    if (Datarow.Cells[0].Value != null)
                    {
                        int id = oPracticaService.recuperarPracticasPorNom(Datarow.Cells[0].Value.ToString()).Id_practica;
                        practicas[i] = id;
                        i++;
                    }
                }

                //oConsulta.Fecha = DateTime.Today;
                oConsulta.Fecha = Convert.ToDateTime("2020-09-13");
                oConsulta.Id_paciente = oPaciente.Dni;
                oConsulta.Cobrado = Convert.ToBoolean(chCobrado.Checked);
                oConsulta.Id_profesional = oProfesionalE.Matricula;
                oConsulta.Monto = Convert.ToSingle(txtImporteTotal.Text);
                oConsulta.Num_turno = oTurno.Num_turno;
                oConsulta.Observacion = txtObservaciones.Text;

                if (oConsultaService.crearConsultaTransaccion(oConsulta, practicas))
                {
                    MessageBox.Show("La consulta se registró correctamente", "Consulta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un problema con el registro de la consulta", "Consulta no registrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                importeS = 0; importeTotal = 500;
            }

            
        }

        private bool validarCampos()
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un dni...", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //if(txtPaciente.Text == "")
            //{
            //    MessageBox.Show("Debe ingresar un paciente primero...", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }
    }
}
