using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 排班表
    /// </summary>
   public class Arrange
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 班次
        /// </summary>
        public int ClassesID { get; set; }
        /// <summary>
        /// 是否发布
        /// </summary>
        public int Issue { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 排班状态
        /// </summary>
        public int ArrangeState { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Dates { get; set; }
        public string UserNames { get; set; }
    }
}
