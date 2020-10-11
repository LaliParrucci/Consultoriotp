using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.GUILayer.Informes
{
    public partial class frmListadoTurnosDiarios : Form
    {
        DateTime fecha;
        public frmListadoTurnosDiarios()
        {
            InitializeComponent();
        }

        private void frmListadoTurnosDiarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTurnosDiario.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.dsTurnosDiario.DataTable1, DateTime.Today.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // VER COMO HACER PARA NO MOSTRAR TURNOS VACIOS
            if (this.DataTable1TableAdapter.Fill(this.dsTurnosDiario.DataTable1, dtpFecha.Value.Date.ToShortDateString())!= null)
            {
                this.DataTable1TableAdapter.Fill(this.dsTurnosDiario.DataTable1, dtpFecha.Value.Date.ToShortDateString());

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay turnos para la fecha seleccionada", "Sin turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
