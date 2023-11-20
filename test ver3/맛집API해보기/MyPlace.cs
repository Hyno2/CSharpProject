using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 맛집API해보기
{
    public partial class MyPlace : UserControl
    {
        public MyPlace()
        {
            InitializeComponent();
        }

        private void MyPlace_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
                                            
            BindMyPlaceData(); // MyPlace 테이블을 조회하여 데이터를 DataGridView에 바인딩
        }


        private void BindMyPlaceData()
        {
            
            try
            {
                // MyPlace 테이블의 데이터 가져오기
                DataTable myPlaceData = DBMyPlaceHelper.GetMyPlaceData(DBUserHelper.GetCurrentUserId());
                
                // DataGridView에 데이터 바인딩
                dataGridView1.DataSource = myPlaceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

