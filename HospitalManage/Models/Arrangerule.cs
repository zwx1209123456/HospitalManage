using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// 排班规则
    /// </summary>
   public class Arrangerule
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 班次id
        /// </summary>
        public int ClassesId { get; set; }
        /// <summary>
        /// 是否生效
        /// </summary>
        public int IsEnabled { get; set; }
        
        /// <summary>
        /// 时间1
        /// </summary>
        public string TimeOne { get; set; }
        
        /// <summary>
        /// 时间2
        /// </summary>
        public string TimeTwo { get; set; }
        /// <summary>
        /// 时间3
        /// </summary>
        public string TimeThree { get; set; }
        
        /// <summary>
        /// 班次名称
        /// </summary>
        public string ClassesName { get; set; }
        public string ClassesName1 { get; set; }
        public int ClassesIds { get; set; }
        
    }
}
