using FacturaElectronica.Common.Models;
using FacturaElectronica.Service.IService;
using FacturaEletronica.Data;
using FacturaEletronica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service
{
    public class ClienteService : IClienteService
    {
        public int Actualizar(Cliente cliente)
        {
            var data = new ClienteData();
            return data.Update(cliente);
        }

        public int Eliminar(int idCliente)
        {
            var data = new ClienteData();
            return data.Delete(idCliente);
        }

        public Cliente Get(int idCliente)
        {
            var data = new ClienteData();
            return data.Get(idCliente);
        }

        public IList<Cliente> Get()
        {
            var data = new ClienteData();
            return data.Get();
        }

        public int Insertar(Cliente cliente)
        {
            var data = new ClienteData();
            return data.Insert(cliente);
        }
    }
}
