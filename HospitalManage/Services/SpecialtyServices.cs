using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using CommHelps;
    using Dapper;
    using IServices;
    using Models;
    using MySql.Data.MySqlClient;

    public class SpecialtyServices : ISpecialtyServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        public int Add(Specialty specialty)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_SpecialtyName", specialty.SpecialtyName);
            parameters.Add("@_SpecialtyColor", specialty.SpecialtyColor);
            parameters.Add("@_DepartmentID", specialty.DepartmentID);
            parameters.Add("@_GropCrew", specialty.GropCrew);
            parameters.Add("@_GroupLeader", specialty.GroupLeader);
            parameters.Add("@_Teaching", specialty.Teaching);
            parameters.Add("@_GropCrewName", specialty.GropCrewName);
            parameters.Add("@_GroupLeaderName", specialty.GroupLeaderName);
            parameters.Add("@_TeachingName", specialty.TeachingName);
            int result = conn.Execute("Specialty_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
        /// <summary>
        /// 获取用户表
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public List<Users> GetUsers(int DepartmentID)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("DepartmentID", DepartmentID);
            return conn.Query<Users>("Specialty_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }
        /// <summary>
        /// 专业组显示
        /// </summary>
        /// <returns></returns>
        public List<Specialty> GetSpecialties()
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            return conn.Query<Specialty>("Specialty_Shows", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }
        public int Delete(int Id)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", Id);
            return conn.Execute("Specialty_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
        }
        public int Update(Specialty specialty)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id", specialty.Id);
            parameters.Add("@_SpecialtyName", specialty.SpecialtyName);
            parameters.Add("@_SpecialtyColor", specialty.SpecialtyColor);
            parameters.Add("@_DepartmentID", specialty.DepartmentID);
            parameters.Add("@_GropCrew", specialty.GropCrew);
            parameters.Add("@_GroupLeader", specialty.GroupLeader);
            parameters.Add("@_Teaching", specialty.Teaching);
            parameters.Add("@_GropCrewName", specialty.GropCrewName);
            parameters.Add("@_GroupLeaderName", specialty.GroupLeaderName);
            parameters.Add("@_TeachingName", specialty.TeachingName);
            int result = conn.Execute("Specialty_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
       public Specialty GetSpecialty(int Id)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@_Id",Id);
            return conn.QueryFirst<Specialty>("Specialty_GetSpecialty", parameters, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}