using FacturaElectronica.Common.Models;
using FacturaEletronica.Data;
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
    public class ClienteTest
    {
        [TestMethod]
        public void GetClienteTest_Ok()
        {
            var cliente = new ClienteData();
            var resrult = cliente.Get();
            Assert.IsNotNull(resrult);
        }


        [TestMethod]
        public void InsertClienteTest_Ok()
        {
            var cliente = new Cliente(0, "Tomas", "123456", "223366");
            var data = new ClienteData();
            var resrult = data.Insert(cliente);
            Assert.IsNotNull(resrult);
        }


        [TestMethod]
        public void DeleteClienteTest_Ok()
        {
            var data = new ClienteData();
            var cliente = new Cliente(2, "", "", "");
            var resrult = data.Delete(cliente.CliId);
            Assert.IsNotNull(resrult);
        }

        [TestMethod]
        public void ActualizarClienteTest_Ok()
        {
            var cliente = new Cliente(0, "Tomas Campo Update", "123456", "223366");
            var data = new ClienteData();
            var resrult = data.Update(cliente);
            Assert.IsNotNull(resrult);
        }

    }
}
