using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisBclinica.GUI
{
    public partial class Login : Form
    {

        SessionManager.Class1 oSesion = SessionManager.Class1.Instancia;
        Boolean _Autorizado = false;
        public bool Autorizado { get => _Autorizado; }
        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (oSesion.IniciarSesion(txtUsuario.Text, txtClave.Text))
            {
                _Autorizado = true;
                DataLayer.SesionesUsuario sesion = new DataLayer.SesionesUsuario
                {
                    IDEmpleados = oSesion.IDUsuario,
                    IDUsuarios = oSesion.IDUsuario,
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                sesion.Insertar_1();

                Close();
            }
            else
            {
                _Autorizado = false;
                lblMensaje.Text = "USUARIO O CLAVE INCORRECTOS";
                txtClave.Focus();
                txtClave.SelectAll();
            }

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtClave.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtClave.PasswordChar= '*';
        }
    }
}
