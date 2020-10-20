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
    public partial class frmEstadisticaTurnosPorProfesional : Form
    {
        ProfesionalService oProfesionalService = new ProfesionalService();
        TurnoService oTurnoService = new TurnoService();
        public frmEstadisticaTurnosPorProfesional()
        {
            InitializeComponent();
        }

        private void frmEstadisticaTurnosPorProfesional_Load(object sender, EventArgs e)
        {

            this.rpEsTrunoPorProfesional.RefreshReport();
            cargarCombo(cboProfesional, cargarTabla(), "nombreApe", "matricula");
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

            if (dtpDesde1.Value > dtpHasta1.Value || dtpDesde2.Value > dtpHasta2.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpDesde1.Focus();
                return;
            }
            if (cboProfesional.SelectedIndex != -1)
                _profesional = cboProfesional.SelectedValue.ToString();

            DataTable tabla1 = new DataTable();
            /*tabla1 = oTurnoService.recuperarTurnoFechaProfesional(_profesional, dtpDesde1.Value, dtpHasta1.Value, dtpDesde2.Value, dtpHasta2.Value);
            if (tabla1.Rows.Count == 0 )
            {
                MessageBox.Show("No existen datos con esas condiciones...");
                dtpDesde1.Value = DateTime.Today;
                dtpHasta1.Value = DateTime.Today;
                dtpDesde2.Value = DateTime.Today;
                dtpHasta2.Value = DateTime.Today;
                cboProfesional.SelectedIndex = -1;

            }
            else
            //        this.cargarGrilla(grdBugs, tabla);
            {
                ReportDataSource ds = new ReportDataSource("", tabla1);
                rpEsTrunoPorProfesional.LocalReport.DataSources.Clear();
                rpEsTrunoPorProfesional.LocalReport.DataSources.Add(ds);
                this.rpEsTrunoPorProfesional.RefreshReport();

            }

            cboProfesional.SelectedIndex = -1;*/
        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDesde1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
