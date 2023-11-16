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
        public Login()
        {
            InitializeComponent();
            this.buttonLogin.Click += buttonLogin_Click;
            this.buttonCancel.Click += buttonCancel_Click;
        }

        // 취소버튼 눌렀을때
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // 로그인버튼 눌렀을때
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login_id = textBoxID.Text;
                string login_password = textBox2PWD.Text;

                bool login = DBUserHelper.Login(login_id, login_password);

                if (login)
                {
                    // 현재 폼을 가립니다.
                    this.Hide();

                    // Form1을 엽니다.
                    Form1 form1 = new Form1();
                    form1.Closed += (s, args) => this.Close(); // Form1이 닫힐 때 현재 폼도 닫히도록 합니다.
                    form1.Show();


                }
                else
                {
                    MessageBox.Show("아이디/암호를 확인해 주세요.");
                }
            }
            catch (Exception)
            {
                // handle exception
            }
        }

        //public string LoginID
        //{
        //    get;
        //    private set;
        //}

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
