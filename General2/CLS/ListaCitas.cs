using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace General2.CLS
{
    internal class ListaCitas
    {
        string IDCita;
        string FechaCita;
        string IDPaciente;

        public string IDCita1 { get => IDCita; set => IDCita = value; }
        public string FechaCita1 { get => FechaCita; set => FechaCita = value; }
        public string IDPaciente1 { get => IDPaciente; set => IDPaciente = value; }

        public bool Insertar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO lista_citas (IDCita, FechaCita, IDPaciente) 
                                    VALUES (@IDCita, @FechaCita, @IDPaciente)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDCita", IDCita);
                    command.Parameters.AddWithValue("@FechaCita", FechaCita);
                    command.Parameters.AddWithValue("@IDPaciente", IDPaciente);

                    int filasInsertadas = command.ExecuteNonQuery();
                    if (filasInsertadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar lista citas: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }


        public Boolean Actualizar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE lista_citas 
                             SET IDDireccion = @IDDireccion, IDCargo = @IDCargo, IDPermiso = @IDPermiso,
                                 Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, 
                                 Correo = @Correo, Direccion = @Direccion, Puesto = @Puesto, 
                                 Sexo = @Sexo, Estado = @Estado
                             WHERE IDEmpleado = @IDEmpleado";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDDireccion", IDCita);
                    command.Parameters.AddWithValue("@IDCargo", FechaCita);
                    command.Parameters.AddWithValue("@IDPermiso", IDPaciente);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar lista citas: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }

        public Boolean Eliminar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM lista_citas WHERE IDCita = @IDCita";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDCita", IDCita);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar lista citas: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
