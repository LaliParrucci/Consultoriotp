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
            // TODO: esta línea de código carga datos en la tabla 'consultorio_odontologicoTodas.practica' Puede moverla o quitarla según sea necesario.
            dtpDsd.Value = DateTime.Today;
            dtpHst.Value = DateTime.Today;
            this.reportViewer1.RefreshReport();
            cargarCombo(cboPractica, oPracticaService.recuperarPracticas(), "Nombre", "id_practica");

            this.reportViewer1.RefreshReport();
        }
        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargar();
        }


        private void dtpDsd_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cargar()
        {
            if (dtpDsd.Value < dtpHst.Value)
            {
                DataTable tabla = new DataTable();
                string fecha_desde = dtpDsd.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHst.Value.Date.ToString("yyyy-MM-dd");
                int idPrac = -1;
                if (cboPractica.SelectedIndex != -1)
                {
                    idPrac = Convert.ToInt32(cboPractica.SelectedValue);
                }
                tabla = oConsultaService.estadisticasPrXConsulta(fecha_desde, fecha_hasta, idPrac);
                if (tabla.Rows.Count == 0)
                {
                    string msj = "No existen datos en el período elegido";
                    if (idPrac != -1)
                    {
                        msj += " y/o del profesional seleccionado...";
                    }
                    MessageBox.Show(msj, "Estadística no creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDsd.Value = DateTime.Today;
                    dtpHst.Value = DateTime.Today;

                }
                else
                {
                    ReportDataSource ds = new ReportDataSource("dsPractica", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    this.reportViewer1.RefreshReport();
                }
            }
        }
    }
}
