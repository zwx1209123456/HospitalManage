using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IRuleServices
    {
        /// <summary>
        /// 添加排班规则
        /// </summary>
        /// <param name="arrangerule"></param>
        /// <returns></returns>
        int Add(Arrangerule arrangerule);
        /// <summary>
        /// 显示排班规则
        /// </summary>
        /// <returns></returns>
        List<Arrangerule> Show();
        /// <summary>
        /// 删除排班规则
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);
        /// <summary>
        /// 修改排班规则
        /// </summary>
        /// <param name="arrangerule"></param>
        /// <returns></returns>
        int Update(Arrangerule arrangerule);
        /// <summary>
        /// 根据id，反填排班规则
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Get(int Id);
    }
}
