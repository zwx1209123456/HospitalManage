using System.Data.SqlClient;
using System.Net.Configuration;
using MySql.Data.MySqlClient;

namespace CommHelps
{
    public class DapperHelper
    {
        public static DapperHelper _dapperHelper = null;

        public readonly string _cnnstr = "";

        public DapperHelper()
        {
<<<<<<< HEAD
           // _cnnstr = "server=.;database=DataMip;uid=sa;pwd=123456";
			_cnnstr= "server=172.25.53.46;port=; database=hospital;username=root;password=123456;";//MySQL
=======
            _cnnstr = "server=.;database=DataMip;uid=sa;pwd=111111";
            // //_cnnstr= "server=localhost;port=; database=test;username=root;password=dinglinBAyue^;";//MySQL
           
>>>>>>> ef51ad6fd9cb1f7b8524c97246cc72d68cae04ba
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DapperHelper Instance()
        {
            if (_dapperHelper == null)
            {
                _dapperHelper = new DapperHelper();
            }
            return _dapperHelper;
        }

        public MySqlConnection GetConnection()
        {
           // var conn = new SqlConnection(_cnnstr);
            var conn = new MySqlConnection(_cnnstr);
            conn.Open();
            return conn;
        }
    }
}
