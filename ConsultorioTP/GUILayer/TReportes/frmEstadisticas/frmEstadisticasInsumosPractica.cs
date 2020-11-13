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
            //int practica = ;
            //tabla = oInsumoService.recuperarInsumosEstadisticas(practica);

            ReportDataSource ds = new ReportDataSource("dsInsumo", tabla);
            rpInsumo.LocalReport.DataSources.Clear();
            rpInsumo.LocalReport.DataSources.Add(ds);
            this.rpInsumo.RefreshReport();
        }

        private void frmEstadisticasInsumosPractica_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultorio_odontologicoTodas.practica' Puede moverla o quitarla según sea necesario.
            this.practicaTableAdapter.Fill(this.consultorio_odontologicoTodas.practica);
        }

        private void lblPractica_Click(object sender, EventArgs e)
        {

        }
    }
}
