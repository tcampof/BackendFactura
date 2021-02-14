using Dapper;
using FacturaElectronica.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaEletronica.Data
{
    public class FacturaData : ConexionDB
    {
        public int GuardarFactura(Factura factura)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    var FactId = 0;

                    using (var transaction = conn.BeginTransaction())
                    {
                        DynamicParameters objParams = new DynamicParameters();
                        objParams.Add("@FactNum", factura.FactNum);
                        objParams.Add("@FactFecha", factura.FactFecha);
                        objParams.Add("@CliId", factura.Cliente.CliId);
                        objParams.Add("@EmpId", factura.Empleado.EmpId);
                        objParams.Add("@Total", factura.Total);

                        FactId = conn.ExecuteScalar<int>("dbo.GuardarFactura",
                                 objParams, transaction: transaction,
                                 commandType: CommandType.StoredProcedure);

                        foreach (var d in factura.DetalleFactura)
                        {
                            DynamicParameters objParamsD = new DynamicParameters();
                            objParamsD.Add("@FactId", FactId);
                            objParamsD.Add("@ProdId", d.Producto.ProdId);
                            objParamsD.Add("@Cantidad", d.Cantidad);
                            objParamsD.Add("@Valor", d.ValorUnit);

                            conn.Execute("dbo.GuardarDetalleFactura",
                                     objParamsD, transaction: transaction,
                                     commandType: CommandType.StoredProcedure);
                        }

                        transaction.Commit();

                        return FactId;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
