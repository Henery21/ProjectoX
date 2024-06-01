using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
IDEmpleado int AI PK 
IDDireccion int 
IDCargo int 
IDPermiso int 
Nombres varchar(255) 
Apellidos varchar(255) 
Telefono varchar(20) 
Correo varchar(255) 
Direccion varchar(255) 
Puesto varchar(255) 
Sexo enum('Masculino','Femenino') 
Estado
*/
namespace General2.CLS
{
    internal class empleado
    {
        private String _IDEmpleado;
        private String _IDDireccion;
        private String _IDCargo;
        private String _IDPErmiso;
        private String _Nombres;
        private String _Apellidos;
        private String _Telefono;
        private String _Correo;
        private String _Direccion;
        private String _Puesto;
        String _Sexo;
        String _Estado;

        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string IDDireccion { get => _IDDireccion; set => _IDDireccion = value; }
        public string IDCargo { get => _IDCargo; set => _IDCargo = value; }
        public string IDPErmiso { get => _IDPErmiso; set => _IDPErmiso = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }



        public bool Insertar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Empleados (Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo, Estado) 
                                    VALUES (@Nombres, @Apellidos, @Telefono, @Correo, @Direccion, @Puesto, @Sexo, @Estado)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Puesto", Puesto);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
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
                Console.WriteLine("Error al insertar empleado: " + ex.Message);
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
                    string query = @"UPDATE Empleados 
                             SET IDDireccion = @IDDireccion, IDCargo = @IDCargo, IDPermiso = @IDPermiso,
                                 Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, 
                                 Correo = @Correo, Direccion = @Direccion, Puesto = @Puesto, 
                                 Sexo = @Sexo, Estado = @Estado
                             WHERE IDEmpleado = @IDEmpleado";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDDireccion", IDDireccion);
                    command.Parameters.AddWithValue("@IDCargo", IDCargo);
                    command.Parameters.AddWithValue("@IDPermiso", IDPErmiso);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Puesto", Puesto);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
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
                Console.WriteLine("Error al actualizar empleado: " + ex.Message);
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
                    string query = @"DELETE FROM Empleados WHERE IDEmpleado = @IDEmpleado";
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
