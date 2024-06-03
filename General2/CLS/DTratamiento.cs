using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 IDTratamiento int 
DuracionT varchar(100) 
Precio decimal(10,2) 
Indicacion varchar(255) 
Estado
*/
namespace General2.CLS
{
    internal class DTratamiento
    {
        String _IDTratamiento;
        String _DuracionT;
        decimal _Precio;
        String _Indicacion;
        String _Estado;

        public string IDTratamiento { get => _IDTratamiento; set => _IDTratamiento = value; }
        public string DuracionT { get => _DuracionT; set => _DuracionT = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public string Indicacion { get => _Indicacion; set => _Indicacion = value; }
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
                    string query = @"INSERT INTO detalle_tratamientos (DuracionT, Precio, Indicacion, Estado) 
                                    VALUES (@DuracionT, @Precio, @Indicacion, @Estado)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DuracionT", DuracionT);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Indicacion", Indicacion);
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
                Console.WriteLine("Error al insertar tratamiento: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
        public Boolean Actualizar()
        {
            Boolean resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE detalle_tratamientos 
                                    SET DuracionT = @DuracionT, Precio = @Precio, Indicacion = @Indicacion, Estado = @Estado 
                                    WHERE IDTratamiento = @IDTratamiento";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DuracionT", DuracionT);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Indicacion", Indicacion);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@IDTratamiento", IDTratamiento);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar tratamiento: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }

        public Boolean Eliminar()
        {
            Boolean resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM detalle_tratamientos WHERE IDTratamiento = @IDTratamiento";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDTratamiento", IDTratamiento);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar tratamiento: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
