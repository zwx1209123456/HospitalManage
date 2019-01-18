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
   public class NodeServices:INodeServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int Add(Node node)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_NodeName", node.NodeName);
                parameters.Add("@_Creator", node.Creator);
                parameters.Add("@_CreateTime", node.CreateTime);
                int res = conn.Execute("node_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示用户的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Node> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {

                DynamicParameters parameters = new DynamicParameters();

                return conn.Query<Node>("node_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("node_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 根据id获取用户的信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Node Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Node>("node_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);

            }
        }
        /// <summary>
        /// 修改用户的信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int Update(Node node)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", node.Id);
                parameters.Add("@_NodeName", node.NodeName);
                parameters.Add("@_Creator", node.Creator);
                parameters.Add("@_CreateTime", node.CreateTime);
                int res = conn.Execute("node_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
