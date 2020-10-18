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
            // TODO: esta línea de código carga datos en la tabla 'consultorio_odontologicoTodas.obra_social' Puede moverla o quitarla según sea necesario.
            //this.obra_socialTableAdapter.Fill(this.consultorio_odontologicoTodas);
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
           
        }
        private int ObraSocial()
        {
            int id;
            id = oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text).Codigo;
            return id;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboObraSocial.SelectedValue != null)
            {
                DataTable tabla = new DataTable();
                tabla = oPracticaService.recuPracticasObraSocial(ObraSocial()); ;

                ReportDataSource rp = new ReportDataSource("dsPracticas", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una Obra social", "Campo vacio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
