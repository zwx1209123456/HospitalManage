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
   public class RuleServices:IRuleServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加排班规则
        /// </summary>
        /// <param name="arrangerule"></param>
        /// <returns></returns>
        public int Add(Arrangerule arrangerule)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_IsEnabled", arrangerule.IsEnabled);
                parameters.Add("@_ArrangeRuleSet", arrangerule.ArrangeRuleSet);
                parameters.Add("@_TimeOne", arrangerule.TimeOne);
                parameters.Add("@_ClassesOne", arrangerule.ClassesOne);
                parameters.Add("@_TimeTwo", arrangerule.TimeTwo);
                parameters.Add("@_TimeThree", arrangerule.TimeThree);
                parameters.Add("@_ClassesTwo", arrangerule.ClassesTwo);
                int res = conn.Execute("RuleAdd", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
        /// <summary>
        /// 显示排班规则
        /// </summary>
        /// <returns></returns>
        public List<Arrangerule> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();

                return conn.Query<Arrangerule>("RuleShow", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }
        /// <summary>
        /// 删除排班规则
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("RuleDelete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// 修改排班规则
        /// </summary>
        /// <param name="arrangerule"></param>
        /// <returns></returns>
        public int Update(Arrangerule arrangerule)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", arrangerule.Id);
                parameters.Add("@_IsEnabled", arrangerule.IsEnabled);
                parameters.Add("@_ArrangeRuleSet", arrangerule.ArrangeRuleSet);
                parameters.Add("@_TimeOne", arrangerule.TimeOne);
                parameters.Add("@_ClassesOne", arrangerule.ClassesOne);
                parameters.Add("@_TimeTwo", arrangerule.TimeTwo);
                parameters.Add("@_TimeThree", arrangerule.TimeThree);
                parameters.Add("@_ClassesTwo", arrangerule.ClassesTwo);
                int res = conn.Execute("RuleUpdate", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
