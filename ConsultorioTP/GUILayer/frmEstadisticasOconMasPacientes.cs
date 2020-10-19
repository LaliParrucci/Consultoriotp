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
using Consultorio.GUILayer;

namespace Consultorio.GUILayer
{
    public partial class frmEstadisticasOconMasPacientes : Form
    {
        ConsultaService oConsultaService = new ConsultaService();
        public frmEstadisticasOconMasPacientes()
        {
            InitializeComponent();
        }

        private void frmEstadisticasOconMasPacientes_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            this.rpOmP.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpDesde.Focus();
                return;
            }
            DataTable tabla = new DataTable();
            tabla = oConsultaService.recuperarPacientesPorProfesionalPorfecha(dtpDesde.Value, dtpHasta.Value);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos con esas condiciones...");
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;

            }
            else
            {
                ReportDataSource ds = new ReportDataSource("DataSetOdon", tabla);
                rpOmP.LocalReport.DataSources.Clear();
                rpOmP.LocalReport.DataSources.Add(ds);
                this.rpOmP.RefreshReport();
            }

        }
    }
}
