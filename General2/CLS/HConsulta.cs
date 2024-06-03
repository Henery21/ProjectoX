using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

/*
IDConsulta int AI PK 
IDHistorialClinico int 
Motivo_Consulta varchar(255) 
Observaciones varchar(255) 
IDEmpleado int 
Estado
*/
namespace General2.CLS
{
    internal class HConsulta
    {
        String _IDConsulta;
        String _IDHistorialClinico;
        String _MotivoConsulta;
        String _Observaciones;
        String _IDEmpleado;
        String _Estado;

        public string IDConsulta { get => _IDConsulta; set => _IDConsulta = value; }
        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string MotivoConsulta { get => _MotivoConsulta; set => _MotivoConsulta = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
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
                    string query = @"INSERT INTO historial_consultas (IDHistorialClinico, MotivoConsulta, Observaciones, IDEmpleado, Estado) 
                                    VALUES (@IDHistorialClinico, @MotivoConsulta, @Observaciones, @IDEmpleado, @Estado)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);
                    command.Parameters.AddWithValue("@MotivoConsulta", MotivoConsulta);
                    command.Parameters.AddWithValue("@Observaciones", Observaciones);
                    command.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
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
                Console.WriteLine("Error al insertar consultas: " + ex.Message);
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
                    string query = @"UPDATE historial_consultas 
                             SET IDHistorialClinico = @IDHistorialClinico, MotivoConsulta = @MotivoConsulta, Observaciones = @Observaciones,
                                 IDEmpleado = @IDEmpleado, Estado = @Estado
                             WHERE IDConsulta = @IDConsulta";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHistorialClinico", IDHistorialClinico);
                    command.Parameters.AddWithValue("@MotivoConsulta", MotivoConsulta);
                    command.Parameters.AddWithValue("@Observaciones", Observaciones);
                    command.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar consultas: " + ex.Message);
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
                    string query = @"DELETE FROM historial_consultas WHERE IDConsulta = @IDConsulta";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDConsulta", IDConsulta);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar consulta: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
