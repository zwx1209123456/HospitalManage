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
    public class ApprovalflowServices:IApprovalflowServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加审批流程配置信息
        /// </summary>
        /// <param name="approvalflow"></param>
        /// <returns></returns>
        public int Add(Approvalflow approvalflow)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_ApprovalID", approvalflow.ApprovalID);
                parameters.Add("@_FlowCode", approvalflow.FlowCode);
                parameters.Add("@_DepartmentID", approvalflow.DepartmentID);
                parameters.Add("@_ConditionID", approvalflow.ConditionID);
                parameters.Add("@_ApprovalStatus", approvalflow.ApprovalStatus);
                parameters.Add("@_ApprovalType", approvalflow.ApprovalType);
                parameters.Add("@_ApprovalWay", approvalflow.ApprovalWay);
                parameters.Add("@_DutyID", approvalflow.DutyID);
                parameters.Add("@_DutyIDs", approvalflow.DutyIDs);
                parameters.Add("@_StartApproval", approvalflow.StartApproval);
                parameters.Add("@_LastApproval", approvalflow.LastApproval);
                parameters.Add("@_UserIDs", approvalflow.UserIDs);
                int res = conn.Execute("flow_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示审批流程配置信息
        /// </summary>
        /// <returns></returns>
        public List<Approvalflow> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Approvalflow>("flow_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除审批流程配置信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("flow_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 根据ID反填审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Approvalflow Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Approvalflow>("flow_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        public int Update(Approvalflow approvalflow)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", approvalflow.Id);
                parameters.Add("@_ApprovalID", approvalflow.ApprovalID);
                parameters.Add("@_FlowCode", approvalflow.FlowCode);
                parameters.Add("@_DepartmentID", approvalflow.DepartmentID);
                parameters.Add("@_ConditionID", approvalflow.ConditionID);
                parameters.Add("@_ApprovalStatus", approvalflow.ApprovalStatus);
                parameters.Add("@_ApprovalType", approvalflow.ApprovalType);
                parameters.Add("@_ApprovalWay", approvalflow.ApprovalWay);
                parameters.Add("@_DutyID", approvalflow.DutyID);
                parameters.Add("@_DutyIDs", approvalflow.DutyIDs);
                parameters.Add("@_StartApproval", approvalflow.StartApproval);
                parameters.Add("@_LastApproval", approvalflow.LastApproval);
                parameters.Add("@_UserIDs", approvalflow.UserIDs);
                int res = conn.Execute("flow_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 获取用户表
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public List<Users> GetUsers(int DepartmentID)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_DepartmentID", DepartmentID);
            return conn.Query<Users>("flow_GetUsers", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }
    }
}
