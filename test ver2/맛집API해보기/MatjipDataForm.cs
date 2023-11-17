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
    public partial class MatjipDataForm : Form
    {
        public MatjipDataForm()
        {
            InitializeComponent();
        }
        private void MatjipDataForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            dataGridView1.DataSource = DataManager.SelectMatJips;
        }

        private void KoreanFood_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("한식");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void ChineseFood_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("중식");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void JapaneseFood_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("일식");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void ItalianFood_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("양식");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void WorldFood_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("세계요리");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void Fusion_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("퓨전/뷔페");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void Desert_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("디저트/베이커리");
            
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void TraditionalTea_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("전통차/커피전문점");

            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

        private void SpecialBar_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // 이전 데이터 지우기
            DataManager.Cg_Load("특별한 술집");
            dataGridView1.DataSource = DataManager.SelectCategoryMatJips;
        }

     
    }
}
