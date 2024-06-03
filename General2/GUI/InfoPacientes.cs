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
    public partial class InfoPacientes : Form
    {
        
        public InfoPacientes()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.InfoPacientes_Load);
        }

        private DataTable ObtenerPacientes()
        {
            DataTable InfoPacientes = new DataTable();
            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM laboratoriodental.pacientes;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(InfoPacientes);
                }
            }

            return InfoPacientes;
        }

        private void InfoPacientes_Load(object sender, EventArgs e)
        {
            DGInfoPaciente.DataSource = ObtenerPacientes();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }
    }
}
