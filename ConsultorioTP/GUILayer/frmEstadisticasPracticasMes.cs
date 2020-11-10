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
        ProfesionalService oProfesionalService = new ProfesionalService();


        public frmEstadisticasPracticasMes()
        {
            InitializeComponent();
        }

        private void frmEstadisticasPracticasMes_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboProfesional, oProfesionalService.recuperarProfesional(), "nombre", "matricula");
            // TODO: esta línea de código carga datos en la tabla 'consultorio_odontologicoTodas.profesional' Puede moverla o quitarla según sea necesario.
            fechaDesdee.Value = DateTime.Today;
            this.rpPracticasMes.RefreshReport();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void dptFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            if (fechaDesdee.Value < fechaHastaa.Value)
            {
                DataTable tabla = new DataTable();
                string fecha_desde = fechaDesdee.Value.Date.ToString("yyyy-MM-dd");
                string fecha_hasta = fechaHastaa.Value.Date.ToString("yyyy-MM-dd");
                int idProf = -1;
                if (cboProfesional.SelectedIndex != -1)
                {
                    idProf = Convert.ToInt32(cboProfesional.SelectedValue);
                }
                tabla = oConsultaService.estadisticasConsulta(fecha_desde, fecha_hasta, idProf);
                if (tabla.Rows.Count == 0)
                {
                    string msj = "No existen datos en el período elegido";
                    if (idProf != -1)
                    {
                        msj += " y/o del profesional seleccionado...";
                    }
                    MessageBox.Show(msj, "Estadística no creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fechaDesdee.Value = DateTime.Today;
                    fechaHastaa.Value = DateTime.Today;

                }
                else
                {
                    ReportDataSource ds = new ReportDataSource("DatosPractica", tabla);
                    rpPracticasMes.LocalReport.DataSources.Clear();
                    rpPracticasMes.LocalReport.DataSources.Add(ds);
                    this.rpPracticasMes.RefreshReport();
                }
            }
        }
    }
}
