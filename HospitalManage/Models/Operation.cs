using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 手术间表
    /// </summary>
  public  class Operation
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 手术间名称
        /// </summary>
        public int OperationName { get; set; }
        /// <summary>
        /// 科室ID
        /// </summary>
        public int DepartmentID { get; set; }
    }
}
