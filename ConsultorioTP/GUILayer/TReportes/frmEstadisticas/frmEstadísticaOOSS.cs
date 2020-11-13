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
    public partial class frmEstadísticaOOSS : Form
    {
        ObraSocialService oObra = new ObraSocialService();
        public frmEstadísticaOOSS()
        {
            InitializeComponent();
        }

        private void frmEstadísticaOOSS_Load(object sender, EventArgs e)
        {

            this.rpvEstadisticaOOSS.RefreshReport();
        }

        private void rpvEstadisticaOOSS_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                DataTable tabla = oObra.obrasSocialesEstadistica(fecha_desde, fecha_hasta);

                ReportDataSource ds = new ReportDataSource("DataSet1", tabla);

                rpvEstadisticaOOSS.LocalReport.DataSources.Clear();
                rpvEstadisticaOOSS.LocalReport.DataSources.Add(ds);
                rpvEstadisticaOOSS.LocalReport.Refresh();
            }
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                DataTable tabla = new DataTable();
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                tabla = oObra.obrasSocialesEstadistica(fecha_desde, fecha_hasta);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existen datos con esas condiciones...");
                    dtpDesde.Value = DateTime.Today;
                    dtpHasta.Value = DateTime.Today;

                }
                else
                {
                    ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
                    rpvEstadisticaOOSS.LocalReport.DataSources.Clear();
                    rpvEstadisticaOOSS.LocalReport.DataSources.Add(ds);
                    this.rpvEstadisticaOOSS.RefreshReport();
                }
            }
        }
    }
}
