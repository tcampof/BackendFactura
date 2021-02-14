using Dapper;
using FacturaElectronica.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaEletronica.Data.Models
{
    public class ProductoData : ConexionDB
    {
        public Producto Get(int prodCod)
        {
            return GetRecord<Producto>(sql: "dbo.ObtenerProducto", parameters: new
            {
                prodCod,
            });
        }

        public int ConsultarStock(int prodId)
        {
            return GetRecord<int>(sql: "dbo.ConsultarStock", parameters: new
            {
                prodId,
            });
        }

        public IList<Producto> Get()
        {
            return (IList<Producto>)GetRecords<Producto>(sql: "dbo.ObtenerProducto", parameters: new
            {
            });
        }

        public int Insert(Producto producto)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@ProdCod", producto.ProdCod);
                    objParams.Add("@ProdNom", producto.ProdNom);
                    objParams.Add("@ProdDesc", producto.ProdDesc);
                    objParams.Add("@ProdPrecio", producto.ProdPrecio);
                    objParams.Add("@ProdStock", producto.ProdStock);

                    var data = conn.ExecuteScalar<int>("dbo.InsertarProducto",
                             objParams,
                             commandType: CommandType.StoredProcedure);

                    return data;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public int Update(Producto producto)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@ProdCod", producto.ProdCod);
                    objParams.Add("@ProdNom", producto.ProdNom);
                    objParams.Add("@ProdDesc", producto.ProdDesc);
                    objParams.Add("@ProdPrecio", producto.ProdPrecio);
                    objParams.Add("@ProdStock", producto.ProdStock);


                    var data = conn.ExecuteScalar<int>("dbo.ActualizarProducto",
                             objParams,
                             commandType: CommandType.StoredProcedure);

                    return data;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public int Delete(int prodId)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@ProdId", prodId);

                    return conn.Execute("dbo.EliminarProducto",
                              objParams,
                              commandType: CommandType.StoredProcedure);
                }
                catch
                {
                    throw new Exception();
                }
            }
        }
    }
}
