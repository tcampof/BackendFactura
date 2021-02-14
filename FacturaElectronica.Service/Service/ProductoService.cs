using FacturaElectronica.Common.Models;
using FacturaElectronica.Service.IService;
using FacturaEletronica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.Service
{
    public class ProductoService : IProductoService
    {
        public int Actualizar(Producto producto)
        {
            var data = new ProductoData();
            return data.Update(producto);
        }

        public int Eliminar(int idProducto)
        {
            var data = new ProductoData();
            return data.Delete(idProducto);
        }

        public Producto Get(int IdProducto)
        {
            var data = new ProductoData();
            return data.Get(IdProducto);
        }

        public IList<Producto> Get()
        {
            var data = new ProductoData();
            return data.Get();
        }

        public int Insertar(Producto producto)
        {
            var data = new ProductoData();
            return data.Insert(producto);
        }

        public int ConsultarStock(int prodId)
        {
            var data = new ProductoData();
            return data.ConsultarStock(prodId);
        }
    }
}
