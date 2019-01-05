using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 职务表
    /// </summary>
   public class Duty
    {
        /// <summary>
        /// 职务主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 职务名称
        /// </summary>
        public string DutyName { get; set; }
        /// <summary>
        /// 层级ID
        /// </summary>
        public int TierID { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int PowerID { get; set; }
    }
}
