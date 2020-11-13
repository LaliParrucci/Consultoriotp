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
        bool activoProfesional = false;
        TurnoService oTurnoService = new TurnoService();
        ProfesionalService oProfesionalService = new ProfesionalService();
        ObraSocialService oObraSocialService = new ObraSocialService();
        PacienteService oPacienteService = new PacienteService();
        Turno oTurno = new Turno();
        DisponibilidadService oDisponibilidadService = new DisponibilidadService();
        Disponibilidad oDisponibilidad = new Disponibilidad();
        ProfesionalE oProfesional = new ProfesionalE();
        frmAbmPaciente formPaciente;
        Turno turnoViejo;
        bool nuevo = false;
        bool modif = false;
        public frmRegistrarTurno()
        {
            InitializeComponent();
        }

        private void frmRegistrarTurno_Load(object sender, EventArgs e)
        {
            habilitar(true);
            LlenarCombo(cboObraSocial, oObraSocialService.recuperarObraSocial(), "nombre", "codigo");
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            List<ProfesionalE> lst = oProfesionalService.recuperarProfesionalPorNombre(txtNombreProfesional.Text);
            foreach (ProfesionalE X in lst)
            {
                col.Add(X.Apellido.ToString());
            }
        }

        public void habilitar(bool x)
        {
            txtApellidoProfesional.Enabled = txtFecha.Enabled = txtDni.Enabled = txtNombreProfesional.Enabled = txtObservaciones.Enabled = txtPaciente.Enabled = x;
        }

        public void autocompletar(TextBox otextBox)
        {
            otextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            otextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            addItems(coleccion);
            if (coleccion.Count != 0)
            {
                otextBox.AutoCompleteCustomSource = coleccion;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void activoAutocompletar(TextBox txt, bool bandera)
        {
            try
            {
                if (!bandera)
                {
                    autocompletar(txt);
                    bandera = true;
                }
            }catch(Exception e)
            {
                return;
            }
        }

      

        private void txtApellidoProfesional_Enter(object sender, EventArgs e)
        {
            activoAutocompletar(txtApellidoProfesional, activoProfesional);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PacienteE p = oPacienteService.recuperarPacientePorDni(Convert.ToInt32(this.txtDni.Text));
            if (p == null)
            {
                if (MessageBox.Show("No se encontró el paciente que busca, ¿desea registrarlo?", "Búsqueda no encontrada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //    txtApellidoPaciente.Text = txtNombrePaciente.Text = "";
                    formPaciente = new frmAbmPaciente(this.txtDni.Text);
                    formPaciente.ShowDialog();
                    p = oPacienteService.recuperarPacientePorDni(Convert.ToInt32(this.txtDni.Text));
                }
                else
                {
                    MessageBox.Show("No logró registrarse el turno", "Cancelación de turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtPaciente.Text = (p.Apellido + ", " + p.Nombre);
            txtPaciente.Enabled = false;

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (modif)
            {
                oTurno.Fecha = Convert.ToDateTime(txtFecha.Text);
                txtDni.Text = turnoViejo.Id_paciente.ToString();
                if (cboObraSocial.SelectedIndex == -1)
                {
                    cboObraSocial.Text = oObraSocialService.recuperarObraSocialPorCodigo(turnoViejo.Id_obra_social).Nombre;
                }
                oTurno.Id_profesional = oProfesional.Matricula;
                oTurno.Id_obra_social = (oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text)).Codigo;
                oTurno.Id_paciente = Convert.ToInt32(txtDni.Text);
                oTurno.Hora = grdTurnosDisp.CurrentRow.Cells["Hora"].Value.ToString();
                string disponible = "SÍ";
                if (oTurnoService.validarTurno(oTurno, disponible))
                {
                    if (oTurnoService.modificarTurnoConHistorialS(oTurno, txtObservaciones.Text, turnoViejo))
                    {
                        MessageBox.Show("Se modificó el turno", "Turno modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clickChBox();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema con la modificación del turno", "Error en modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            modif = false;
            btnRegistrar.Enabled = false;
        }

        public bool validarCampos()
        {
            if (txtNombreProfesional.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido para el profesional!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtApellidoProfesional.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido para el profesional!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboObraSocial.Text == "")
            {
                MessageBox.Show("Seleccione una obra social!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Seleccione una fecha!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese un DNI para el paciente!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPaciente.Text == "")
            {
                MessageBox.Show( "Ingrese un nombre válido para el paciente!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
       
        private void cargarGrilla(DataGridView grilla, IList<Entities.Disponibilidad> lista)
        {
            string disponible;
            grilla.Rows.Clear();
            foreach (Entities.Disponibilidad d in lista)
            {
                if (!d.Disponible) {
                    disponible = "NO";
                }
                else
                {
                    disponible = "SÍ";
                }
                grilla.Rows.Add(d.Fecha, d.Hora, d.Paciente, disponible);
                
            }
        }

        public void clickChBox()
        {
            if (chDisponibles.Checked)
            {
                cargarGrilla(grdTurnosDisp, oDisponibilidadService.recuperarTurnoDisp(oProfesional.Matricula.ToString(), Convert.ToDateTime(this.txtFecha.Text)));
            }
            else
            {
                cargarGrilla(grdTurnosDisp, oDisponibilidadService.recuperarTurno(oProfesional.Matricula.ToString(), Convert.ToDateTime(this.txtFecha.Text)));
            }
        }


        private void limpiarCampos()
        {
            cboObraSocial.SelectedIndex = -1;
            txtPaciente.Text = txtApellidoProfesional.Text = txtFecha.Text = txtDni.Text = txtNombreProfesional.Text = txtObservaciones.Text = "";
        }

        private void chDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            clickChBox();
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.txtFecha.Text = calendario.SelectionRange.Start.Date.ToShortDateString();
            List<ProfesionalE> ls = oProfesionalService.recuperarProfesionalPorNombre(txtNombreProfesional.Text);
            foreach (ProfesionalE p in ls)
            {
                if (p.Apellido == txtApellidoProfesional.Text)
                {
                    oProfesional = p;
                }
            }
            if (txtApellidoProfesional.Text == "" || txtNombreProfesional.Text == "")
            {
                MessageBox.Show("Ingrese el profesional que busca", "Seleccione profesional", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarCampos();
                return;
            }
            // int a = Convert.ToInt32((grdTurnosDisp.CurrentCell).ToString());
            chDisponibles.Enabled = true;
            clickChBox();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                turnoViejo = oTurnoService.getTurnoFechaHoraProfesional(Convert.ToDateTime(txtFecha.Text), grdTurnosDisp.CurrentRow.Cells["Hora"].Value.ToString(), oProfesional.Matricula);
                modif = true;
                habilitar(true);
                txtPaciente.Enabled = txtDni.Enabled = false;
                btnRegistrar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un turno para modificar", "Seleccione un turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text == "" || txtApellidoProfesional.Text == "" || txtNombreProfesional.Text == "")
            {
                MessageBox.Show("Debe seleccionar un turno para eliminar", "Seleccione un turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este turno?", "Atencion! Eliminacion de Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    try
                    {
                        List<ProfesionalE> ls = oProfesionalService.recuperarProfesionalPorNombre(txtNombreProfesional.Text);
                        foreach (ProfesionalE p in ls)
                        {
                            if (p.Apellido == txtApellidoProfesional.Text)
                            {
                                oProfesional = p;
                            }
                        }
                        if (grdTurnosDisp.CurrentRow.Cells["Disponible"].Value.ToString() == "NO")
                        {
                            oTurno = oTurnoService.getTurnoFechaHoraProfesional(Convert.ToDateTime(txtFecha.Text), grdTurnosDisp.CurrentRow.Cells["Hora"].Value.ToString(), oProfesional.Matricula);
                            if (oTurnoService.eliminarTurnoConHistorial(oTurno))
                            {
                                MessageBox.Show("Se eliminó el turno correctamente", "Turno eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema con la eliminación del turno", "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            limpiarCampos();
                            cargarGrilla(grdTurnosDisp, oDisponibilidadService.recuperarTurnoDisp(oProfesional.Matricula.ToString(), oTurno.Fecha));
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un turno ocupado para eliminarlo", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if((oTurnoService.recuperarTurnoFechaDni(Convert.ToDateTime(txtFecha.Text), txtDni.Text) != null))
                {
                    MessageBox.Show("El paciente ingresado ya tiene un turno asignado para la fecha seleccionada", "Turno no asignado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarCampos();
                    return;
                }
                oTurno.Fecha = Convert.ToDateTime(txtFecha.Text);
                oTurno.Id_profesional = oProfesional.Matricula;
                oTurno.Id_obra_social = (oObraSocialService.recuperarObraSocialPorNom(cboObraSocial.Text)).Codigo;
                oTurno.Id_paciente = Convert.ToInt32(txtDni.Text);
                oTurno.Hora = grdTurnosDisp.CurrentRow.Cells["Hora"].Value.ToString();
                string disponible = grdTurnosDisp.CurrentRow.Cells["Disponible"].Value.ToString();
                if (oTurnoService.validarTurno(oTurno, disponible))
                {
                    if (oTurnoService.crearTurnoConHistorial(oTurno, txtObservaciones.Text))
                    {
                        MessageBox.Show("Se registró el turno correctamente", "Turno registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clickChBox();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema con el registro de turno", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
