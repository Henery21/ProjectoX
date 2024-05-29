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
        String _Precio;
        String _Indicacion;
        String _Estado;

        public string IDTratamiento { get => _IDTratamiento; set => _IDTratamiento = value; }
        public string DuracionT { get => _DuracionT; set => _DuracionT = value; }
        public string Precio { get => _Precio; set => _Precio = value; }
        public string Indicacion { get => _Indicacion; set => _Indicacion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {
                //FALTA CONSULTA PEDIR AL MORRO QUE HIZO LA DB
                Sentencia = @"";
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
                Sentencia = @""; ;
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
