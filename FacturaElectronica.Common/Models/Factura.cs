using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Common.Models
{
    public class Factura
    {
        public int FactId { get; set; }
        public int FactNum { get; set; }
        public DateTime FactFecha { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public float Total { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }

        public Factura()
        {

        }
    }
}
