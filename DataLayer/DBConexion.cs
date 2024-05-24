using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DBConexion
    {
        private readonly string connectionString;

        String _CadenaConexion = "Server=localhost;Port=3306;Database=laboratoriodental;Uid=root;Pwd=root;AllowUserVariables=True;";
        protected MySqlConnection _CONEXION = new MySqlConnection();




        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                _CONEXION.ConnectionString = _CadenaConexion;
                _CONEXION.Open();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
