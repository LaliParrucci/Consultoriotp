using Consultorio.GUILayer.Informes;
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
            frmListadoTurnosDiarios frm = new frmListadoTurnosDiarios();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listadoPracticas ventana = new listadoPracticas();
            ventana.ShowDialog();
        }

        private void btnPrXOb_Click(object sender, EventArgs e)
        {
            frmReportePrXOb frm = new frmReportePrXOb();
            frm.ShowDialog();
        }
    }
}
