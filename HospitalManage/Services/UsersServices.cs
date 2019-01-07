using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using CommHelps;
    using Models;
    using MySql.Data.MySqlClient;
    using Dapper;
    using IServices;
    public class UsersServices : IUsersServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(Users users)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_DepartmentID", users.DepartmentID);
                parameters.Add("@_UserName", users.UserName);
                parameters.Add("@_UserNumber", users.UserNumber);
                parameters.Add("@_DutyID", users.DutyID);
                parameters.Add("@_TierID", users.TierID);
                parameters.Add("@_AnnualDay", users.AnnualDay);
                parameters.Add("@_EntryTime", users.EntryTime);
                int res = conn.Execute("Users_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示用户的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Users> ShowUsers()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                
                DynamicParameters parameters = new DynamicParameters();

                return conn.Query<Users>("Users_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DeleteUsers(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("Users_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 根据id获取用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetUsers(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
              
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("Users_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// 修改用户的信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int UpdateUsers(Users users)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
              
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", users.Id);
                parameters.Add("@_DepartmentID", users.DepartmentID);
                parameters.Add("@_UserName", users.UserName);
                parameters.Add("@_UserNumber", users.UserNumber);
                parameters.Add("@_DutyID", users.DutyID);
                parameters.Add("@_TierID", users.TierID);
                parameters.Add("@_AnnualDay", users.AnnualDay);
                parameters.Add("@_EntryTime", users.EntryTime);
                int res = conn.Execute("Users_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                //var res = conn.Execute("Users_Update", parameters );
                return res;
            }
        }

    }
}
