using FacturaElectronica.Common.Models;
using FacturaEletronica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.IService
{
    public interface IClienteService
    {
        Cliente Get(int IdCliente);
        IList<Cliente> Get();
        int Insertar(Cliente cliente);
        int Actualizar(Cliente cliente);
        int Eliminar(int idCliente);
    }
}
