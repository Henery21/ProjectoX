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
        private empleado nuevoEmpleado = new empleado();
        public InfoEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoEmpleado.Nombres = tbNombres.Text;
            nuevoEmpleado.Apellidos = tbApellidos.Text;
            nuevoEmpleado.Telefono = tbCelular.Text;
            nuevoEmpleado.Correo = tbCorreo.Text;
            nuevoEmpleado.Direccion = tbDireccion.Text;
            nuevoEmpleado.Puesto = tbIdentidad.Text;
            nuevoEmpleado.Sexo = cbSexo.SelectedItem.ToString();
            // Llamar al método Insertar()
            bool resultado = nuevoEmpleado.Insertar();

            if (resultado)
            {
                MessageBox.Show("Empleado insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar el empleado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nuevoEmpleado.IDEmpleado = tbIdentidad.Text;

            bool resultado = nuevoEmpleado.Eliminar();

            if (resultado)
            {
                MessageBox.Show("Empleado eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado");
            };
        }

    }
}
