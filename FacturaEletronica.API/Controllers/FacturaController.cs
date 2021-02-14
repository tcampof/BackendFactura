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
    [RoutePrefix("api/factura")]
    public class FacturaController : ApiController
    {
        IFacturaService facturaService;

        public FacturaController()
        {
            facturaService = new FacturaService();
        }    

        [HttpPost]
        public IHttpActionResult Guardar([FromBody] Factura factura)
        {
            var response = facturaService.GuardarFactura(factura);
            if (response == 0)
            {
                return BadRequest("El numero de factura ya existe");
            }
            return Ok("Factura Guardada");
        }

    }
}
