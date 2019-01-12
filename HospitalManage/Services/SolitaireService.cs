

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
            using (MySqlConnection conn=DapperHelper.Instance().GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("SolitaireClassID", solitaire.ClassesId);
                parameters.Add("StartSolitaire", solitaire.StartSolitaire);
                parameters.Add("LastStartSolitaire", solitaire.LastStartSolitaire);
                parameters.Add("ChainsGroupIds", solitaire.ChainsGroupIds);
                int i = conn.Execute("up_AddSolitaire", parameters,commandType:CommandType.StoredProcedure);
                return i;
            }
        }

        public int DelSolitaire(int id)
        {
            throw new NotImplementedException();
        }

        public List<Solitaire> SelectSolitaire()
        {
            return null;
        }

        public int UpdateSolitaire(Solitaire solitaire)
        {
            throw new NotImplementedException();
        }
    }
}
