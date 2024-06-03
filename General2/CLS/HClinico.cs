using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace General2.CLS
{
    //probando el commit desde visual 
    internal class HClinico
    {
        String _IDHistorialClinico;
        String _IDPaciente;
        String _Afecciones;
        String _Observaciones;
        String _Estado;

        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string IDPaciente { get => _IDPaciente; set => _IDPaciente = value; }
        public string Afecciones { get => _Afecciones; set => _Afecciones = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string Estado { get => _Estado; set => _Estado = value; }


        public Boolean Insertar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO historial_clinicos (IDPaciente, Afecciones, Observaciones, Estado) 
                                    VALUES (@IDPaciente, @Afecciones, @Observaciones, @Estado)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDPaciente", IDPaciente);
                    command.Parameters.AddWithValue("@Afecciones", Afecciones);
                    command.Parameters.AddWithValue("@Observacoiones", Observaciones);
                    command.Parameters.AddWithValue("@Estado", Estado);

                    int filasInsertadas = command.ExecuteNonQuery();
                    if (filasInsertadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar historial clinico: " + ex.Message);
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
                    string query = @"UPDATE historial_clinicos 
                             SET IDPaciente = @IDPaciente, Afecciones = @Afecciones, Observaciones = @Observarciones,
                                 Estado = @Estado
                             WHERE IDHistorialClinico = @IDHistorialClinico";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDPaciente", IDPaciente);
                    command.Parameters.AddWithValue("@Afecciones", Afecciones);
                    command.Parameters.AddWithValue("@Observaciones", Observaciones);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar historial clinico: " + ex.Message);
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
                    string query = @"DELETE FROM historial_clinicos WHERE IDHistorialClinico = @IDHistorialClinico";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar historial clinico: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
