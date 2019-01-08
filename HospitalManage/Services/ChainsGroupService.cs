using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using IServices;
    using Models;
    using CommHelps;
    using MySql.Data.MySqlClient;
    using Dapper;
    using System.Data;
    public class ChainsGroupService : IChainsGroupService
    {
        public int AddChainsGroup(ChainsGroup chainsGroup)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("GroupLeader", chainsGroup.GroupLeader);
                parameters.Add("GropCrew", chainsGroup.GropCrew);
                parameters.Add("ClassesId", chainsGroup.ClassesId);
                parameters.Add("SortNumber", chainsGroup.SortNumber);
                int i = conn.Execute("up_AddChainsGroup", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public int DelChainsGroup(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChainsGroup> SelectChainsGroup()
        {
            throw new NotImplementedException();
        }

        public int UpdateChainsGroup(ChainsGroup chainsGroup)
        {
            throw new NotImplementedException();
        }
    }
}
