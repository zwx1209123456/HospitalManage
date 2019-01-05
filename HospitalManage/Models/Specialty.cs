using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public   class Specialty
    {
     public int Id { get; set; }
        /// <summary>
        /// 专业组名称
        /// </summary>
     public string SpecialtyName { get; set; }
        /// <summary>
        /// 颜色设置
        /// </summary>
     public string SpecialtyColor { get; set; }
        /// <summary>
        /// 关联科室ID
        /// </summary>
     public int DepartmentID { get; set; }
        /// <summary>
        /// 带教
        /// </summary>
     public string Teaching { get; set; }
        /// <summary>
        /// 组长
        /// </summary>
     public string GroupLeader { get; set; }
        /// <summary>
        /// 组员
        /// </summary>
     public string GropCrew { get; set; }

    }
}
