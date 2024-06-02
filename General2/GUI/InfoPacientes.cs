using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General2.GUI
{
    public partial class InfoPacientes : Form
    {
        
        public InfoPacientes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            HistorialClinico f = new HistorialClinico();
            f.ShowDialog();
        }

        private void btnHistorialConsulta_Click(object sender, EventArgs e)
        {
            HistorialConsulta f = new HistorialConsulta();
            f.ShowDialog();
        }
    }
}
