using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IUsersServices
    {
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int AddUsers(Users users);
        /// <summary>
        /// 显示用户的所有信息
        /// </summary>
        /// <returns></returns>
        List<Users> ShowUsers();
        /// <summary>
        /// 删除用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteUsers(int Id);
        /// <summary>
        /// 根据id获取用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetUsers(int Id);
        /// <summary>
        /// 修改用户的信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int UpdateUsers(Users users);
    }
}
