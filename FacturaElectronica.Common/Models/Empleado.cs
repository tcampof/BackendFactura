using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Common.Models
{
    public class Empleado
    {
        public int EmpId { get; set; }
        public string EmpCedula { get; set; }
        public string EmpNombre { get; set; }
        public string EmpCargo { get; set; }
        public bool EmpActivo { get; set; }
        public int RolId { get; set; }

        public Empleado()
        {

        }
        public Empleado(int id, string nombre, string cedula, string cargo, bool activo, int rol)
        {
            EmpId = id;
            EmpCedula = cedula;
            EmpNombre = nombre;
            EmpCargo = cargo;
            EmpActivo = activo;
            RolId = rol;
        }
    }
}

