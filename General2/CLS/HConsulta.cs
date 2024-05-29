using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        String _IdConculta;
        String _IDHistorialClinico;
        String _MotivoConsulta;
        String _IDEmpleado;
        String _Estado;

        public string IdConculta { get => _IdConculta; set => _IdConculta = value; }
        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string MotivoConsulta { get => _MotivoConsulta; set => _MotivoConsulta = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Estado { get => _Estado; set => _Estado = value; }


        public Boolean Insertar()
        {
            Boolean resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {
                //FALTA CONSULTA PEDIR AL MORRO QUE HIZO LA DB
                Sentencia = @" ";
                DataLayer.DBoperacion Operacion = new DataLayer.DBoperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {

                resultado = false;
            }
            return resultado;
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
