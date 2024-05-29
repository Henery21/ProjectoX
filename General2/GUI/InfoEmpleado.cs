using General2.CLS;
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
    public partial class InfoEmpleado : Form
    {
        public InfoEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            empleado.Insertar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            empleado.Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           empleado.Eliminar();
        }
    }
}
