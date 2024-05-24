using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace General2.CLS
{
    internal class HClinico
    {
        String _IDHistorialClinico;
        String _IDPaciente;
        String _Afecciones;
        String _Observaciones;
        String _Estado;

        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string IDPaciente { get => _IDPaciente; set => _IDPaciente = value; }
        public string Afecciones { get => _Afecciones; set => _Afecciones = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string Estado { get => _Estado; set => _Estado = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {
                //FALTA CONSULTA PEDIR AL MORRO QUE HIZO LA DB
                Sentencia = @"INSERT INTO productos * VALUES('" + _IDHistorialClinico + "','" + _IDPaciente + "','" + _Afecciones + "','" + _Observaciones + "','" + _Estado + "'); ";
                DataLayer.DBoperacion Operacion = new DataLayer.DBoperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
                //CONTIANCION 

            }
            catch (Exception)
            {

                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasActualizadas = 0;

            try
            {
                Sentencia = @"";
            }
            catch (Exception)
            {

                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;

            try
            {
                Sentencia = @"";
                if (true)
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
