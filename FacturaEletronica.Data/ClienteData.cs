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
    public class ClienteData : ConexionDB
    {
        public Cliente Get(int cliId)
        {
            return GetRecord<Cliente>(sql: "dbo.ObtenerClientes", parameters: new
            {
                cliId,
            });
        }

        public IList<Cliente> Get()
        {
            return (IList<Cliente>)GetRecords<Cliente>(sql: "dbo.ObtenerClientes", parameters: new
            {
            });
        }

        public int Insert(Cliente cliente)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@CliNombre", cliente.CliNombre);
                    objParams.Add("@CliIdent", cliente.CliIdent);
                    objParams.Add("@CliTelefono", cliente.CliTelefono);

                     var data = conn.ExecuteScalar<int>("dbo.InsertarCliente",
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

        public int Update(Cliente cliente)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@CliNombre", cliente.CliNombre);
                    objParams.Add("@CliIdent", cliente.CliIdent);
                    objParams.Add("@CliTelefono", cliente.CliTelefono);

                    var data = conn.ExecuteScalar<int>("dbo.ActualizarCliente",
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

        public int Delete(int cliId)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@CliId", cliId);

                    return conn.Execute("dbo.EliminarCliente",
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
