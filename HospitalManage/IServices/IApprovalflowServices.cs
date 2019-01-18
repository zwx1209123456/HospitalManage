using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IApprovalflowServices
    {
        /// <summary>
        /// 添加审批流程配置信息
        /// </summary>
        /// <param name="approvalflow"></param>
        /// <returns></returns>
        int Add(Approvalflow approvalflow);
        /// <summary>
        /// 显示审批流程配置信息
        /// </summary>
        /// <returns></returns>
        List<Approvalflow> Show();
        /// <summary>
        /// 删除审批流程配置信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);
        /// <summary>
        /// 根据ID反填审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Approvalflow Get(int Id);
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        int Update(Approvalflow approvalflow);
    }
}
