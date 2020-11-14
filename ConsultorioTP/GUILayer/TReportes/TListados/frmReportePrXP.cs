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
using Consultorio.BussinessLayer;

namespace Consultorio.GUILayer
{
    public partial class frmReportePrXP : Form
    {
        PracticaService oPracticaService = new PracticaService();
        ProfesionalService oProfesionalService = new ProfesionalService();
        public frmReportePrXP()
        {
            InitializeComponent();
        }

        private void frmReportePrXP_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboProfesional, oProfesionalService.recuperarProfesional(), "apellido", "matricula");
            //this.profesionalTableAdapter1.Fill(this.consultorio_odontologicoDataSet31.profesional);
            fechaDesde.Value = DateTime.Today;
            this.reportViewer1.RefreshReport();
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
            
            if (cboProfesional.SelectedValue != null)
            {
                string fecha_desde = fechaDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = fechaHasta.Value.Date.ToString("yyyy-MM-dd");
                DataTable tabla = new DataTable();
                tabla = oPracticaService.recuPracticasProfesional(IdProfesional(), fecha_desde, fecha_hasta);

                ReportDataSource rp = new ReportDataSource("dsPractica", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione un Profesional", "Campo vacio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int IdProfesional()
        {
            int matricula;
            matricula = oProfesionalService.recuProfesionalApe(cboProfesional.Text).Matricula;

            return matricula;
        }
    }
}
