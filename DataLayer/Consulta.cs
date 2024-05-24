using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Consultas
    {


        public static DataTable VerificarL(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT 
             a.IDUsuario,a.Usuario, a.IDEmpleado, a.IDRol,
             b.Nombres, b.Apellidos,c.Rol  
                FROM usuarios a, empleados b, roles c
                    WHERE a.Usuario='" + pUsuario + @"' 
                AND a.Clave='" + pClave + @"'
                AND a.IDEmpleado=b.IDEmpleado 
                AND a.IDRol=c.IDRol;";
            DBoperacion Consultor = new DBoperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "Select IDEmpleado, Nombres, Apellidos from empleados order by Nombres ASC ";

            DBoperacion operaciones = new DBoperacion();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception)
            {
                Console.WriteLine("Error al traer los datos");
            }

            return Resultado;
        }

        public static DataTable ROLES()
        {
            DataTable Result = new DataTable();
            String Consultar = @"Select IDRol, Rol from roles order by Rol ASC";
            DBoperacion operaciones = new DBoperacion();
            try
            {
                Result = operaciones.Consultar(Consultar);
            }
            catch (Exception ex)
            {

            }

            return Result;
        }

        public static DataTable USUARIOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "select * from vista_usuarios;";

            DBoperacion operaciones = new DBoperacion();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al traer los datos");
            }

            return Resultado;
        }

        public static DataTable OPCIONES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "select IDOpcion, Opcion from opciones;";

            DBoperacion operaciones = new DBoperacion();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al traer losd datos");
            }

            return Resultado;
        }


        public static DataTable CUENTAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = "SELECT IDcuenta, Cuenta, Fecha ,Cliente, Saldo FROM cuentas ";

            DBoperacion operaciones = new DBoperacion();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al traer los datos: " + ex.Message);
            }

            return Resultado;
        }

        public static DataTable Orden_segun_pedidos(String pFechaInicio, String pFechaFinal)
        {
            DataTable Resulta = new DataTable();
            String Consulta = @"select a. OrderID, a.OrderDate, c.companyName, 
                                concat(d.FirstName,'', d.LastName)Empleado,
                                sum(b.Quantity*b.UnitPrice) SubTotal,
                                sum(b.Discount* b.Quantity*b.Unitprice) Descuento,
                                sum(b.Quantity*b.UnitPrice*(1-b.Discount))Total
                                From orders a 
                                Inner join orderdetails b on b.OrderID= a.Order 
                                IDinner join customers c on c.CustomerId= a.CustomerID  
                                inner join employees d on d.EmployeeID=a.EmployeeID 
                                where cast( a.OrderDate as date) Between '" + pFechaInicio + "' AND '" + pFechaFinal + @"'
                                group by \r\na.OrderID,\r\na.OrderDate,\r\nc.CompanyName,
                                concat(d.FirstName, '', d.LastName);";
            DBoperacion operaciones = new DBoperacion();
            try
            {
                Resulta = operaciones.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al traer los datos: " + ex.Message);
            }

            return Resulta;
        }

    }
}