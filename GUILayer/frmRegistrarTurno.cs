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
            if (lista.Count() == 1)
            {
                cboDni.Enabled = false;
                cboDni.SelectedIndex = -1;
                txtDni.Text = lista[0].Dni.ToString();
            }
            else
            {
                cboDni.Enabled = true;
                txtDni.Text = ""; txtDni.Enabled = false;
                LlenarCombo(cboDni, lista, "dni", "dni");
            }
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
            if (txtDni.Text != "")
            {
                dni = Convert.ToInt32(txtDni.Text);
            }
            else { dni = Convert.ToInt32(cboDni.SelectedItem); }
            oTurno.Fecha_hora = txtFecha.Text;
            oTurno.Id_profesional = mat;
            oTurno.Id_obra_social = (oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text)).Codigo;
            oTurno.Id_paciente = dni;
            oTurnoService.crearTurnoConHistorial(oTurno, txtObservaciones.Text);
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtFecha.Text = calendario.SelectionRange.Start.Date.ToLongDateString();
            // LlenarCombo(cboHora, oTurnoService.recuperarTurnos(), "hora", "num_turno");
            txtTurnos.Text = "Horarios disponibles para el día " + this.txtFecha.Text + ", para el profesional seleccionado: " +
                "turno 1 - turno 2 - turno 3";
        }
    }
}
