using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
  //  using Services;
   public interface IArrangeoperationServices
    {
        /// <summary>
        /// 添加手术申请
        /// </summary>
        /// <param name="arrangeoperation"></param>
        /// <returns></returns>
        int Add(Arrangeoperation arrangeoperation);
        /// <summary>
        /// 显示手术申请
        /// </summary>
        /// <returns></returns>
        List<Arrangeoperation> Show();
        /// <summary>
        /// 删除手术申请
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);
        /// <summary>
        /// 根据id，反填数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Arrangeoperation Get(int Id);
        /// <summary>
        /// 修改手术申请
        /// </summary>
        /// <param name="arrangeoperation"></param>
        /// <returns></returns>
        int Update(Arrangeoperation arrangeoperation);
    }
}
