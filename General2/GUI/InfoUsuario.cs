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
        private InfoUsuario nuevoUser = new InfoUsuario();
        public InfoUsuario()
        {
            InitializeComponent();
    ///datatgrid no se que hiciste XD 

///            this.Load += new System.EventHandler(this);
        }
        private DataTable ObtenerUsers()
        {
            DataTable empleados = new DataTable();

            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //falta consulta
                string query = "";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(empleados);
                }
            }

            return empleados;
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            DGInfoUsuario.DataSource = ObtenerUsers();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
