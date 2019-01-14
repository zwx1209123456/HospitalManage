

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
    public class SolitaireService : ISolitaireService
    {
        public int AddSolitaire(Solitaire solitaire)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("SolitaireClassID", solitaire.SolitaireClassID);
                parameters.Add("StartSolitaire", solitaire.StartSolitaire);
                parameters.Add("LastStartSolitaire", solitaire.LastStartSolitaire);
                parameters.Add("ChainsGroupIds", solitaire.ChainsGroupIds);
                parameters.Add("SoSortNumber", solitaire.SoSortNumber);
                int i = conn.Execute("up_AddSolitaire", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public int DelSolitaire(int id)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("SolitaireClassID", id);
                int i = conn.Execute("up_DelSolitaire", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public List<Solitaire> SelectSolitaire()
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                List<Solitaire> list = conn.Query<Solitaire>("up_SelectSolitaire", null, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
        }

        public int UpdateSolitaire(Solitaire solitaire)
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", solitaire.Id);
                parameters.Add("SolitaireClassID", solitaire.SolitaireClassID);
                parameters.Add("StartSolitaire", solitaire.StartSolitaire);
                parameters.Add("LastStartSolitaire", solitaire.LastStartSolitaire);
                parameters.Add("ChainsGroupIds", solitaire.ChainsGroupIds);
                parameters.Add("SoSortNumber", solitaire.SoSortNumber);
                int i = conn.Execute("up_UpdatecSolitaire", parameters, commandType: CommandType.StoredProcedure);
                return i;
            }
        }
    }
}
