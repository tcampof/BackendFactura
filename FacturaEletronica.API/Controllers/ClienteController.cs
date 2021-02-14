using FacturaElectronica.Common.Models;
using FacturaElectronica.Service;
using FacturaElectronica.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FacturaEletronica.API.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        IClienteService clienteService;

        public ClienteController()
        {
            clienteService = new ClienteService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var listCliente = clienteService.Get();
            if (listCliente == null)
            {
                return NotFound();
            }
            return Ok(listCliente);

        }

        [HttpGet]
        public IHttpActionResult GetCliente(int idCliente)
        {
            var cliente = clienteService.Get(idCliente);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IHttpActionResult Insertar([FromBody] Cliente cliente)
        {
            var response = clienteService.Insertar(cliente);
            if (response == 0)
            {
                return BadRequest("La identificación ya existe");
            }
            return Ok("Cliente Insertado");
        }

        [HttpGet]
        [Route("Eliminar")]
        public IHttpActionResult Eliminar(int id)
        {
            var response = clienteService.Eliminar(id);
            if (response == 0)
            {
                return BadRequest("No se pudo eliminar el cliente");
            }
            return Ok("Cliente Eliminado");
        }

        [HttpPost]
        [Route("Actualizar")]
        public IHttpActionResult Actualizar([FromBody] Cliente cliente)
        {
            var response = clienteService.Actualizar(cliente);
            if (response == 0)
            {
                return BadRequest("Ocurrió un error");
            }
            return Ok("Cliente actualizado");
        }
    }
}
