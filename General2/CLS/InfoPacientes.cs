using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 IDPaciente int AI PK 
IDDireccion int 
Nombres varchar(255) 
Apellidos varchar(255) 
Telefono varchar(20) 
Correo varchar(255) 
Direccion varchar(255) 
FechaNacimiento date 
Sexo enum('Masculino','Femenino') 
Estado enum('Activo','Inactivo') 
IDTratamiento
 */

namespace General2.CLS
{
    internal class InfoPacientes
    {
        String _IDDireccion;
        String _Nombres;
        String _Apellidos;
        String _Telefono;
        String _Correo;
        String _Direccion;
        String _FechaNacimiento;
        String _Sexo;
        String _Estado;
        String _IDtratamiento;

        public string IDpaciente { get; set; }
        public string IDDireccion { get => _IDDireccion; set => _IDDireccion = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IDtratamiento { get => _IDtratamiento; set => _IDtratamiento = value; }


        public bool Insertar()
        {
            bool resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=nombre_basedatos;Uid=root;Pwd=contraseña;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO pacientes (IDDireccion, Nombres, Apellidos, Telefono, Correo, Direccion, FechaNacimiento, Sexo, Estado, IDTratamiento) 
                            VALUES (@IDDireccion, @Nombres, @Apellidos, @Telefono, @Correo, @Direccion, @FechaNacimiento, @Sexo, @Estado, @IDTratamiento)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDDireccion", IDDireccion);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@IDTratamiento", IDtratamiento);

                    int filasInsertadas = command.ExecuteNonQuery();
                    resultado = (filasInsertadas > 0);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar paciente.", ex);
            }

            return resultado;
        }
        public Boolean Actualizar()
        {
            Boolean resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=nombre_basedatos;Uid=root;Pwd=contraseña;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE pacientes 
                             SET IDDireccion = @IDDireccion, 
                                 Nombres = @Nombres, 
                                 Apellidos = @Apellidos, 
                                 Telefono = @Telefono, 
                                 Correo = @Correo, 
                                 Direccion = @Direccion, 
                                 FechaNacimiento = @FechaNacimiento, 
                                 Sexo = @Sexo, 
                                 Estado = @Estado, 
                                 IDTratamiento = @IDTratamiento
                             WHERE IDPaciente = @IDPaciente";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDDireccion", IDDireccion);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@IDPaciente", IDpaciente);

                    int filasActualizadas = command.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar paciente: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }




        public Boolean Eliminar()
        {
            Boolean resultado = false;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=nombre_basedatos;Uid=root;Pwd=contraseña;AllowUserVariables=True;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM tabla_tratamientos WHERE IDTratamiento = @IDTratamiento";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDPaciente", IDpaciente);

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
