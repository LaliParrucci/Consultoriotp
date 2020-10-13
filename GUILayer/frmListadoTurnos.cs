using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Consultorio.GUILayer
{
    public partial class frmListadoTurnos : Form
    {
        ObraSocialDao oObraSocialDao = new ObraSocialDao();
        public frmListadoTurnos()
        {
            InitializeComponent();
        }

        private void frmListadoTurnos_Load(object sender, EventArgs e)
        {

            this.rpvTurnosDiarios.RefreshReport();
            this.rpvTurnosDiarios.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           
            DataTable tabla = new DataTable();
            tabla = oObraSocialDao.datasetObrasSociales(dtpFecha.Value.Date.ToShortDateString());

            ReportDataSource rp = new ReportDataSource("DataSet1", tabla);

            rpvTurnosDiarios.LocalReport.DataSources.Clear();
            rpvTurnosDiarios.LocalReport.DataSources.Add(rp);
            rpvTurnosDiarios.LocalReport.Refresh();

            this.rpvTurnosDiarios.RefreshReport();

        }

        private void rpvTurnosDiarios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oObraSocialDao.datasetObrasSociales(dtpFecha.Value.Date.ToShortDateString());

            ReportDataSource rp = new ReportDataSource("DataSet1", tabla);

            rpvTurnosDiarios.LocalReport.DataSources.Clear();
            rpvTurnosDiarios.LocalReport.DataSources.Add(rp);
            rpvTurnosDiarios.LocalReport.Refresh();

            this.rpvTurnosDiarios.RefreshReport();
        }
    }
}
