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
    }
}
