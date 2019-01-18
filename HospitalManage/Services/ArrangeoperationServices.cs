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
   public class ArrangeoperationServices:IArrangeoperationServices
    {
        DapperHelper dapper = new DapperHelper();
        /// <summary>
        /// 添加手术申请
        /// </summary>
        /// <param name="arrangeoperation"></param>
        /// <returns></returns>
        public int Add(Arrangeoperation arrangeoperation)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_OperationID", arrangeoperation.OperationID);
                parameters.Add("@_DepartmentID", arrangeoperation.DepartmentID);
                parameters.Add("@_OperationName", arrangeoperation.OperationName);
                parameters.Add("@_OperatorDoctor", arrangeoperation.OperatorDoctor);
                parameters.Add("@_Instrument", arrangeoperation.Instrument);
                parameters.Add("@_Tour", arrangeoperation.Tour);
                parameters.Add("@_Anesthetist", arrangeoperation.Anesthetist);
                parameters.Add("@_PatientName", arrangeoperation.PatientName);
                parameters.Add("@_PatientAge", arrangeoperation.PatientAge);
                parameters.Add("@_PatientSex", arrangeoperation.PatientSex);
                parameters.Add("@_Status", arrangeoperation.Status);
                int res = conn.Execute("operation_Add", parameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }

        /// <summary>
        /// 显示手术申请
        /// </summary>
        /// <returns></returns>
        public List<Arrangeoperation> Show()
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                return conn.Query<Arrangeoperation>("operation_Show", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

        /// <summary>
        /// 删除手术申请
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.Execute("operation_Delete", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// 根据id，反填数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Arrangeoperation Get(int Id)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@_Id", Id);
                return conn.QueryFirst<Arrangeoperation>("operation_Get", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// 修改手术申请
        /// </summary>
        /// <param name="arrangeoperation"></param>
        /// <returns></returns>
        public int Update(List<Arrangeoperation> operations)
        {
            using (MySqlConnection conn = dapper.GetConnection())
            {
                List<DynamicParameters> dynamicParameters = new List<DynamicParameters>();
                foreach (var arrangeoperation in operations)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@_Id", arrangeoperation.Id);
                    parameters.Add("@_OperationID", arrangeoperation.OperationID);
                    parameters.Add("@_DepartmentID", arrangeoperation.DepartmentID);
                    parameters.Add("@_OperationName", arrangeoperation.OperationName);
                    parameters.Add("@_OperatorDoctor", arrangeoperation.OperatorDoctor);
                    parameters.Add("@_Instrument", arrangeoperation.Instrument);
                    parameters.Add("@_Tour", arrangeoperation.Tour);
                    parameters.Add("@_Anesthetist", arrangeoperation.Anesthetist);
                    parameters.Add("@_PatientName", arrangeoperation.PatientName);
                    parameters.Add("@_PatientAge", arrangeoperation.PatientAge);
                    parameters.Add("@_PatientSex", arrangeoperation.PatientSex);
                    parameters.Add("@_Status", arrangeoperation.Status);
                    parameters.Add("@_Were", arrangeoperation.Were);
                    parameters.Add("@_publishTime", arrangeoperation.publishTime);
                    parameters.Add("@_OpeTime", arrangeoperation.OpeTime); 
                    dynamicParameters.Add(parameters);
                }
             
                int res = conn.Execute("operation_Update", dynamicParameters, commandType: System.Data.CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
