using General2.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 tabla tratamientos
IDTratamiento int AI PK 
Tratamiento enum('Consulta','Seguimiento','Urgencia') 
Estado
*/
namespace General2.CLS
{
    internal class CTratamiento
    {
        String _IDTratamiento;
        String _Tratamiento;
        String _Estado;

        public string IDTratamiento { get => _IDTratamiento; set => _IDTratamiento = value; }
        public string Tratamiento { get => _Tratamiento; set => _Tratamiento = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;

            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;"))
                {
                    string consulta = "INSERT INTO tratamientos (Tratamiento, Estado) VALUES (@Tratamiento, @Estado)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tratamiento", _Tratamiento);
                        comando.Parameters.AddWithValue("@Estado", _Estado);

                        conexion.Open();

                       int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            resultado = true;
                        }
                    }
                }
 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el tratamiento: " + ex.Message);
            }

            return resultado;
        }
        public Boolean Actualizar()
        {
            Boolean resultado = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;"))
                {
                    string consulta = "UPDATE laboratoriodental.tratamientos SET Tratamiento = @Tratamiento, Estado = @Estado WHERE IDTratamiento = @IDTratamiento;\r\n";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tratamiento", _Tratamiento);
                        comando.Parameters.AddWithValue("@Estado", _Estado);
                        comando.Parameters.AddWithValue("@IDTratamiento", _IDTratamiento);

                        conexion.Open();

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el tratamiento: " + ex.Message);
            }

            return resultado;
        }

        public Boolean Eliminar()
        { Boolean resultado = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;"))
                {
                    string consulta = "DELETE FROM laboratoriodental.tratamientos WHERE IDTratamiento = @IDTratamiento";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDTratamiento", _IDTratamiento);

                        conexion.Open();

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tratamiento: " + ex.Message);
            }

            return resultado;
        }
    }
}
