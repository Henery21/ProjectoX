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
    public partial class InfoUsuario : Form
    {

        public InfoUsuario()
        {
         InitializeComponent();
            this.Load += new EventHandler(this.infoUsuarios_Load);
        }

        private DataTable ObtenerUsers()
        {
            DataTable infoUsuarios = new DataTable();
            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM laboratoriodental.usuarios;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(infoUsuarios);
                }
            }

            return infoUsuarios;
        }

        private void infoUsuarios_Load(object sender, EventArgs e)
        {
            DGInfoUsuario.DataSource = ObtenerUsers();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIdRol.Text) &&
    !string.IsNullOrEmpty(tbNombreCompleto.Text) &&
    !string.IsNullOrEmpty(tbUsuario.Text) &&
    !string.IsNullOrEmpty(tbContraseña.Text) &&
    cbTpUsuario.SelectedItem != null &&
    cbEstado.SelectedItem != null)
            {
                // Crear una instancia de la clase infoUsuarios
                infoUsuarios nuevoUsuario = new infoUsuarios();

                // Asignar los valores de los campos a las propiedades de la instancia
                nuevoUsuario.IDRol = tbIdRol.Text;
                nuevoUsuario.NomCompleto = tbNombreCompleto.Text;
                nuevoUsuario.Usuario = tbUsuario.Text;
                nuevoUsuario.Clave = tbContraseña.Text;
                nuevoUsuario.TipoUsuario = cbTpUsuario.SelectedItem.ToString();
                nuevoUsuario.Estado = cbEstado.SelectedItem.ToString();

                // Llamar al método Insertar de la clase infoUsuarios para agregar el nuevo usuario
                bool resultado = nuevoUsuario.Insertar();

                // Verificar si se insertó correctamente y mostrar un mensaje adecuado
                if (resultado)
                {
                    MessageBox.Show("Usuario agregado correctamente");
//                    DGInfoUsuario.DataSource = ObtenerUsers(); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al agregar el usuario");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIdRol.Text) &&
        !string.IsNullOrEmpty(tbNombreCompleto.Text) &&
        !string.IsNullOrEmpty(tbUsuario.Text) &&
        !string.IsNullOrEmpty(tbContraseña.Text) &&
        cbTpUsuario.SelectedItem != null &&
        cbEstado.SelectedItem != null)
            {
                // Crear una instancia de la clase infoUsuarios
                infoUsuarios usuarioModificado = new infoUsuarios();

                // Asignar los valores de los campos a las propiedades de la instancia
                usuarioModificado.IDRol = tbIdRol.Text;
                usuarioModificado.NomCompleto = tbNombreCompleto.Text;
                usuarioModificado.Usuario = tbUsuario.Text;
                usuarioModificado.Clave = tbContraseña.Text;
                usuarioModificado.TipoUsuario = cbTpUsuario.SelectedItem.ToString();
                usuarioModificado.Estado = cbEstado.SelectedItem.ToString();

                // Llamar al método Actualizar de la clase infoUsuarios para modificar el usuario
                bool resultado = usuarioModificado.Actualizar();

                // Verificar si se modificó correctamente y mostrar un mensaje adecuado
                if (resultado)
                {
                    MessageBox.Show("Usuario modificado correctamente");
                    //DGInfoUsuario.DataSource = ObtenerUsers(); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al modificar el usuario");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGInfoUsuario.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado
                string idUsuario = DGInfoUsuario.SelectedRows[0].Cells["IDUsuario"].Value.ToString();

                // Crear una instancia de la clase infoUsuarios
                infoUsuarios usuarioAEliminar = new infoUsuarios();

                // Asignar el ID del usuario a eliminar
                usuarioAEliminar.IDUsuario = idUsuario;

                // Llamar al método Eliminar de la clase infoUsuarios para eliminar el usuario
                bool resultado = usuarioAEliminar.Eliminar();

                // Verificar si se eliminó correctamente y mostrar un mensaje adecuado
                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    //DGInfoUsuario.DataSource = ObtenerUsers(); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

    }
}
