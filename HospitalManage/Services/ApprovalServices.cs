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
    public class ApprovalServices:IApprovalServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加业务
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        public int Add(Approval approval)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_ApprovalName", approval.ApprovalName);
                parameters.Add("@_IsAllowModify", approval.IsAllowModify);
                parameters.Add("@_Creator", approval.Creator);
                parameters.Add("@_CreateTime", approval.CreateTime);
                int res = conn.Execute("approval_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示业务信息
        /// </summary>
        /// <returns></returns>
        public List<Approval> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Approval>("approval_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 根据id反填业务信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Approval Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Approval>("approval_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改业务信息
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        public int Update(Approval approval)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", approval.Id);
                parameters.Add("@_ApprovalName", approval.ApprovalName);
                parameters.Add("@_IsAllowModify", approval.IsAllowModify);
                parameters.Add("@_Creator", approval.Creator);
                parameters.Add("@_CreateTime", approval.CreateTime);
                int res = conn.Execute("approval_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
