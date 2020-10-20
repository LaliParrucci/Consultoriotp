using Consultorio.GUILayer;
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
    public partial class frmReportes : Form
    {
        
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnPXO_Click(object sender, EventArgs e)
        {
            frmReportePXO frm = new frmReportePXO();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoTurnos frm = new frmListadoTurnos();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrXOb_Click(object sender, EventArgs e)
        {
            frmReportePrXOb frm = new frmReportePrXOb();
            frm.ShowDialog();
        }

        private void btnOMUtilizadas_Click(object sender, EventArgs e)
        {
            frmReporteObrasMasUtilizadas frm = new frmReporteObrasMasUtilizadas();
            frm.ShowDialog();
        }

    

        private void btnPrXP_Click(object sender, EventArgs e)
        {
            frmReportePrXP frm = new frmReportePrXP();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMontosCobrar_Click(object sender, EventArgs e)
        {
            frmInformeMontosOOSS frm = new frmInformeMontosOOSS();
            frm.ShowDialog();
        }

        private void btnPracticas_Click(object sender, EventArgs e)
        {
            listadoPracticas ventana = new listadoPracticas();
            ventana.ShowDialog();
        }

        private void btnLInsumos_Click(object sender, EventArgs e)
        {
            frmReporteListadoInsumos ventana = new frmReporteListadoInsumos();
            ventana.ShowDialog();
        }

       

        private void btnOconMasPacientes_Click(object sender, EventArgs e)
        {
            frmEstadisticasOconMasPacientes ventana = new frmEstadisticasOconMasPacientes();
            ventana.ShowDialog();
        }

        private void btnEstadisticaOOSSmasUsadas_Click(object sender, EventArgs e)
        {
            frmEstadísticaOOSS ventana = new frmEstadísticaOOSS();
            ventana.ShowDialog();
        }

        private void btnTurnosConcretados_Click(object sender, EventArgs e)
        {
            frmEstadisticaTurnosConcretados ventana = new frmEstadisticaTurnosConcretados();
            ventana.ShowDialog();
        }

        private void btnPracticasAño_Click(object sender, EventArgs e)
        {
            frmEstadisticasPracticasAño frm = new frmEstadisticasPracticasAño();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmEstadisticaPracticaPorConsulta frm = new frmEstadisticaPracticaPorConsulta();
            frm.ShowDialog();
        }
    }
}
