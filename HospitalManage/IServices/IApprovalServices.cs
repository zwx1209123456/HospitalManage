using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IApprovalServices
    {
        /// <summary>
        /// 添加业务
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        int Add(Approval approval);
        /// <summary>
        /// 显示业务信息
        /// </summary>
        /// <returns></returns>
        List<Approval> Show();
        /// <summary>
        /// 根据id反填业务信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Approval Get(int Id);
        /// <summary>
        /// 修改业务信息
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        int Update(Approval approval);
    }
}
