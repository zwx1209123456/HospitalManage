using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IServices;
using CommHelps;
using MySql.Data.MySqlClient;
using Dapper;

namespace Services
{
    public class PowerServices : IPowerServices
    {
        DapperHelper dapper = new DapperHelper();
        public int Add(Power power)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_PowerName", power.PowerName);
            parameters.Add("@_PowerUrl", power.PowerUrl);
            parameters.Add("@_IsEnabled", power.IsEnabled);
            int result = conn.Execute("power_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public int Delete(int Id)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", Id);//参数没写
            return conn.Execute("power_Deletes", parameters, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Power GetPower(int Id)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", Id);
            return conn.QueryFirst<Power>("power_Getpowers", parameters, commandType: System.Data.CommandType.StoredProcedure);
        }

        public List<Power> GetPowers()
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            return conn.Query<Power>("Power_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }

        public int Update(Power power)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", power.Id);
            parameters.Add("@_PowerName", power.PowerName);
            parameters.Add("@_PowerUrl", power.PowerUrl);
            parameters.Add("@_IsEnabled", power.IsEnabled);
            int result = conn.Execute("power_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}
