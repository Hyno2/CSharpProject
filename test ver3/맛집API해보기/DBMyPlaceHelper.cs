using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 맛집API해보기
{
    public class DBMyPlaceHelper
    {
        private static SqlConnection conn = new SqlConnection();

        // DB 연동하는 메소드
        public static void ConnectDB()
        {
            string dataSource = "local";
            string db = "User_info"; // DB명
            string security = "SSPI";
            conn.ConnectionString =
                $"Data Source=({dataSource}); initial Catalog={db};" +
                $"integrated Security={security};" +
                "Timeout=3";

            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public static void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public static void RegisterMyPlace(string userId, string bz_nm, string fd_cs, string gng_cs)
        {
            try
            {
                ConnectDB();
                string insertQuery = $"INSERT INTO MyPlace (User_ID, BZ_NM, FD_CS, GNG_CS) VALUES (@UserId, @bz_nm, @fd_cs, @gng_cs)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@UserId", userId);
                    insertCommand.Parameters.AddWithValue("@bz_nm", bz_nm);
                    insertCommand.Parameters.AddWithValue("@fd_cs", fd_cs);
                    insertCommand.Parameters.AddWithValue("@gng_cs", gng_cs);

                    insertCommand.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }
       
        public static DataTable GetMyPlaceData(string userId)
        {
            ConnectDB();
            try
            {
                string selectQuery = $"SELECT * FROM MyPlace where User_ID = '{userId}'";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable myPlaceData = new DataTable();
                    adapter.Fill(myPlaceData);
                   
                    return myPlaceData;
                }
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
