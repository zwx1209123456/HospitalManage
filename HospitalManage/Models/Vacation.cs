using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //假期管理表
   public  class Vacation
    {
        public int Id { get; set; }
   
        /// <summary>
        /// 每日申请上限
        /// </summary>
        public int DayApplyLimit { get; set; }
     
        /// <summary>
        /// 每周申请上限
        /// </summary>
        public int WeekApplyLimit { get; set; }
        
        /// <summary>
        /// 每月申请上限
        /// </summary>
        public int MonthApplyLimit { get; set; }
    }
}
