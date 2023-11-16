using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 맛집API해보기
{
    public partial class gu_select : Form
    {
        public gu_select()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.matJips;
            DBHelper.SelectQ(buttton.text)


        }
        // DataGridView에 데이터 바인딩하는 함수
        public void BindDataToDataGridView(DataTable dataTable)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }              

        
        public void Usage()
        {
            // 예시로 "" 키워드로 데이터를 조회하여 DataTable 얻기
            DataTable resultTable = DBHelper.SelectQ("중구");

            // DataGridView에 데이터 바인딩
            BindDataToDataGridView(resultTable);
        }


    }
}
