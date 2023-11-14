using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 맛집API해보기
{
    public partial class Login : Form
    {
        //DB 연결 및 테이블 데이터 다룰 때 필요한 객체들
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        private const string TABLENAME = " user_info ";//테이블명

        // DB연동하는 메소드
        private static void ConnectDB()
        {
            string dataSource = "local";
            string db = "user_info"; //DB명
            string security = "SSPI";
            conn.ConnectionString =
                $"Data Source=({dataSource}); initial Catalog={db};" +
                $"integrated Security={security};" +
                "Timeout=3";
            conn.Open();
        }

        public Login()
        {
            InitializeComponent();
            this.buttonLogin.Click += buttonLogin_Click;
            this.buttonCancel.Click += buttonCancel_Click;
        }

        // 종료 버튼 클릭 시

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            // 종료함
            this.Close();
        }

        // 로그인 버튼 클릭 시
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // DB연동
            ConnectDB();
            bool login = false; // 로그인 여부 확인
            string login_id = textBoxID.Text; // 로그인 ID
            string login_password = textBox2PWD.Text; // 로그인 PASSWORD

            // 로그인 할 id 를 검색
            string sql = "SELECT * FROM information WHERE User_id=\'" + login_id + "\' "; // logtable --> sql상에서 테이블 이름
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                // 검색된 아이디와 비밀번호가 일치한 경우 로그인된 것으로 봄
                if (login_id == (string)mdr["User_id"] && login_password == (string)mdr["User_passWord"]) //sql상에 컬럼이름 userid, userpwd
                    login = true;
            }
            mdr.Close();

            if (login)
            {
                this.LoginID = this.textBoxID.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show("아이디/암호를 확인해 주세요.");
            }
        }

        public string LoginID
        {
            get;
            private set;
        }

        // 아이디 찾기
        private void linkLabelID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindID findID = new FindID();
            findID.ShowDialog();
        }

        // 비밀번호 찾기
        private void linkLabelPWD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindPWD findPWD = new FindPWD();
            findPWD.ShowDialog();
        }

        // 회원가입
        private void linkLabelSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Sign_Up sign_Up = new Sign_Up();
           sign_Up.ShowDialog();

        }
    }

    }

