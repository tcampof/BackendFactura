using FacturaElectronica.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Service.IService
{
    public interface IFacturaService
    {
        int GuardarFactura(Factura factura);
    }
}
