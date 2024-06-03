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
    public partial class InfoCita : Form
    {
        public InfoCita()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.InfoCitas_Load);
        }
        
        private DataTable ObtenerCitas()
        {
            DataTable infoCitas = new DataTable();
            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT IDEmpleado, Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo FROM empleados";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(infoCitas);
                }
            }

            return infoCitas;
        }

        private void InfoCitas_Load(object sender, EventArgs e)
        {
            DGInfiCita.DataSource = ObtenerCitas();
        }
    }
}
