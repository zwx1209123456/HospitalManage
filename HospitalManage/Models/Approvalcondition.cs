using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 审批条件
    /// </summary>
   public class Approvalcondition
    {
        /// <summary>
        /// 主键id
        /// </summary>  
         public int Id { get; set; }
        /// <summary>
        /// 审批条件
        /// </summary>
         public string Conditions { get; set; }
        /// <summary>
        /// 业务id
        /// </summary>
        public int Approvalid { get; set; }
        /// <summary>
        /// 业务名称
        /// </summary>
        public string ApprovalName { get; set; }
    }
}
