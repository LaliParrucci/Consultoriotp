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
    public partial class frmReportePXO : Form
    {
        public frmReportePXO()
        {
            InitializeComponent();
        }

        private void frmReportePXO_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
