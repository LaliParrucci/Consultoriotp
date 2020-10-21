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
    public partial class frmEstadisticasPracticasMes : Form
    {
        ConsultaService oConsultaService = new ConsultaService();


        public frmEstadisticasPracticasMes()
        {
            InitializeComponent();
        }

        private void frmEstadisticasPracticasMes_Load(object sender, EventArgs e)
        {
            fechaDesdee.Value = DateTime.Today;
            this.rpPracticasMes.RefreshReport();
        }

        private void dptFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string fecha_desde = fechaDesdee.Value.Date.ToString("yyyy-MM-dd");
            string fecha_hasta = fechaHastaa.Value.Date.ToString("yyyy-MM-dd");
            tabla = oConsultaService.estadisticasConsulta(fecha_desde, fecha_hasta);

            ReportDataSource ds = new ReportDataSource("dsConsulta", tabla);
            rpPracticasMes.LocalReport.DataSources.Clear();
            rpPracticasMes.LocalReport.DataSources.Add(ds);
            this.rpPracticasMes.RefreshReport();
        }
    }
}
