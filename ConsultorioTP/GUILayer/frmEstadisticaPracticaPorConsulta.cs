using Consultorio.BussinessLayer;
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
    public partial class frmEstadisticaPracticaPorConsulta : Form
    {

        PracticaService oPracticaService = new PracticaService();

        public frmEstadisticaPracticaPorConsulta()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPracticaPorConsulta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cargarCombo(cboPractica, oPracticaService.recuperarPracticas(), "Nombre", "id_practica");
        }
        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
