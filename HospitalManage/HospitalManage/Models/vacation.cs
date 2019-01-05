using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class vacation
    {
        public int Id { get; set; }
        /// <summary>
        /// 年假开始时间
        /// </summary>
        
        public string StartAnnual { get; set; }
        
        /// <summary>
        /// 年假结束时间
        /// </summary>
        public string LastAnnual { get; set; }
        /// <summary>
        /// 年假申请开始时间
        /// </summary>
     
        public string BeginAnnualApply { get; set; }
   
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
       
        /// <summary>
        /// 年假最晚申请时间
        /// </summary>
        public string LastAnnualApply { get; set; }
       
        /// <summary>
        /// 年假系统确认时间
        /// </summary>
        public string AnnualSystemValidation { get; set; }

    }
}
