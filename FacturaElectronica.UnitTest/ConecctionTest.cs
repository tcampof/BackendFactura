using System;
using FacturaEletronica.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacturaElectronica.UnitTest
{
    [TestClass]
    public class ConecctionTest
    {
        [TestMethod]
        public void OpenConecction()
        {
            var conn = new ConexionDB();
            //conn.OpenConection();
            //var query = conn.DataReader("select ProdId from producto");
            //conn.CloseConnection();
            //Assert.IsNotNull(query);
        }
    }
}
