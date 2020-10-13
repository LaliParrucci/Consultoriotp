using Consultorio.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.BussinessLayer;
using Microsoft.Reporting.WinForms;

namespace Consultorio.GUILayer
{
    public partial class frmReportePrXOb : Form
    {
        ObraSocialService oObraSocialService = new ObraSocialService();
        PracticaService oPracticaService = new PracticaService();
        public frmReportePrXOb()
        {
            InitializeComponent();
        }

        private void frmReportePrXOb_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboObraSocial, oObraSocialService.recuperarObraSocial(), "nombre", "codigo");
            this.reportViewer1.RefreshReport();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           DataTable tabla = new DataTable();
            tabla = oPracticaService.recuPracticasObraSocial(ObraSocial());
            ReportDataSource ds = new ReportDataSource("DatosPractica", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
        private int ObraSocial()
        {
            int id;
            id = (oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text)).Codigo;

            return id;
        }
    }
}
