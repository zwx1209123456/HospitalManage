using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface ISpecialtyServices
    {
        /// <summary>
        /// 添加专业组
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        int Add(Specialty specialty);
        /// <summary>
        /// 根据科室获取用户
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        List<Users> GetUsers(int DepartmentID);
        /// <summary>
        /// 获取专业组
        /// </summary>
        /// <returns></returns>
        List<Specialty> GetSpecialties();
    }
}
