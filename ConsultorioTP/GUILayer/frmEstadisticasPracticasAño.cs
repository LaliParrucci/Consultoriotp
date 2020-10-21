using Consultorio.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Consultorio.GUILayer
{
    public partial class frmEstadisticasPracticasAño : Form
    {
        ConsultaService oConsultaService = new ConsultaService();
        public frmEstadisticasPracticasAño()
        {
            InitializeComponent();
        }

        private void frmEstadisticasPracticasAño_Load(object sender, EventArgs e)
        {
            this.rpPracticas.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oConsultaService.recuperarPracticaPorAño(txtAño.Text);

            ReportDataSource ds = new ReportDataSource("dsPractica", tabla);
            rpPracticas.LocalReport.DataSources.Clear();
            rpPracticas.LocalReport.DataSources.Add(ds);
            this.rpPracticas.RefreshReport();
        }
    }
}
