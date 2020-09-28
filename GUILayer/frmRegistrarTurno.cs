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
        bool activoPaciente = false;
        TurnoService oTurnoService = new TurnoService();
        ProfesionalService oProfesionalService = new ProfesionalService();
        ObraSocialService oObraSocialService = new ObraSocialService();
        PacienteService oPacienteService = new PacienteService();
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

        private void txtApellidoProfesional_Click(object sender, EventArgs e)
        {
            if (!activoProfesional)
            {
                autocompletar(txtApellidoProfesional);
                activoProfesional = true;
            }

        }

        private void txtApellidoProfesional_Enter(object sender, EventArgs e)
        {
            if (!activoProfesional)
            {
                autocompletar(txtApellidoProfesional);
                activoProfesional = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtApellidoPaciente_Click(object sender, EventArgs e)
        {
            if (!activoPaciente)
            {
                autocompletar(txtApellidoPaciente);
                activoPaciente = true;
            }
        }

        private void txtApellidoPaciente_Enter(object sender, EventArgs e)
        {
            if (!activoPaciente)
            {
                autocompletar(txtApellidoPaciente);
                activoPaciente = true;
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            txtDni.Text = (oPacienteService.recuperarPacientePorNA(txtNombrePaciente.Text, txtApellidoPaciente.Text)).ToString();
        }
    }
}
