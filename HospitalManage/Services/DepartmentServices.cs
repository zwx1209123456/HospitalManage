using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using Models;
    using IServices;
    using System.Data.SqlClient;
    using CommHelps;
    using MySql.Data.MySqlClient;
    using Dapper;

    public class DepartmentServices : IDepartmentServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 科室添加
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public int Add(Department department)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_DepartmentName", department.DepartmentName);
            int res = conn.Execute("Department_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return res;
        }
        /// <summary>
        /// 科室删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_Id",Id);//参数没写
            return conn.Execute("Department_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            throw new NotImplementedException();
        }
        /// <summary>
        /// 科室显示
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartments()
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            return conn.Query<Department>("Department_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }

        /// <summary>
        /// 修改科室
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public int Update(Department department)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", department.Id);
            parameters.Add("@_DepartmentName", department.DepartmentName);
            int res = conn.Execute("Department_update", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return res;
        }
    }
}
