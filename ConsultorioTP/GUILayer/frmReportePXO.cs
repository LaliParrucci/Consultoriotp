using Consultorio.BussinessLayer;
using Microsoft.Reporting.WinForms;
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
    
    public partial class frmReportePXO : Form
    {
        PacienteService oPacienteService = new PacienteService();
        ProfesionalService oProfesionalService = new ProfesionalService();
        public frmReportePXO()
        {
            InitializeComponent();
        }

        private void frmReportePXO_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            this.rpPXO.RefreshReport();
            cargarCombo(cboProfesional, cargarTabla(), "nombreApe" , "matricula");
        }

        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private DataTable cargarTabla()
        {
            DataTable tabla = new DataTable();
            tabla = oProfesionalService.recuperarTodos();
            tabla.Columns.Add("nombreApe", typeof(string), "Nombre + ' ' + Apellido");
            return tabla;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _profesional;
            _profesional = "";

            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpDesde.Focus();
                return;
            }
            if (cboProfesional.SelectedIndex != -1)
                _profesional = cboProfesional.SelectedValue.ToString();

            DataTable tabla = new DataTable();
            tabla = oPacienteService.recuperarPacientePorFecha(_profesional, dtpDesde.Value, dtpHasta.Value);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos con esas condiciones...");
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;
                cboProfesional.SelectedIndex = -1;

            }
            else
            //        this.cargarGrilla(grdBugs, tabla);
            {
                ReportDataSource ds = new ReportDataSource("rpPXO", tabla);
                rpPXO.LocalReport.DataSources.Clear();
                rpPXO.LocalReport.DataSources.Add(ds);
                this.rpPXO.RefreshReport();
                
            }

            cboProfesional.SelectedIndex = -1;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
