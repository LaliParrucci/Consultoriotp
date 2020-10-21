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
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dtpDesde1.Value > dtpHasta1.Value || dtpDesde2.Value > dtpHasta2.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpDesde1.Focus();
                return;
            }

            DataTable tabla1 = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla1 = oTurnoService.recuperarTurnoFechaProfesional(dtpDesde1.Value, dtpHasta1.Value);
            tabla2 = oTurnoService.recuperarTurnoFechaProfesional(dtpDesde1.Value, dtpHasta1.Value);
            if (tabla1.Rows.Count == 0 || tabla2.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos con esas condiciones...");
                dtpDesde1.Value = DateTime.Today;
                dtpHasta1.Value = DateTime.Today;
                dtpDesde2.Value = DateTime.Today;
                dtpHasta2.Value = DateTime.Today;
                

            }
            else
            {
                ReportDataSource ds1 = new ReportDataSource("DataSetMes1", tabla1);
                ReportDataSource ds2 = new ReportDataSource("DataSetMes2", tabla2);
                rpEsTrunoPorProfesional.LocalReport.DataSources.Clear();
                rpEsTrunoPorProfesional.LocalReport.DataSources.Add(ds1);
                rpEsTrunoPorProfesional.LocalReport.DataSources.Add(ds2);
                this.rpEsTrunoPorProfesional.RefreshReport();

            }
        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
