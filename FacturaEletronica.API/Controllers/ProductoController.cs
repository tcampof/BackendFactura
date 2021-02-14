using FacturaElectronica.Common.Models;
using FacturaElectronica.Service;
using FacturaElectronica.Service.IService;
using FacturaElectronica.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FacturaEletronica.API.Controllers
{
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {
        IProductoService productoService;

        public ProductoController()
        {
            productoService = new ProductoService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var listProducto = productoService.Get();
            if (listProducto == null)
            {
                return NotFound();
            }
            return Ok(listProducto);

        }

        [HttpGet]
        [Route("ConsultarStock")]
        public IHttpActionResult ConsultarStock(int prodId)
        {
            var stock = productoService.ConsultarStock(prodId);
            return Ok(stock);
        }

        [HttpGet]
        public IHttpActionResult GetProducto(int idProducto)
        {
            var producto = productoService.Get(idProducto);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public IHttpActionResult Insertar([FromBody] Producto producto)
        {
            var response = productoService.Insertar(producto);
            if (response == 0)
            {
                return BadRequest("El código ya existe");
            }
            return Ok("Producto Insertado");
        }

        [HttpGet]
        [Route("Eliminar")]
        public IHttpActionResult Eliminar(int id)
        {
            var response = productoService.Eliminar(id);
            if (response == 0)
            {
                return BadRequest("No se pudo eliminar el producto");
            }
            return Ok("Producto Eliminado");
        }

        [HttpPost]
        [Route("Actualizar")]
        public IHttpActionResult Actualizar([FromBody] Producto producto)
        {
            var response = productoService.Actualizar(producto);
            if (response == 0)
            {
                return BadRequest("Ocurrió un error");
            }
            return Ok("Producto actualizado");
        }
    }
}
