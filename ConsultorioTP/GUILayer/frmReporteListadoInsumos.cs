using Consultorio.Entities;
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
    public partial class frmReporteListadoInsumos : Form
    {
        public frmReporteListadoInsumos()
        {
            InitializeComponent();
        }

        private void frmReporteListadoInsumos_Load(object sender, EventArgs e)
        {

            
        }

        private DataTable generador()
        {
            String msg = "";
            if (textBox1.Text != "")
            {
                msg = msg + " AND stock >= '" + textBox2.Text + "'";
            }
            if (textBox2.Text != "")
            {
                msg = msg + " AND stock <= '" + textBox1.Text + "'";
            }


            FiltrosReporteInsumos filtros = new FiltrosReporteInsumos();
            if (msg != "")
            {
                msg = msg.Remove(0, 5);
                return filtros.ObtenerListadoInsumosFiltro(msg);

            }
            return filtros.ObtenerListadoInsumos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void rpvReporteInsumos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            DataTable table = new DataTable();
            table = generador();

            ReportDataSource rp = new ReportDataSource("DataInsumos", table);

            rpvReporteInsumos.LocalReport.DataSources.Clear();
            rpvReporteInsumos.LocalReport.DataSources.Add(rp);
            rpvReporteInsumos.LocalReport.Refresh();

            this.rpvReporteInsumos.RefreshReport();
        }
    }
}
