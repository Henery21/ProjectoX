using System;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DBoperacion : DBConexion
    {
        public Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            MySqlCommand Comando = new MySqlCommand();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pSentencia;
                try
                {
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("ERROR: " + e.Message);
                    FilasAfectadas = -1;
                }
                base.Desconectar();
            }
            return FilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)
        {
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            MySqlCommand Comando = new MySqlCommand();
            DataTable Resultado = new DataTable();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pConsulta;
                Adaptador.SelectCommand = Comando;
                try
                {
                    Adaptador.Fill(Resultado);
                }
                catch (Exception)
                {
                    Resultado = new DataTable();
                }
                base.Desconectar();
            }
            return Resultado;
        }

        public Int32 EjecutarSentenciaConReturnId(String pSentencia)
        {
            Int32 idRetornado = 0;
            MySqlCommand Comando = new MySqlCommand();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pSentencia;
                try
                {
                    Comando.ExecuteNonQuery();
                    idRetornado = (int)Comando.LastInsertedId;

                }
                catch (Exception e)
                {
                    Debug.WriteLine("ERROR: " + e.Message);
                    idRetornado = -1;
                }
                base.Desconectar();
            }
            return idRetornado;
        }

    }
}
