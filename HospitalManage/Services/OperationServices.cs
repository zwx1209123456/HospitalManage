using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using CommHelps;
    using Models;
    using MySql.Data.MySqlClient;
    using Dapper;
    using IServices;
   public class OperationServices:IOperationServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 显示手术间的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Operation> ShowOperation()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Operation>("OperationShow", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
    }
}
