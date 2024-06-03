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
    public partial class ListaCitas : Form
    {
        public ListaCitas()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.ListaCitas_Load);

        }
        private DataTable ObtenerLista()
        {
            DataTable ListaCitas = new DataTable();

            string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT IDTratamiento, Tratamiento, Estado FROM laboratoriodental.tratamientos";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(ListaCitas);
                }
            }

            return ListaCitas;
        }

        private void ListaCitas_Load(object sender, EventArgs e)
        {
            DGListaCitas.DataSource = ObtenerLista();
        }
    }
}
