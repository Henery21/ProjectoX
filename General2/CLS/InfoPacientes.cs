﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 IDPaciente int AI PK 
IDDireccion int 
Nombres varchar(255) 
Apellidos varchar(255) 
Telefono varchar(20) 
Correo varchar(255) 
Direccion varchar(255) 
FechaNacimiento date 
Sexo enum('Masculino','Femenino') 
Estado enum('Activo','Inactivo') 
IDTratamiento
 */

namespace General2.CLS
{
    internal class InfoPacientes
    {
        String _IDpaciente;
        String _IDDireccion;
        String _Nombres;
        String _Apellidos;
        String _Telefono;
        String _Correo;
        String _Direccion;
        String _FechaNacimiento;
        String _Sexo;
        String _Estado;
        String _IDtratamiento;

        public string IDpaciente { get => _IDpaciente; set => _IDpaciente = value; }
        public string IDDireccion { get => _IDDireccion; set => _IDDireccion = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IDtratamiento { get => _IDtratamiento; set => _IDtratamiento = value; }


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
