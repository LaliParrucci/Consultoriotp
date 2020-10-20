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
    public partial class frmEstadisticaPracticaPorConsulta : Form
    {

        PracticaService oPracticaService = new PracticaService();
        ConsultaService oConsultaService = new ConsultaService();
        

        public frmEstadisticaPracticaPorConsulta()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPracticaPorConsulta_Load(object sender, EventArgs e)
        {
            dtpDsd.Value = DateTime.Today;
            dtpHst.Value = DateTime.Today;
            this.reportViewer1.RefreshReport();
            cargarCombo(cboPractica, oPracticaService.recuperarPracticas(), "Nombre", "id_practica");

        }
        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        public void cargar()
        {
            if (dtpDsd.Value < dtpHst.Value)
            {
                string fecha_desde = dtpDsd.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHst.Value.Date.ToString("yyyy-MM-dd");
                DataTable tabla = oConsultaService.estadisticasConsulta(fecha_desde,fecha_hasta);

                ReportDataSource ds = new ReportDataSource("DatosConsulta", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dtpDsd.Value > dtpHst.Value)
            {
                MessageBox.Show("Las fechas no son correctas");
                dtpDsd.Focus();
                return;
            }
            DataTable tabla = new DataTable();
            tabla = oConsultaService.;
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos con esas condiciones...");
                dtpDsd.Value = DateTime.Today;
                dtpHst.Value = DateTime.Today;

            }
            else
            {
                ReportDataSource ds = new ReportDataSource("DatosConsulta", tabla);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
