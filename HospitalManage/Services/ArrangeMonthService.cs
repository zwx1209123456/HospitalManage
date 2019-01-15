using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    using CommHelps;
    using Dapper;
    using IServices;
    using MySql.Data.MySqlClient;

    public class ArrangeMonthService:IArrangeMonthServices
    {
        DapperHelper dapper = new DapperHelper();
        public List<NewArrage> GetArrangeMonth()
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            return conn.Query<NewArrage>("Arrange_ShowMonth", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }
    }
}
