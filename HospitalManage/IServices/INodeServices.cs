using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface INodeServices
    {
        /// <summary>
        /// 添加审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        int Add(Node node);
        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        List<Node> Show();
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
        Node Get(int Id);
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <param name="approvalcondition"></param>
        /// <returns></returns>
        int Update(Node node);
    }
}
