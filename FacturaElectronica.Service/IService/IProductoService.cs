using FacturaElectronica.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.IService
{
    public interface IProductoService
    {
        Producto Get(int IdCliente);
        IList<Producto> Get();
        int Insertar(Producto cliente);
        int Actualizar(Producto cliente);
        int Eliminar(int idCliente);
        int ConsultarStock(int prodId);
    }
}
