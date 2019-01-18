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
   public class ApprovalconditionServices:IApprovalconditionServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        public int Add(Approvalcondition approvalcondition)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Conditions", approvalcondition.Conditions);
                parameters.Add("@_Approvalid", approvalcondition.Approvalid);
                int res = conn.Execute("cond_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        public List<Approvalcondition> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Approvalcondition>("cond_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("cond_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 根据ID反填审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Approvalcondition Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Approvalcondition>("cond_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        public int Update(Approvalcondition approvalcondition)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", approvalcondition.Id);
                parameters.Add("@_Conditions", approvalcondition.Conditions);
                parameters.Add("@_Approvalid", approvalcondition.Approvalid);
                int res = conn.Execute("cond_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
