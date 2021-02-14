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
    public class FacturaService : IFacturaService
    {
        public int GuardarFactura(Factura factura)
        {
            var data = new FacturaData();
            return data.GuardarFactura(factura);
        }
    }
}
