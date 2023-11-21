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

        //즐겨찾기 등록
        public static void RegisterMyPlace(string userId, string bz_nm, string fd_cs, string gng_cs, string tlno)
        {
            try
            {
                ConnectDB();
                string insertQuery = $"INSERT INTO MyPlace (User_ID, BZ_NM, FD_CS, GNG_CS,TLNO) VALUES (@UserId, @bz_nm, @fd_cs, @gng_cs, @tlno)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@UserId", userId);
                    insertCommand.Parameters.AddWithValue("@bz_nm", bz_nm);
                    insertCommand.Parameters.AddWithValue("@fd_cs", fd_cs);
                    insertCommand.Parameters.AddWithValue("@gng_cs", gng_cs);
                    insertCommand.Parameters.AddWithValue("@tlno", tlno);

                    insertCommand.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        //현재 로그인된 Id에 데이터 넣기
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

        //삭제 쿼리
        public static void DeleteMyPlace(string userId, string bz_nm)
        {
            try
            {
                ConnectDB();
                string deleteQuery = $"DELETE FROM MyPlace WHERE User_ID = '{userId}' AND BZ_NM = @bz_nm";
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                {
                    deleteCommand.Parameters.AddWithValue("@bz_nm", bz_nm);
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show(bz_nm + "을(를) 즐겨찾기에서 삭제했습니다.");
                }
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
