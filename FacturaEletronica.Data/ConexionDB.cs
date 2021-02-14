using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaEletronica.Data
{
    public class ConexionDB
    {
        private SqlConnection con;
        string ConnectionString = "Server=localhost;Database=DB_Facturacion;Trusted_Connection=True;" ;
        public IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        public IEnumerable<T> GetRecords<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            IEnumerable<T> records = default(IEnumerable<T>);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                records = conn.Query<T>(sql: sql, param: parameters, commandType: commandType);
            }

            return records;
        }

        public async Task<IEnumerable<T>> GetRecordsAsync<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            IEnumerable<T> records = default(IEnumerable<T>);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                await conn.OpenAsync();
                try
                {
                    records = await conn.QueryAsync<T>(sql: sql, param: parameters, commandType: commandType);
                }
                catch (Exception originalException)
                {
                    throw originalException;
                }
            }

            return records;
        }

        public async Task<T> GetRecordAsync<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            T record = default(T);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                await conn.OpenAsync();
                try
                {
                    record = await conn.QueryFirstOrDefaultAsync<T>(sql: sql, param: parameters, commandType: commandType);
                }
                catch (Exception originalException)
                {
                    throw originalException;
                }
            }

            return record;
        }


        public T GetRecord<T>(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            T record = default(T);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                record = conn.QueryFirstOrDefault<T>(sql: sql, param: parameters, commandType: commandType);
            }

            return record;
        }

    }
}
