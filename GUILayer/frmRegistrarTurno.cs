using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio.Entities;
using Consultorio.BussinessLayer;

namespace Consultorio.GUILayer
{
    public partial class frmRegistrarTurno : Form
    {
        TurnoService oTurnoService = new TurnoService();
        public frmRegistrarTurno()
        {
            InitializeComponent();
        }

        private void frmRegistrarTurno_Load(object sender, EventArgs e)
        {
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            addItems(coleccion);
            textBox1.AutoCompleteCustomSource = coleccion;
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            IList<Turno> lst = oTurnoService.recuperarTurnos();
            foreach (Turno X in lst)
            {
                col.Add(X.ToString());
            }
        }
    }
}
