using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using Models;
    using IServices;
    using CommHelps;
    using System.Data.SqlClient;
    using MySql.Data.MySqlClient;
    using Dapper;
    /// <summary>
    /// 班次
    /// </summary>
    public class ClassesService : IClassesService
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加班次
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public int ClassesAdd(Classes classes)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                //conn.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_ClassesColor", classes.ClassesColor, null, null, null, null);
                parameters.Add("_ClassesName", classes.ClassesName, null, null, null, null);
                parameters.Add("_StartTime", classes.StartTime, null, null, null, null);
                parameters.Add("_LastTime", classes.LastTime, null, null, null, null);
                parameters.Add("_ClasserType", classes.ClasserType, null, null, null, null);
                parameters.Add("_ValidClasses", classes.ValidClasses, null, null, null, null);
                parameters.Add("_Sort", classes.Sort, null, null, null, null);

                int res = conn.Execute("sp_Classes_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 删除班次
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

            public int ClassesDelete(int Id)
            {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_Id", Id);
                return conn.Execute("sp_Classes_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改班次
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
            public int ClassesUpdate(Classes classes)
            {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_Id", classes.Id);
                parameters.Add("_ClassesColor", classes.ClassesColor);
                parameters.Add("_ClassesName", classes.ClassesName);
                parameters.Add("_StartTime", classes.StartTime);
                parameters.Add("_LastTime", classes.LastTime);
                parameters.Add("_ClasserType", classes.ClasserType);
                parameters.Add("_ValidClasses", classes.ValidClasses);
                parameters.Add("_Soet", classes.Sort);
                int res = conn.Execute("sp_Classes_Update", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }

            public List<Classes> GetClasses()
            {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Classes>("classes_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();

            }
        }
        }
    }

