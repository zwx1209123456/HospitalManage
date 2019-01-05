using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 科室表
    /// </summary>
   public class Department
    {
        /// <summary>
        /// 科室主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentName { get; set; }
    }
}
