using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    using IServices;
    using Models;
    using CommHelps;
    using MySql.Data.MySqlClient;
    using Dapper;
    using System.Data;

    public class TierService : ITierService//此类只含层级的增删改查
    {
        public int AddTier(Tier tier)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("TierName", tier.TierName);
                //conn.Execute("up_AddTier",parameters,null,null,CommandType.StoredProcedure);
                int i = conn.Execute("up_AddTier", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public int DelTier(int id)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", id);
                //conn.Execute("up_AddTier",parameters,null,null,CommandType.StoredProcedure);
                int i = conn.Execute("up_DelTier", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public List<Tier> SelectTier()
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {

                List<Tier> list = conn.Query<Tier>("up_SelectTier", null, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
        }

        public int UpdateTier(Tier tier)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", tier.Id);
                parameters.Add("TierName", tier.TierName);
                //conn.Execute("up_AddTier",parameters,null,null,CommandType.StoredProcedure);
                int i = conn.Execute("up_UpdateTier", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }
    }
}
