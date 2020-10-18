using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Consultorio.GUILayer;
using Consultorio.Entities;
using System.Runtime.InteropServices;
using Consultorio.GUILayer.Usuario;

namespace Consultorio
{
    public partial class frmPrincipal : Form
    {
        //Campos
        private IconButton btnActual;
        private Panel btnBordeIzq;
        private Form formHijoActual;
        UsuarioE usuarioActual;

        public frmPrincipal()
        {
            InitializeComponent();
            btnBordeIzq = new Panel();
            btnBordeIzq.Size = new Size(7, 40);
            pnlMenu.Controls.Add(btnBordeIzq);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Estructura del color
        private struct colorRGB
        {
            public static Color color1 = Color.FromArgb(27, 75, 66);
            public static Color color2 = Color.FromArgb(224, 245, 239);
        }
        //Metodos para diseño
        private void activarBtn(object btnllegada, Color color)
        {
            if(btnllegada != null)
            {
                desactivarBtn();
                btnActual = (IconButton)btnllegada;
                btnActual.BackColor = Color.FromArgb(26, 188, 156);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //Boton del borde Izquierdo
                btnBordeIzq.BackColor = color;
                btnBordeIzq.Location = new Point(0, btnActual.Location.Y);
                btnBordeIzq.Visible = true;
                btnBordeIzq.BringToFront();
                //Icono del Form hijo actual
                btnActualFromHijo.IconChar = btnActual.IconChar;
                btnActualFromHijo.IconColor = color;
 
            }
        }

        private void desactivarBtn()
        {
            if(btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(46, 177, 159);
                btnActual.ForeColor = colorRGB.color2;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = colorRGB.color2;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void abrirFormHijo(Form formHijo)
        {
            if(formHijoActual != null)
            {
              //Para abrir un solo form
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlInicio.Controls.Add(formHijo);
            pnlInicio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            lblTituloFormHijo.Text = btnActual.Text;
            lblTituloFormHijo.ForeColor = colorRGB.color1;
            
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            usuarioActual = fl.Usr;
            if (usuarioActual != null)
            {
                btnInicioSesion.Text = usuarioActual.Nombre_usuario;
                btnInicioSesion.Enabled = false;
                btnInicioSesion.IconColor = colorRGB.color1;
                btnInicioSesion.ForeColor = colorRGB.color1;
                habilitar(true);

            }

            fl.Dispose();
        }


        private void habilitar(bool x)
        {
            btnConsulta.Enabled = btnTurno.Enabled = btnPacientes.Enabled = btnUsuarios.Enabled = btnInsumos.Enabled = btnObrasSociales.Enabled = btnProfesionales.Enabled = btnPractica.Enabled = btnReportes.Enabled =  x;   
        }


        private void btnPacientes_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmPaciente());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            habilitar(false);
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmRegistrarConsulta());
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmRegistrarTurno());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmUsuario());
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmProfesional());
        }

        private void btnPractica_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmPractica());
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmInsumo());
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmAbmObraSocial());
        }

        private void Reset()
        {
            desactivarBtn();
            btnBordeIzq.Visible = false;
            //Icono del Form hijo actual
            btnActualFromHijo.IconChar = IconChar.Home;
            btnActualFromHijo.IconColor = colorRGB.color2;
            lblTituloFormHijo.Text = "Inicio";
            lblTituloFormHijo.ForeColor = colorRGB.color2;
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            formHijoActual.Close();
            Reset();
        }

        //Metodo de aarastre del form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitulobarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorRGB.color1);
            abrirFormHijo(new frmReportes());
        }
    }
}
