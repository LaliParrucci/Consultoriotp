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
    public partial class frmEstadisticaTurnosConcretados : Form
    {
        TurnoService oTServ = new TurnoService();
        public frmEstadisticaTurnosConcretados()
        {
            InitializeComponent();
        }

        private void frmEstadisticaTurnosConcretados_Load(object sender, EventArgs e)
        {

            this.rpvTurnosConcretados.RefreshReport();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                DataTable tabla = new DataTable();
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                tabla = oTServ.estadisticaConcretados(fecha_desde, fecha_hasta);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existen datos con esas condiciones...");
                    dtpDesde.Value = DateTime.Today;
                    dtpHasta.Value = DateTime.Today;

                }
                else
                {
                    ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
                    rpvTurnosConcretados.LocalReport.DataSources.Clear();
                    rpvTurnosConcretados.LocalReport.DataSources.Add(ds);
                    this.rpvTurnosConcretados.RefreshReport();
                }
            }
        }


        private void frmEstadisticaTurnosConcretados_Load_1(object sender, EventArgs e)
        {

            this.rpvTurnosConcretados.RefreshReport();
        }

        private void rpvTurnosConcretados_Load(object sender, EventArgs e)
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                DataTable tabla = oTServ.estadisticaConcretados(fecha_desde, fecha_hasta);

                ReportDataSource ds = new ReportDataSource("DataSet1", tabla);

                rpvTurnosConcretados.LocalReport.DataSources.Clear();
                rpvTurnosConcretados.LocalReport.DataSources.Add(ds);
                rpvTurnosConcretados.LocalReport.Refresh();
            }
        }
    }
}
