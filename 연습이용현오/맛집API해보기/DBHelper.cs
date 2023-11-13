using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 맛집API해보기
{
    public class DBHelper
    {
        //DB 연결 및 테이블 데이터 다룰 때 필요한 객체들
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        private const string TABLENAME = " information ";//테이블명

        //DB 연결하는 메서드
        private static void ConnectDB()
        {
            string dataSource = "local";
            string db = "information"; //DB명
            string security = "SSPI";
            conn.ConnectionString =
                $"Data Source=({dataSource}); initial Catalog={db};" +
                $"integrated Security={security};" +
                "Timeout=3";
            conn.Open();

        }


    }

}
