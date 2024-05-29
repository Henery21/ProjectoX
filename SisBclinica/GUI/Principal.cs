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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AbrirFhijo(Object formhijo)
        {
            if (this.plPrincipal.Controls.Count > 0)
                this.plPrincipal.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.plPrincipal.Controls.Add(fh);
            this.plPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFhijo(new General2.GUI.InfoEmpleado());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFhijo(new General2.GUI.InfoUsuario());
        }

        private void btnTratamiento_Click(object sender, EventArgs e)
        {
            AbrirFhijo(new General2.GUI.Detalletratamiento());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFhijo(new General2.GUI.InfoPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFhijo(new General2.GUI.ListaCitas());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
