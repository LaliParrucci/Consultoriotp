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
    public partial class frmEstadisticaTurnosConcretados : Form
    {
        TurnoService oTServ = new TurnoService();
        ProfesionalService oPServ = new ProfesionalService();
        public frmEstadisticaTurnosConcretados()
        {
            InitializeComponent(); 
            LlenarCombo(cboOdontologos, oPServ.recuperarProfesional(), "apellido", "matricula");
        }

        private void frmEstadisticaTurnosConcretados_Load(object sender, EventArgs e)
        {

            this.rpvTurnosConcretados.RefreshReport();
            
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargar();
        }


        private void frmEstadisticaTurnosConcretados_Load_1(object sender, EventArgs e)
        {

            this.rpvTurnosConcretados.RefreshReport();
        }

        private void rpvTurnosConcretados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cargar()
        {
            if (dtpDesde.Value < dtpHasta.Value)
            {
                DataTable tabla = new DataTable();
                string fecha_desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                int idProf = -1;
                if (cboOdontologos.SelectedIndex != -1)
                {
                    idProf = Convert.ToInt32(cboOdontologos.SelectedValue);
                }
                tabla = oTServ.estadisticaConcretados(fecha_desde, fecha_hasta, idProf);
                if (tabla.Rows.Count == 0)
                {
                    string msj = "No existen datos en el período elegido";
                    if (idProf != -1)
                    {
                        msj += " y/o del profesional seleccionado..."; 
                    }
                    MessageBox.Show(msj, "Estadística no creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDesde.Value = DateTime.Today;
                    dtpHasta.Value = DateTime.Today;

                }
                else
                {
                    ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
                    rpvTurnosConcretados.LocalReport.DataSources.Clear();
                    rpvTurnosConcretados.LocalReport.DataSources.Add(ds);
                    this.rpvTurnosConcretados.RefreshReport();
                }
            }
        }
    }
}
