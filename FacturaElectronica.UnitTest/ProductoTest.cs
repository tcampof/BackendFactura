using FacturaElectronica.Common.Models;
using FacturaEletronica.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.UnitTest
{
    [TestClass]
    public class ProductoTest
    {
        [TestMethod]
        public void GetEmpleadoTest_Stock()
        {
            var producto = new ProductoData();
            var result = producto.ConsultarStock(1);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void GetEmpleadoTest_NoStock()
        {
            var producto = new ProductoData();
            var result = producto.ConsultarStock(1);
            Assert.IsTrue(result == 0);
        }

    }
}
