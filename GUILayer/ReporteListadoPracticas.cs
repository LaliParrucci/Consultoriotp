using System;
using System.Data;
using System.Windows.Forms;
using Consultorio.DataAccessLayer;
using Microsoft.Reporting.WinForms;
using Consultorio.BussinessLayer;

namespace Consultorio.GUILayer
{
    public partial class listadoPracticas : Form
    {
        PracticaService practicas = new PracticaService();

        public listadoPracticas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listadoPracticas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = practicas.recuPracticas();

            ReportDataSource rp = new ReportDataSource("DatosPracticas",tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.LocalReport.Refresh();


            
        }
    }
}
