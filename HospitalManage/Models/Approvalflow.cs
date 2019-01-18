using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 审批流程配置表
    /// </summary>
   public class Approvalflow
    {
        /// <summary>
        /// 主键id
        /// </summary>
       public int Id { get; set; }
        /// <summary>
        /// 审批业务id
        /// </summary>
        public int ApprovalID { get; set; }
        /// <summary>
        /// 配置流程编码
        /// </summary>
        public string FlowCode { get; set; }
        /// <summary>
        /// 审批科室id
        /// </summary>
        public int DepartmentID { get; set; }
        /// <summary>
        /// 判断条件id
        /// </summary>
        public int ConditionID { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public int ApprovalStatus { get; set; }
        /// <summary>
        /// 审批类型
        /// </summary>
        public string ApprovalType { get; set; }
        /// <summary>
        /// 审批方式
        /// </summary>
        public string ApprovalWay { get; set; }
        /// <summary>
        /// 申请人角色id
        /// </summary>
        public int DutyID { get; set; }
        /// <summary>
        /// 审批起点
        /// </summary>
        public string StartApproval { get; set; }
        /// <summary>
        /// 审批终点
        /// </summary>
        public string LastApproval { get; set; }
        /// <summary>
        /// 审批人ids
        /// </summary>
        public string UserIDs { get; set; }

        public string ApprovalName { get; set; }
        public string DepartmentName { get; set; }
        public string Conditions { get; set; }
        public string DutyName { get; set; }










    }
}
