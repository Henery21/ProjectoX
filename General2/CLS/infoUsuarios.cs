using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
IDUsuario int AI PK 
IDRol int 
IDEmpleado int 
NomCompleto varchar(255) 
Usuario varchar(100) 
Clave varchar(255) 
TipoUsuario enum('Administrador','Doctor','Recepcionista') 
Estado enum('Activo','Inactivo') 
*/
namespace General2.CLS
{
    internal class infoUsuarios
    {
        String _IDUsuario;
        String _IDRol;
        String _IDEmpleado;
        String _NomCompleto;
        String _Usuario;
        String _Clave;
        String _TipoUsuario;
        String _Estado;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string NomCompleto { get => _NomCompleto; set => _NomCompleto = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
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
