using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface IApprovalconditionServices
    {
        /// <summary>
        /// 添加审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        int Add(Approvalcondition approvalcondition);
        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
         List<Approvalcondition> Show();
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);
        /// <summary>
        /// 根据ID反填审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Approvalcondition Get(int Id);
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        int Update(Approvalcondition approvalcondition);
    }
}
