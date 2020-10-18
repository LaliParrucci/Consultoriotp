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
        string practicas="";
        float importeTotal = 500;
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
                if (Service.esInt(txtDni.Text) != 0)
                {
                    oPaciente = oPacienteService.recuperarPacientePorDni(Convert.ToInt32(txtDni.Text));
                }
                else { MessageBox.Show("Ingrese un número de DNI válido", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (oPaciente != null)
                {
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
                string[] listaPracticas;
                foreach (DataGridViewRow Datarow in dgvPracticas.Rows)
                {
                    if (Datarow.Cells[0].Value != null)
                    {
                        practicas += oPracticaService.recuperarPracticasPorNom(Datarow.Cells[0].Value.ToString()).Id_practica + ", ";
                    }
                }
                
                oConsulta.Fecha = DateTime.Today;
                oConsulta.Id_paciente = oPaciente.Dni;
                oConsulta.Practicas_realizadas = practicas;
                oConsulta.Cobrado = Convert.ToBoolean(chCobrado);
                oConsulta.Id_profesional = oProfesionalE.Matricula;
                oConsulta.Monto = Convert.ToInt32(txtImporteTotal);
                oConsulta.Num_turno = oTurno.Num_turno;
                oConsulta.Observacion = txtObservaciones.Text;

                oConsultaService.crearConsultaTransaccion(oConsulta);
            }
        }

        private bool validarCampos()
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un dni...", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtPaciente.Text == "")
            {
                MessageBox.Show("Debe ingresar un paciente primero...", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
