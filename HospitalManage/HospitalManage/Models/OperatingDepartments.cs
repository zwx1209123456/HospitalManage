using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 手术科室关联表
    /// </summary>
   public class OperatingDepartments
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 科室ID
        /// </summary>
        public int DepartmentID { get; set; }
        /// <summary>
        /// 手术间ID
        /// </summary>
        public int OperationID { get; set; }
    }
}
