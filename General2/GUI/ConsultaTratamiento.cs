using General2.CLS;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace General2.GUI
{
    public partial class ConsultaTratamiento : Form
    {
        private CTratamiento nuevoTratamiento= new CTratamiento();
        public ConsultaTratamiento()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ConsultaTratamiento_Load);
        }

        private DataTable ObtenerTratamientos()
        {
            DataTable CTratamiento = new DataTable();

            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT IDEmpleado, Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo FROM empleados";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(CTratamiento);
                }
            }

            return CTratamiento;
        }

        private void ConsultaTratamiento_Load(object sender, EventArgs e)
        {
            DGConsultaTratamiento.DataSource = ObtenerTratamientos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoTratamiento.Tratamiento=cbTratamiento.SelectedItem.ToString();
            nuevoTratamiento.Estado=cbEstado.SelectedItem.ToString();
            bool resultado = nuevoTratamiento.Insertar();

            if (resultado)
            {
                MessageBox.Show("Empleado insertado correctamente");
                DGConsultaTratamiento.DataSource = ObtenerTratamientos(); // Actualizar DataGridView
            }
            else
            {
                MessageBox.Show("Error al insertar el empleado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DGConsultaTratamiento.SelectedRows.Count > 0)
            {
                string idEmpleado = DGConsultaTratamiento.SelectedRows[0].Cells["IDTratamiento"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(cbTratamiento.SelectedItem.ToString()) && !string.IsNullOrWhiteSpace(cbEstado.SelectedItem.ToString()))
                {
                    // Actualizar los datos del empleado
                    nuevoTratamiento.IDTratamiento = idTratamiento;
                    nuevoTratamiento.Tratamiento = cbTratamiento.SelectedItem.ToString();
                    nuevoTratamiento.Estado = cbEstado.SelectedItem.ToString();

                    bool resultado = nuevoTratamiento.Actualizar();

                    if (resultado)
                    {
                        MessageBox.Show("Tratamiento modificado correctamente");
                        DGConsultaTratamiento.DataSource = ObtenerTratamientos(); // Actualizar DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el tratamiento");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tratamiento para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGConsultaTratamiento.SelectedRows.Count > 0)
            {
                string idEmpleado = DGConsultaTratamiento.SelectedRows[0].Cells["IDTratamiento"].Value.ToString();

                nuevoTratamiento.IDTratamiento = idTratamiento;

                bool resultado = nuevoTratamiento.Eliminar();

                if (resultado)
                {
                    MessageBox.Show("Tratamiento eliminado correctamente");
                    DGConsultaTratamiento.DataSource = ObtenerTratamientos();
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
        private void DGConsultaTratamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
