using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SesionesUsuario
    {
        String _IDUsuario;
        String _IDUsuarios;
        String _IDEmpleados;
        String _Fecha;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string IDUsuarios { get => _IDUsuarios; set => _IDUsuarios = value; }
        public string IDEmpleados { get => _IDEmpleados; set => _IDEmpleados = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }

        public Boolean Insertar_1()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO sesionesusuario (IDEmpleados, IDUsuarios, Fecha) VALUES('" + _IDEmpleados + "','" + _IDUsuarios + "','" + _Fecha + "');";
                DataLayer.DBoperacion Operacion = new DataLayer.DBoperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
