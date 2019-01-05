using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 权限表
    /// </summary>
  public  class Power
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PowerName { get; set; }
        /// <summary>
        /// 权限URL
        /// </summary>
        public string PowerUrl { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnabled { get; set; }
    }
}
