using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.DataAccessLayer;
using Microsoft.Reporting.WinForms;

namespace Consultorio.GUILayer
{
    public partial class frmInformeMontosOOSS : Form
    {
        ObraSocialDao oDao = new ObraSocialDao();
        public frmInformeMontosOOSS()
        {
            InitializeComponent();
        }

        private void frmInformeMontosOOSS_Load(object sender, EventArgs e)
        {

            this.rpvMontos.RefreshReport();
        }

        private void rptMontosOOSS_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            if (dtpDesde.Value < dtpHasta.Value)
            {
                tabla = oDao.datasetObrasSocialesReporte(dtpDesde.Value.Date.ToShortDateString(), dtpHasta.Value.Date.ToShortDateString());

                ReportDataSource rp = new ReportDataSource("DataSet1", tabla);

                rpvMontos.LocalReport.DataSources.Clear();
                rpvMontos.LocalReport.DataSources.Add(rp);
                rpvMontos.LocalReport.Refresh();

                this.rpvMontos.RefreshReport();
            }
            else { MessageBox.Show("Seleccione un rango de fechas válido", "Error en rango de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

