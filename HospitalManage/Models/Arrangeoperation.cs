using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// 手术申请表
    /// </summary>
   public class Arrangeoperation
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 手术间id
        /// </summary>
        public int OperationID { get; set; }
        /// <summary>
        /// 科室id
        /// </summary>
        public int DepartmentID { get; set; }
        /// <summary>
        /// 手术名称
        /// </summary>
        public string OperationName { get; set; }
        /// <summary>
        /// 主刀医生
        /// </summary>
        public string OperatorDoctor { get; set; }
        /// <summary>
        /// 器械
        /// </summary>
        public string Instrument { get; set; }
        /// <summary>
        /// 巡回
        /// </summary>
        public string Tour { get; set; }
        /// <summary>
        /// 麻醉师
        /// </summary>
        public string Anesthetist { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string PatientAge { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string PatientSex { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string OperationNames { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 发布状态
        /// </summary>
         public int Status { get; set; }
        /// <summary>
        /// 手术台次
        /// </summary>
        public int Were { get; set; }
    }
}
