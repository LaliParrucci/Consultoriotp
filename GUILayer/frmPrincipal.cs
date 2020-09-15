using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.GUILayer;
using Consultorio.Entities;

namespace Consultorio
{
    public partial class frmPrincipal : Form
    {
        Usuario usuarioActual; 

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            usuarioActual = fl.Usr;
            if (usuarioActual != null)
            {
                iniciarSesiónToolStripMenuItem.Text = usuarioActual.Nombre_usuario;
                iniciarSesiónToolStripMenuItem.Enabled = false;
                habilitar(true);
            }

            fl.Dispose();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void habilitar(bool x)
        {
            btnConsulta.Enabled = btnPacientes.Enabled = btnTurno.Enabled = btnUsuarios.Enabled = x;   
        }


        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmAbmPaciente fp = new frmAbmPaciente();
            fp.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            habilitar(false);
        }

        private void mspInicio_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
