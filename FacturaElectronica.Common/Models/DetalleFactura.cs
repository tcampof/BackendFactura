using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Common.Models
{
    public class DetalleFactura
    {
        public int DetId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float ValorUnit { get; set; }
    }
}
