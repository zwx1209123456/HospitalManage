using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IDepartmentServices
    {
        /// <summary>
        /// 添加科室
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        int Add(Department department);
        /// <summary>
        /// 显示科室
        /// </summary>
        /// <returns></returns>

        List<Department> GetDepartments();
        /// <summary>
        /// 删除科室
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        int Delete(int Id);
        /// <summary>
        /// 修改科室
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>

        int Update(Department department);

    }
}
