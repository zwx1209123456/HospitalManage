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
    public class VacationServices:IVacationServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加假期信息
        /// </summary>
        /// <param name="vacation"></param>
        /// <returns></returns>
        public int Add(Vacation vacation)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_DayApplyLimit", vacation.DayApplyLimit);
                parameters.Add("@_WeekApplyLimit", vacation.WeekApplyLimit);
                parameters.Add("@_MonthApplyLimit", vacation.MonthApplyLimit);
                int res = conn.Execute("vacation_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示假期信息
        /// </summary>
        /// <returns></returns>
        public List<Vacation> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Vacation>("vacation_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除假期信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("vacation_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 反填假期信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Vacation Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Vacation>("vacation_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改假期信息
        /// </summary>
        /// <param name="vacation"></param>
        /// <returns></returns>
        public int Update(Vacation vacation)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", vacation.Id);
                parameters.Add("@_DayApplyLimit", vacation.DayApplyLimit);
                parameters.Add("@_WeekApplyLimit", vacation.WeekApplyLimit);
                parameters.Add("@_MonthApplyLimit", vacation.MonthApplyLimit);
                int res = conn.Execute("vacation_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
