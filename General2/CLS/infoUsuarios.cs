using DataLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

/*
IDUsuario int AI PK 
IDRol int 
IDEmpleado int 
NomCompleto varchar(255) 
Usuario varchar(100) 
Clave varchar(255) 
TipoUsuario enum('Administrador','Doctor','Recepcionista') 
Estado enum('Activo','Inactivo') 
*/
namespace General2.CLS
{
    internal class infoUsuarios
    {
        String _IDUsuario;
        String _IDRol;
        String _IDEmpleado;
        String _NomCompleto;
        String _Usuario;
        String _Clave;
        String _TipoUsuario;
        String _Estado;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string NomCompleto { get => _NomCompleto; set => _NomCompleto = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
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
                    string consulta = "INSERT INTO tabla_usuarios (IDRol, IDEmpleado, NomCompleto, Usuario, Clave, TipoUsuario, Estado) " +
                                       "VALUES (@IDRol, @IDEmpleado, @NomCompleto, @Usuario, @Clave, @TipoUsuario, @Estado)";

                    // Crear y configurar el comando SQL
                    using (MySqlCommand comando = new MySqlCommand(consulta, connection))
                    {
                        // Agregar los parámetros necesarios
                        comando.Parameters.AddWithValue("@IDRol", _IDRol);
                        comando.Parameters.AddWithValue("@IDEmpleado", _IDEmpleado);
                        comando.Parameters.AddWithValue("@NomCompleto", _NomCompleto);
                        comando.Parameters.AddWithValue("@Usuario", _Usuario);
                        comando.Parameters.AddWithValue("@Clave", _Clave);
                        comando.Parameters.AddWithValue("@TipoUsuario", _TipoUsuario);
                        comando.Parameters.AddWithValue("@Estado", _Estado);

                        int filasInsertadas = comando.ExecuteNonQuery();
                        if (filasInsertadas > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar usuario: " + ex.Message);
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
                    //FAlta la consult
                    connection.Open();
                    string consulta = "INSERT INTO tabla_usuarios (IDRol, IDEmpleado, NomCompleto, Usuario, Clave, TipoUsuario, Estado) " +
                                       "VALUES (@IDRol, @IDEmpleado, @NomCompleto, @Usuario, @Clave, @TipoUsuario, @Estado)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@IDRol", _IDRol);
                        comando.Parameters.AddWithValue("@IDEmpleado", _IDEmpleado);
                        comando.Parameters.AddWithValue("@NomCompleto", _NomCompleto);
                        comando.Parameters.AddWithValue("@Usuario", _Usuario);
                        comando.Parameters.AddWithValue("@Clave", _Clave);
                        comando.Parameters.AddWithValue("@TipoUsuario", _TipoUsuario);
                        comando.Parameters.AddWithValue("@Estado", _Estado);

                        int filasInsertadas = comando.ExecuteNonQuery();
                        if (filasInsertadas > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar el  usuario: " + ex.Message);
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
                    string query = @"";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);

                    int filasEliminadas = command.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar empleado: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
