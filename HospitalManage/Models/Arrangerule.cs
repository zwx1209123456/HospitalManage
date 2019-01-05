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
        /// 是否生效
        /// </summary>
        public int IsEnabled { get; set; }
        /// <summary>
        /// 排班规则设置
        /// </summary>
        public string ArrangeRuleSet { get; set; }

    }
}
