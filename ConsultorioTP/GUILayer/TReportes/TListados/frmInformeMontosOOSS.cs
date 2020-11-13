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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cargar();
        }


        private void rpvMontos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            DataTable tabla = new DataTable();

            if (dtpDesde.Value < dtpHasta.Value)
            {
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy/MM/dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy/MM/dd");
                //tabla = oDao.datasetObrasSocialesReporte(dtpDesde.Value.Date.ToShortDateString(), dtpHasta.Value.Date.ToShortDateString());
                tabla = oDao.datasetObrasSocialesReporte(fecha_desde, fecha_hasta);

                ReportDataSource rp = new ReportDataSource("DataSetMontos", tabla);

                rpvMontos.LocalReport.DataSources.Clear();
                rpvMontos.LocalReport.DataSources.Add(rp);
                rpvMontos.LocalReport.Refresh();

                this.rpvMontos.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione un rango de fechas válido", "Error en rango de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

