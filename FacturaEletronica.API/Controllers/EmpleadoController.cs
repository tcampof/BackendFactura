using FacturaElectronica.Common.Models;
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
    [RoutePrefix("api/empleado")]
    public class EmpleadoController : ApiController
    {
        IEmpleadoService service;

        public EmpleadoController()
        {
            service = new EmpleadoService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var list = service.Get();
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);

        }

        [HttpGet]
        public IHttpActionResult GetEmpleado(int id)
        {
            var empleado = service.Get(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        [HttpPost]
        public IHttpActionResult Insertar([FromBody] Empleado empleado)
        {
            var response = service.Insertar(empleado);
            if (response == 0)
            {
                return BadRequest("La cedula ya existe");
            }
            return Ok("Empleado Insertado");
        }

        [HttpGet]
        [Route("Eliminar")]
        public IHttpActionResult Eliminar(int id)
        {
            var response = service.Eliminar(id);
            if (response == 0)
            {
                return BadRequest("No se pudo eliminar el empleado");
            }
            return Ok("Empleado Eliminado");
        }

        [HttpPost]
        [Route("Actualizar")]
        public IHttpActionResult Actualizar([FromBody] Empleado empleado)
        {
            var response = service.Actualizar(empleado);
            if (response == 0)
            {
                return BadRequest("Ocurrió un error");
            }
            return Ok("Empleado actualizado");
        }
    }
}
