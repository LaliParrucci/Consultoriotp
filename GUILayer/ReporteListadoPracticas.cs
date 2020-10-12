using System;
using System.Data;
using System.Windows.Forms;
using Consultorio.DataAccessLayer;
using Microsoft.Reporting.WinForms;
using Consultorio.BussinessLayer;
using Consultorio.Entities;

namespace Consultorio.GUILayer
{
    public partial class listadoPracticas : Form
    {
        PracticaService practicas = new PracticaService();

        public listadoPracticas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listadoPracticas_Load(object sender, EventArgs e)
        {


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable tabla = new DataTable();
            tabla = generador();

            ReportDataSource rp = new ReportDataSource("DatosPracticas", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();

        }
        private DataTable generador()
        {
            String msg = "";
            if (textBox1.Text != "")
            {
                msg = msg + " AND nombre LIKE '%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                msg = msg + " AND id_practica = '" + textBox2.Text + "'";
            }
            if (textBox3.Text != "")
            {
                msg = msg + " AND importe >= " + textBox3.Text + "";
            }
            if (textBox4.Text != "")
            {
                msg = msg + " AND importe <= " + textBox4.Text + "";
            }
            
            FiltrosReportePracticas filtros = new FiltrosReportePracticas ();
            if (msg != "")
            {
  
             msg = msg.Remove(0, 5);
             return filtros.ObtenerListadoPracticasFiltro(msg);
           

            }
            
             return filtros.ObtenerListadoPracticas();
            
        }
    }

}
