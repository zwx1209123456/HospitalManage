﻿using IServices;
using Models;
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
    public class ChainsGroupService : IChainsGroupService
    {
        public int AddChainsGroup(List<ChainsGroup> chainsGroupList)
        {
            List<DynamicParameters> parametersList = new List<DynamicParameters>();
            foreach (var chainsGroup in chainsGroupList)
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("GroupLeader", chainsGroup.GroupLeader);
                parameters.Add("GropCrew", chainsGroup.GropCrew);
                parameters.Add("ClassesId", chainsGroup.ClassesId);
                parameters.Add("SortNumber", chainsGroup.SortNumber);

                parametersList.Add(parameters);
            }
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {

                int i = conn.Execute("up_AddChainsGroup", parametersList, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public int DelChainsGroup(List<ChainsGroup> chainsGroupList)
        {
            List<DynamicParameters> parametersList = new List<DynamicParameters>();
            foreach (var chainsGroup in chainsGroupList)
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", chainsGroup.Id);
                parametersList.Add(parameters);
            }
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {

                int i = conn.Execute("up_DelChainsgroup", parametersList, commandType: CommandType.StoredProcedure);
                return i;
            }
        }

        public List<ChainsGroup> SelectChainsGroup()
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {

                List<ChainsGroup> i = conn.Query<ChainsGroup>("up_SelectChainsGroup", null, commandType: CommandType.StoredProcedure).ToList();
                return i;
            }
        }

        public int UpdateChainsGroup(List<ChainsGroup> chainsGroupList)
        {
            List<DynamicParameters> parametersList = new List<DynamicParameters>();
            foreach (var chainsGroup in chainsGroupList)
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", chainsGroup.Id);
                parameters.Add("GroupLeader", chainsGroup.GroupLeader);
                parameters.Add("GropCrew", chainsGroup.GropCrew);
                parameters.Add("ClassesId", chainsGroup.ClassesId);
                parameters.Add("SortNumber", chainsGroup.SortNumber);

                parametersList.Add(parameters);
            }
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {

                int i = conn.Execute("up_UpdatecChainsgroup", parametersList, commandType: CommandType.StoredProcedure);
                return i;
            }
        }
    }
}
