using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 班次表
    /// </summary>
    public class Classes
    {
        /// <summary>
        /// 主键ID1111
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 班次颜色
        /// </summary>
        public string ClassesColor { get; set; }
        /// <summary>
        /// 班次名称
        /// </summary>
        public string ClassesName { get; set; }
        /// <summary>
        /// 上班时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 下班时间
        /// </summary>
        public DateTime LastTime { get; set; }
        /// <summary>
        /// 班次类型
        /// </summary>
        public string ClasserType { get; set; }
        /// <summary>
        /// 有效排班日
        /// </summary>
        public string ValidClasses { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
