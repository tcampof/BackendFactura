using FacturaElectronica.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.IService
{
    public interface IEmpleadoService
    {
        Empleado Get(int id);
        IList<Empleado> Get();
        int Insertar(Empleado empleado);
        int Actualizar(Empleado empleado);
        int Eliminar(int id);
    }
}
