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
    public partial class frmReporteObrasMasUtilizadas : Form
    {
        ObraSocialService oObraSocialService = new ObraSocialService();
        public frmReporteObrasMasUtilizadas()
        {
            InitializeComponent();
        }

        private void frmReporteObrasMasUtilizadas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            this.rpObrasMasUtilizadas.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpDesde.Focus();
                return;
            }
            DataTable tabla = new DataTable();
            tabla = oObraSocialService.recuperarObraSocialPorfecha(dtpDesde.Value,dtpHasta.Value);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen esas condiciones de busqueda...");
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;
            }
            else
            //        this.cargarGrilla(grdBugs, tabla);
            {
                ReportDataSource ds = new ReportDataSource("dsOmasUtilizadas", tabla);
                rpObrasMasUtilizadas.LocalReport.DataSources.Clear();
                rpObrasMasUtilizadas.LocalReport.DataSources.Add(ds);
                this.rpObrasMasUtilizadas.RefreshReport();
            }
        }
    }
}
