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
    public class EmpleadoTest
    {
        [TestMethod]
        public void GetEmpleadoTest_Ok()
        {
            var empleado = new EmpleadoData();
            var resrult = empleado.Get();
            Assert.IsNotNull(resrult);
        }


        [TestMethod]
        public void InsertEmpleadoTest_Ok()
        {
            var empleado = new Empleado(0, "Empleado 2", "1444444444444444", "Vendedor", true, 2);
            var data = new EmpleadoData();
            var resrult = data.Insert(empleado);
            Assert.IsNotNull(resrult);
        }


        [TestMethod]
        public void DeleteEmpleadoTest_Ok()
        {
            var data = new EmpleadoData();
            var empleado = new Empleado(1, "Empleado 1", "1222", "Admin", true, 1);
            var resrult = data.Delete(empleado.EmpId);
            Assert.IsNotNull(resrult);
        }

        [TestMethod]
        public void ActualizarEmpleadoTest_Ok()
        {
            var empleado = new Empleado(0, "Empleado update", "133333", "Admin", true, 1);
            var data = new EmpleadoData();
            var resrult = data.Update(empleado);
            Assert.IsNotNull(resrult);
        }

    }
}
