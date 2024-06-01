using General2.CLS;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace General2.GUI
{
    public partial class InfoEmpleado : Form
    {
        private empleado nuevoEmpleado = new empleado();

        public InfoEmpleado()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.InfoEmpleado_Load);
        }

        private DataTable ObtenerEmpleados()
        {
            DataTable empleados = new DataTable();

            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT IDEmpleado, Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo FROM empleados";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(empleados);
                }
            }

            return empleados;
        }

        private void InfoEmpleado_Load(object sender, EventArgs e)
        {
            DGInfoEmpleado.DataSource = ObtenerEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoEmpleado.Nombres = tbNombres.Text;
            nuevoEmpleado.Apellidos = tbApellidos.Text;
            nuevoEmpleado.Telefono = tbCelular.Text;
            nuevoEmpleado.Correo = tbCorreo.Text;
            nuevoEmpleado.Direccion = tbDireccion.Text;
            nuevoEmpleado.Puesto = cbPuesto.SelectedItem.ToString();
            nuevoEmpleado.Sexo = cbSexo.SelectedItem.ToString();
            nuevoEmpleado.Estado =cbEstado.SelectedItem.ToString();

            bool resultado = nuevoEmpleado.Insertar();

            if (resultado)
            {
                MessageBox.Show("Empleado insertado correctamente");
                DGInfoEmpleado.DataSource = ObtenerEmpleados(); // Actualizar DataGridView
            }
            else
            {
                MessageBox.Show("Error al insertar el empleado");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DGInfoEmpleado.SelectedRows.Count > 0)
            {
                string idEmpleado = DGInfoEmpleado.SelectedRows[0].Cells["IDEmpleado"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(tbNombres.Text) && !string.IsNullOrWhiteSpace(tbApellidos.Text))
                {
                    // Actualizar los datos del empleado
                    nuevoEmpleado.IDEmpleado = idEmpleado;
                    nuevoEmpleado.Nombres = tbNombres.Text;
                    nuevoEmpleado.Apellidos = tbApellidos.Text;
                    nuevoEmpleado.Telefono = tbCelular.Text;
                    nuevoEmpleado.Correo = tbCorreo.Text;
                    nuevoEmpleado.Direccion = tbDireccion.Text;
                    nuevoEmpleado.Puesto = cbPuesto.SelectedItem.ToString();
                    nuevoEmpleado.Sexo = cbSexo.SelectedItem.ToString();

                    bool resultado = nuevoEmpleado.Actualizar();

                    if (resultado)
                    {
                        MessageBox.Show("Empleado modificado correctamente");
                        DGInfoEmpleado.DataSource = ObtenerEmpleados(); // Actualizar DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el empleado");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGInfoEmpleado.SelectedRows.Count > 0)
            {
                string idEmpleado = DGInfoEmpleado.SelectedRows[0].Cells["IDEmpleado"].Value.ToString();

                nuevoEmpleado.IDEmpleado = idEmpleado;

                bool resultado = nuevoEmpleado.Eliminar();

                if (resultado)
                {
                    MessageBox.Show("Empleado eliminado correctamente");
                    DGInfoEmpleado.DataSource = ObtenerEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el empleado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }
        }
            private void DGInfoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
