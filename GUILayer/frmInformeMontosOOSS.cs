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
    public partial class frmInformeMontosOOSS : Form
    {
        public frmInformeMontosOOSS()
        {
            InitializeComponent();
        }

        private void frmInformeMontosOOSS_Load(object sender, EventArgs e)
        {

            this.rptMontosOOSS.RefreshReport();
        }

        private void rptMontosOOSS_Load(object sender, EventArgs e)
        {

        }
    }
}
