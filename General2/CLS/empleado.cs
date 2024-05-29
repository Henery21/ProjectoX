using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
IDEmpleado int AI PK 
IDDireccion int 
IDCargo int 
IDPermiso int 
Nombres varchar(255) 
Apellidos varchar(255) 
Telefono varchar(20) 
Correo varchar(255) 
Direccion varchar(255) 
Puesto varchar(255) 
Sexo enum('Masculino','Femenino') 
Estado
*/
namespace General2.CLS
{
    internal class empleado
    {
        private String _IDEmpleado;
        private String _IDDireccion;
        private String _IDCargo;
        private String _IDPErmiso;
        private String _Nombres;
        private String _Apellidos;
        private String _Telefono;
        private String _Correo;
        private String _Direccion;
        private String _Puesto;
        String _Sexo;
        String _Estado;

        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string IDDireccion { get => _IDDireccion; set => _IDDireccion = value; }
        public string IDCargo { get => _IDCargo; set => _IDCargo = value; }
        public string IDPErmiso { get => _IDPErmiso; set => _IDPErmiso = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }


        
        public Boolean Insertar()
        {
            Boolean resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;

            try
            {
                //FALTA CONSULTA PEDIR AL MORRO QUE HIZO LA DB
                Sentencia = @"INSERT INTO Empleados (IDEmpleado, IDDireccion, IDCargo, IDPermiso, Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo, Estado) 
                                VALUES (@IDEmpleado, @IDDireccion, @IDCargo, @IDPermiso, @Nombres, @Apellidos, @Telefono, @Correo, @Direccion, @Puesto, @Sexo, @Estado)"; 
                DataLayer.DBoperacion Operacion = new DataLayer.DBoperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar empleado: " + ex.Message);
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
                Sentencia = @"UPDATE Empleados 
                                SET IDDireccion = @IDDireccion, IDCargo = @IDCargo, IDPermiso = @IDPermiso,
                                    Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, 
                                    Correo = @Correo, Direccion = @Direccion, Puesto = @Puesto, 
                                    Sexo = @Sexo, Estado = @Estado
                                WHERE IDEmpleado = @IDEmpleado";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar empleado: " + ex.Message);
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
                Sentencia = @"DELETE FROM Empleados WHERE IDEmpleado = @IDEmpleado";
                if (true)
                {
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar empleado: " + ex.Message);
                Resultado = false;
            }

            return Resultado;
        }
    }
}
