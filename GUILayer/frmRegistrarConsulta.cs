using Consultorio.BussinessLayer;
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
        float importeTotal;
        public frmRegistrarConsulta()
        {
            InitializeComponent();
        }

        public void habilitar(bool x)
        {
           txtPaciente.Enabled = txtObraSocial.Enabled = txtNombreProfesional.Enabled = txtObservaciones.Enabled = cboPracticas.Enabled = txtImporte.Enabled = txtImporteTotal.Enabled = txtDescuento.Enabled = x;
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
                oPaciente = oPacienteService.recuperarPacientePorDni(Convert.ToInt32(txtDni.Text));
                oTurno = oTurnoService.recuperarTurnoFechaDni(DateTime.Today, txtDni.Text);
                oObraSocial = oObraSocialService.recuperarObraSocialPorCodigo(oTurno.Id_obra_social);
                oProfesionalE = oProfesionalService.recuperarProfesionalPorMatricula(oTurno.Id_profesional);

                txtPaciente.Text = oPaciente.Apellido + ", " + oPaciente.Nombre;
                txtObraSocial.Text = oObraSocial.Nombre;
                txtNombreProfesional.Text = oProfesionalE.Nombre;
                txtApellidoProfesional.Text = oProfesionalE.Apellido;
                txtDescuento.Text = oObraSocial.Porcentaje.ToString();

                cargarCombo(cboPracticas, oPracticaService.recuperarPracticas(), "nombre", "id_practica");
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
            oPractica = oPracticaService.recuperarPracticasPorId(Convert.ToInt32(cboPracticas.SelectedValue));

            cargarGrilla(dgvPracticas, oPractica);

            this.importeS += oPractica.Importe;
            this.importeTotal = importeS * oObraSocial.Porcentaje;

            txtImporte.Text = importeS.ToString();
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
            DataGridViewRow Linea = dgvPracticas.CurrentRow;

            removerGrilla(dgvPracticas, Linea);
        }

        private void removerGrilla(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Remove(r);
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                oConsulta.Fecha = DateTime.Today;
                oConsulta.Id_paciente = oPaciente.Dni;
                //oConsulta.Practicas_realizadas;
                //oConsulta.Cobrado = ; Tendriamos que poner un checkbox o algo asi!!
                oConsulta.Id_profesional = oProfesionalE.Matricula;
                //oConsulta.Monto = hay que ponerlo en float
                oConsulta.Num_turno = oTurno.Num_turno;
                oConsulta.Observacion = txtObservaciones.Text;
                
                //Quedamos aca!!
                //string disponible = grdTurnosDisp.CurrentRow.Cells["Disponible"].Value.ToString();
                //if (oTurnoService.validarTurno(oTurno, disponible))
                //{
                //    if (oTurnoService.crearTurnoConHistorial(oTurno, txtObservaciones.Text))
                //    {
                //        MessageBox.Show("Se registró el turno correctamente", "Turno registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        clickChBox();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Hubo un problema con el registro de turno", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            }
        }

        private bool validarCampos()
        {
            if(txtDni.Text == "")
            {
                MessageBox.Show("Debe Ingresar un dni...", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
