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
        TurnoDao oTDao = new TurnoDao();
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
            cargar();
        }

        private void cargar()
        {

            DataTable tabla = new DataTable();
            tabla = oTDao.datasetTurnosReporte(dtpFecha.Value);

            ReportDataSource rp = new ReportDataSource("DataSet1", tabla);

            rpvTurnosDiarios.LocalReport.DataSources.Clear();
            rpvTurnosDiarios.LocalReport.DataSources.Add(rp);
            rpvTurnosDiarios.LocalReport.Refresh();
            this.rpvTurnosDiarios.RefreshReport();
        }

        private void rpvTurnosDiarios_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
