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
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
        }
        private void cronometro_Tick(object sender, EventArgs e)
        {

            cronometro.Stop();
            Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            cronometro.Start();
        }

       
    }
}
