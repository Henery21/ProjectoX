using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
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
