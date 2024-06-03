using General2.CLS;
using MySql.Data.MySqlClient;
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
    public partial class Detalletratamiento : Form
    {
        public Detalletratamiento()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.infoDTratamiento_Load);
        }
        private DataTable ObtenerDtratamiento()
        {
            DataTable DTratamiento = new DataTable();
            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM laboratoriodental.detalle_tratamientos;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(DTratamiento);
                }
            }

            return DTratamiento;
        }

        private void infoDTratamiento_Load(object sender, EventArgs e)
        {
            DGdetalleTratamiento.DataSource = ObtenerDtratamiento();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDuracion.Text) &&
                  !string.IsNullOrEmpty(txtPrecio.Text) &&
                  !string.IsNullOrEmpty(txtIndicacion.Text) &&
                  cbEstado.SelectedItem != null)
            {
                try
                {
                    // Obtener los valores ingresados por el usuario
                    string duracion = txtDuracion.Text;
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    string indicacion = txtIndicacion.Text;
                    string estado = cbEstado.SelectedItem.ToString();

                    // Crear una instancia de la clase DTratamiento
                    DTratamiento tratamiento = new DTratamiento();

                    // Asignar los valores al tratamiento antes de insertar
                    tratamiento.DuracionT = duracion;
                    tratamiento.Precio = precio;
                    tratamiento.Indicacion = indicacion;
                    tratamiento.Estado = estado;

                    // Intentar insertar el tratamiento
                    bool resultado = tratamiento.Insertar();

                    // Verificar el resultado de la inserción y mostrar un mensaje adecuado
                    if (resultado)
                    {
                        MessageBox.Show("Tratamiento agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el tratamiento");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DGdetalleTratamiento.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow fila = DGdetalleTratamiento.SelectedRows[0];

                    // Obtener los valores de la fila seleccionada
                    string idTratamiento = fila.Cells["IDTratamiento"].Value.ToString();
                    string duracion = fila.Cells["DuracionT"].Value.ToString();
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    string indicacion = fila.Cells["Indicacion"].Value.ToString();
                    string estado = fila.Cells["Estado"].Value.ToString();

                    // Crear una instancia de la clase DTratamiento
                    DTratamiento tratamiento = new DTratamiento();

                    // Asignar los valores al tratamiento antes de actualizar
                    tratamiento.IDTratamiento = idTratamiento;
                    tratamiento.DuracionT = duracion;
                    tratamiento.Precio = precio;
                    tratamiento.Indicacion = indicacion;
                    tratamiento.Estado = estado;

                    // Intentar actualizar el tratamiento
                    bool resultado = tratamiento.Actualizar();

                    // Verificar el resultado de la actualización y mostrar un mensaje adecuado
                    if (resultado)
                    {
                        MessageBox.Show("Tratamiento modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el tratamiento");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGdetalleTratamiento.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow fila = DGdetalleTratamiento.SelectedRows[0];

                    // Obtener el ID del tratamiento de la fila seleccionada
                    string idTratamiento = fila.Cells["IDTratamiento"].Value.ToString();

                    // Crear una instancia de la clase DTratamiento
                    DTratamiento tratamiento = new DTratamiento();

                    // Asignar el ID del tratamiento a eliminar
                    tratamiento.IDTratamiento = idTratamiento;

                    // Intentar eliminar el tratamiento
                    bool resultado = tratamiento.Eliminar();

                    // Verificar el resultado de la eliminación y mostrar un mensaje adecuado
                    if (resultado)
                    {
                        MessageBox.Show("Tratamiento eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el tratamiento");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
    }
}
