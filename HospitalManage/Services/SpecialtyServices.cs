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
            int res = conn.Execute("Specialty_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
            return res;
        }
        public List<Users> GetSpecialties(int DepartmentID)
        {
            MySqlConnection conn = dapper.GetConnection();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("DepartmentID", DepartmentID);
            return conn.Query<Users>("Specialty_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
        }
    }
}
