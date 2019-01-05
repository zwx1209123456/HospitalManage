using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class Users
    {
        public int Id { get; set; }
        
        /// <summary>
        /// 科室ID
        /// </summary>
        public int DepartmentID { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// 工号
        /// </summary>
        public string UserNumber { get; set; }
       
        /// <summary>
        /// 职务ID
        /// </summary>
        public int DutyID { get; set; }
        
        /// <summary>
        /// 层级ID
        /// </summary>
        public int TierID { get; set; }
        
        /// <summary>
        /// 年假天数
        /// </summary>
        public int AnnualDay { get; set; }
        
        /// <summary>
        /// 入职时间
        /// </summary>
        public string EntryTime { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 职务名称
        /// </summary>
        public string DutyName { get; set; }
        /// <summary>
        /// 层级名称
        /// </summary>
        public string TierName { get; set; }

    }
}
