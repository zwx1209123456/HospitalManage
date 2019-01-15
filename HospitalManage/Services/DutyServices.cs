using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    using Models;
    using IServices;
    using CommHelps;
    using System.Data.SqlClient;
    using MySql.Data.MySqlClient;
    using Dapper;
    public class DutyServices : IDutyServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 职务添加
        /// </summary>
        /// <param name="duty"></param>
        /// <returns></returns>

        public int DutyAdd(Duty duty)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                //conn.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_DutyName", duty.DutyName, null, null, null, null);
                parameters.Add("_TierID", duty.TierID, null, null, null, null);
                parameters.Add("_PowerID", duty.PowerID, null, null, null, null);

                int res = conn.Execute("sp_Duty_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 职务删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DutyDelete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_Id", Id);
                return conn.Execute("sp_Duty_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }

        }

        public int DutyUpdate(Duty duty)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_Id", duty.Id);
                parameters.Add("_DutyName", duty.DutyName);
                parameters.Add("_TierID", duty.TierID);
                parameters.Add("_PowerID", duty.PowerID);
                int res = conn.Execute("sp_Duty_update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }

        public List<Duty> GetDuties()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Duty>("Duty_show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();

            }
        }
    }
}
