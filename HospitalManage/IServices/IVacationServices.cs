using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface IVacationServices
    {
        /// <summary>
        /// 添加假期信息
        /// </summary>
        /// <param name="vacation"></param>
        /// <returns></returns>
        int Add(Vacation vacation);
        /// <summary>
        /// 显示假期信息
        /// </summary>
        /// <returns></returns>
         List<Vacation> Show();
        /// <summary>
        /// 删除假期信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
         int Delete(int Id);
        /// <summary>
        /// 反填假期信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
         Vacation Get(int Id);
        /// <summary>
        /// 修改假期信息
        /// </summary>
        /// <param name="vacation"></param>
        /// <returns></returns>
         int Update(Vacation vacation);
    }
}
