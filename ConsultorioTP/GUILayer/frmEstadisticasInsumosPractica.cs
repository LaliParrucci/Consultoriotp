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
    public partial class frmEstadisticasInsumosPractica : Form
    {
        InsumoService oInsumoService = new InsumoService();
        public frmEstadisticasInsumosPractica()
        {
            InitializeComponent();
        }

        private void frmEstadisticasInsumosPractica_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPracticas, oInsumoService.recuperarInsumo(), "nombre", "id_insumo");
            fechaDesde.Value = DateTime.Today;
            this.rpInsumo.RefreshReport();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string practica = cboPracticas.Text;
            string fecha_desde = fechaDesde.Value.Date.ToString("yyyy-MM-dd");
            string fecha_hasta = fechaHasta.Value.Date.ToString("yyyy-MM-dd");
            tabla = oInsumoService.recuperarInsumosEstadisticas(fecha_desde, fecha_hasta, practica);

            ReportDataSource ds = new ReportDataSource("dsPractica", tabla);
            rpInsumo.LocalReport.DataSources.Clear();
            rpInsumo.LocalReport.DataSources.Add(ds);
            this.rpInsumo.RefreshReport();
        }

        private void frmEstadisticasInsumosPractica_Load_1(object sender, EventArgs e)
        {

        }
    }
}
