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
        public frmEstadisticasPracticasMes()
        {
            InitializeComponent();
        }

        private void frmEstadisticasPracticasMes_Load(object sender, EventArgs e)
        {
            dptFecha.Value = DateTime.Today;
            this.rpPracticasMes.RefreshReport();
        }
    }
}
