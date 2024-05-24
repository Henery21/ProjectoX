using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SessionManager
{
    public class Class1
    {
        //Atributos
        static Class1 _Instancia = null;
        static readonly Object _codelock = new Object();

        String _Usuario;
        String _IDUsuario;
        String _Rol;
        String _IDRol;
        String _IDEmpleados;


        //Propiedades
        public static Class1 Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (_codelock)
                    {
                        if (_Instancia == null)
                        {
                            _Instancia = new Class1();
                        }
                    }
                }
                return _Instancia;
            }
        }

        public string Usuario { get => _Usuario; }
        public string IDUsuario { get => _IDUsuario; }
        public string Rol { get => _Rol; }
        public string IDRol { get => _IDRol; }


        //Metodos
        private Class1()
        {


        }
        public Boolean IniciarSesion(String pUsuario, String pClave)
        {
            Boolean result = false;
            DataTable Resultado = new DataTable();
            try
            {
                Resultado = DataLayer.Consultas.VerificarL(pUsuario, pClave);
                if (Resultado.Rows.Count == 1)
                {
                    _IDUsuario = Resultado.Rows[0]["IDUsuario"].ToString();
                    _Usuario = Resultado.Rows[0]["Usuario"].ToString();
                    _IDRol = Resultado.Rows[0]["IDRol"].ToString();
                    _Rol = Resultado.Rows[0]["Rol"].ToString();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
