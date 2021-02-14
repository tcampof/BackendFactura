using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Common.Models
{
    public class Producto
    {
        public int ProdId { get; set; }
        public string ProdNom { get; set; }
        public int ProdCod { get; set; }
        public string ProdDesc { get; set; }
        public float ProdPrecio { get; set; }
        public int ProdStock { get; set; }

    }
}
