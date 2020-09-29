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
    public partial class frmRegistrarTurno : Form
    {
        bool activoProfesional = false;
        TurnoService oTurnoService = new TurnoService();
        ProfesionalService oProfesionalService = new ProfesionalService();
        ObraSocialService oObraSocialService = new ObraSocialService();
        PacienteService oPacienteService = new PacienteService();
        Turno oTurno = new Turno();
        frmAbmPaciente formPaciente;
        public frmRegistrarTurno()
        {
            InitializeComponent();
        }

        private void frmRegistrarTurno_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboObraSocial, oObraSocialService.recuperarObraSocial(), "nombre", "codigo");
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            List<ProfesionalE> lst = oProfesionalService.recuperarProfesionalPorNombre(txtNombreProfesional.Text);
            foreach (ProfesionalE X in lst)
            {
                col.Add(X.Apellido.ToString());
            }
        }

        public void autocompletar(TextBox otextBox)
        {
            otextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            otextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            addItems(coleccion);
            otextBox.AutoCompleteCustomSource = coleccion;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void activoAutocompletar(TextBox txt, bool bandera)
        {
            if (!bandera)
            {
                autocompletar(txt);
                bandera = true;
            }
        }

        private void txtApellidoProfesional_Click(object sender, EventArgs e)
        {
            activoAutocompletar(txtApellidoProfesional, activoProfesional);
        }

        private void txtApellidoProfesional_Enter(object sender, EventArgs e)
        {
            activoAutocompletar(txtApellidoProfesional, activoProfesional);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<PacienteE> lista = oPacienteService.recuperarPacientePorNA(txtNombrePaciente.Text, txtApellidoPaciente.Text);
            if(lista.Count == 0)
            {
                if(MessageBox.Show("No se encontró el paciente que busca, ¿desea registrarlo?", "Búsqueda no encontrada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //    txtApellidoPaciente.Text = txtNombrePaciente.Text = "";
                    formPaciente = new frmAbmPaciente(this.txtNombrePaciente.Text, this.txtApellidoPaciente.Text);
                    formPaciente.ShowDialog();
                    txtNombrePaciente.Focus();
                    lista = oPacienteService.recuperarPacientePorNA(txtNombrePaciente.Text, txtApellidoPaciente.Text);
                }
                else
                {
                    MessageBox.Show("Falló el registro del turno", "Cancelación de turno");
                }
            }
            LlenarCombo(cboDni, lista, "dni", "dni");
            cboDni.SelectedIndex = 0;

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int mat = 0, dni = 0;
            List<ProfesionalE> ls = oProfesionalService.recuperarProfesionalPorNombre(txtNombreProfesional.Text);
            foreach (ProfesionalE p in ls)
            {
                if (p.Apellido == txtApellidoProfesional.Text)
                {
                    mat = p.Matricula;
                }
            }
            if (cboDni.Text != "")
            {
                dni = Convert.ToInt32(cboDni.Text);
            }
            else { dni = Convert.ToInt32(cboDni.Text); }
            oTurno.Fecha_hora = txtFecha.Text;
            oTurno.Id_profesional = mat;
            oTurno.Id_obra_social = (oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text)).Codigo;
            oTurno.Id_paciente = dni;
            if (oTurnoService.validarTurno(oTurno))
            {
                if(oTurnoService.crearTurnoConHistorial(oTurno, txtObservaciones.Text))
                {
                    MessageBox.Show("Se registró el turno correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un problema con el registro de turno");
                }
            }
            limpiarCampos();
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtFecha.Text = calendario.SelectionRange.Start.Date.ToLongDateString();
            // LlenarCombo(cboHora, oTurnoService.recuperarTurnos(), "hora", "num_turno");
            IList<Turno> lista = oTurnoService.recuperarTurnoFecha(this.txtFecha.Text);
            if (lista.Count == 0) { txtTurnos.Text = "No hay turnos registrados para la fecha"; }
            else
            {
                txtTurnos.Text = "Horarios disponibles para el día " + this.txtFecha.Text + ", para el profesional seleccionado:\n";
                foreach (Turno t in lista)
                {
                    txtTurnos.Text += "\nNúmero de turno: " + t.Num_turno + " - Paciente: " + t.Id_paciente;
                }
            }
        }

        private void limpiarCampos()
        {
            cboDni.SelectedIndex = cboObraSocial.SelectedIndex = -1;
            txtApellidoPaciente.Text = txtApellidoProfesional.Text = txtFecha.Text = txtNombrePaciente.Text = txtNombreProfesional.Text = txtObservaciones.Text = "";
        }

        private void txtApellidoPaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
