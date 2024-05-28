using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
IDCitas int AI PK 
IDHistorialClinico int 
Estado enum('Pendiente','Completada','Cancelada') 
Nota varchar(255) 
FechaCita date 
HoraCita
*/
namespace General2.CLS
{
    internal class infoCitas
    {
        String _IDCitas;
        String _IDHistorialClinico;
        String _Estado;
        String _Nota;
        String _FechaCita;
        String _HoraCita;

        public string IDCitas { get => _IDCitas; set => _IDCitas = value; }
        public string IDHistorialClinico { get => _IDHistorialClinico; set => _IDHistorialClinico = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public string FechaCita { get => _FechaCita; set => _FechaCita = value; }
        public string HoraCita { get => _HoraCita; set => _HoraCita = value; }
    }
}
