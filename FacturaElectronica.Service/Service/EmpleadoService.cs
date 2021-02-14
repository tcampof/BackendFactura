using FacturaElectronica.Common.Models;
using FacturaElectronica.Service.IService;
using FacturaEletronica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.Service
{
    public class EmpleadoService : IEmpleadoService
    {
        public int Actualizar(Empleado empleado)
        {
            var data = new EmpleadoData();
            return data.Update(empleado);
        }

        public int Eliminar(int id)
        {
            var data = new EmpleadoData();
            return data.Delete(id);
        }

        public Empleado Get(int id)
        {
            var data = new EmpleadoData();
            return data.Get(id);
        }

        public IList<Empleado> Get()
        {
            var data = new EmpleadoData();
            return data.Get();
        }

        public int Insertar(Empleado empleado)
        {
            var data = new EmpleadoData();
            return data.Insert(empleado);
        }
    }
}
