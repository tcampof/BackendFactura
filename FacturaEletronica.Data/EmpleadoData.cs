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
    public class EmpleadoData : ConexionDB
    {

        public Empleado Get(int empId)
        {
            return GetRecord<Empleado>(sql: "dbo.ObtenerEmpleado", parameters: new
            {
                empId,
            });
        }

        public IList<Empleado> Get()
        {
            return (IList<Empleado>)GetRecords<Empleado>(sql: "dbo.ObtenerEmpleado", parameters: new
            {
            });
        }

        public int Insert(Empleado empleado)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@EmpNombre", empleado.EmpNombre);
                    objParams.Add("@EmpCedula", empleado.EmpCedula);
                    objParams.Add("@EmpCargo", empleado.EmpCargo);
                    objParams.Add("@EmpActivo", empleado.EmpActivo);
                    objParams.Add("@RolId", empleado.RolId);

                    var data = conn.ExecuteScalar<int>("dbo.InsertarEmpleado",
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

        public int Update(Empleado empleado)
        {
            using (IDbConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    DynamicParameters objParams = new DynamicParameters();
                    objParams.Add("@EmpNombre", empleado.EmpNombre);
                    objParams.Add("@EmpCedula", empleado.EmpCedula);
                    objParams.Add("@EmpCargo", empleado.EmpCargo);
                    objParams.Add("@EmpActivo", empleado.EmpActivo);
                    objParams.Add("@RolId", empleado.RolId);


                    var data = conn.ExecuteScalar<int>("dbo.ActualizarEmpleado",
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
                    objParams.Add("@EmpId", cliId);

                    return conn.Execute("dbo.EliminarEmpleado",
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
