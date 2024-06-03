using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
/*
IDCitas int AI PK 
IDHistorialClinico int 
Estado enum('Pendiente','Completada','Cancelada') 
Nota varchar(255) 
FechaCita date 
HoraCita
*/
namespace General2.CLS
{
    internal class infoCitas
    {
        String _IDCitas;
        String _IDHistorialClinico;
        String _Estado;
        String _Nota;
        String _FechaCita;
        String _HoraCita;

        public string IDCitas { get => _IDCitas; set => _IDCitas = value; }
        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public string FechaCita { get => _FechaCita; set => _FechaCita = value; }
        public string HoraCita { get => _HoraCita; set => _HoraCita = value; }

        public Boolean Insertar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO citas (IDHistorialClinico, Estado, Nota, FechaCita, HoraCita) 
                                    VALUES (@IDHistorialClinico, @Estado, @Nota, @FechaCita, @HoraCita)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Nota", Nota);
                    command.Parameters.AddWithValue("@FechaCita", FechaCita);
                    command.Parameters.AddWithValue("@HoraCita", HoraCita);

                    int filasInsertadas = command.ExecuteNonQuery();
                    if (filasInsertadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar citas: " + ex.Message);
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
                    string query = @"UPDATE citas 
                             SET IDHistorialClinico = @IDHistorialClinico, Estado = @Estado, Nota = @Nota,
                                 FechaCita = @FechaCita, HoraCita = @HoraCita
                             WHERE IDCitas = @IDCitas";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Nota", Nota);
                    command.Parameters.AddWithValue("@FechaCita", FechaCita);
                    command.Parameters.AddWithValue("@HoraCita", HoraCita);
                    command.Parameters.AddWithValue("@IDCitas", IDCitas);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar citas: " + ex.Message);
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
                    string query = @"DELETE FROM citas WHERE IDCitas = @IDCitas";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDCitas", IDCitas);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar citas: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
