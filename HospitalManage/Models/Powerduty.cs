using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 群贤职务关联表
    /// </summary>
    public class Powerduty
    {
        public int Id { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int PowerID{get;set;}
        /// <summary>
        /// 职务ID
        /// </summary>
        public int DutyID { get; set; }
    }
}
