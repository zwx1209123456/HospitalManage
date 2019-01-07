using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 接龙小组
    /// </summary>
   public  class ChainsGroup
    {
        public int Id { get; set; }
        /// <summary>
        /// 组长
        /// </summary>
        public string  GroupLeader { get; set; }
        /// <summary>
        /// 组员
        /// </summary>
        public string  GropCrew { get; set; }
        /// <summary>
        /// 班次Id
        /// </summary>
        public int ClassesId { get; set; }
        /// <summary>
        /// 接龙组序
        /// </summary>
        public int SortNumber { get; set; }
   
        
    }
}
