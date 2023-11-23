﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodRestaurantAPI
{
    public partial class FindPWD : Form
    {
        public FindPWD()
        {
            InitializeComponent();
            // 폼에 KeyDown 이벤트 핸들러 등록
            this.KeyPreview = true;
            this.KeyDown += FormEvent.CloseFormOnEscKey;
        }



        // 취소 버튼 눌렀을 때
        private void CancelFPWDbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 확인 버튼 눌렀을 때
        private void FNCheckbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // 비밀번호 찾기 (질문 기반)
                string findPWD = DBUserHelper.FindUserPWDByQues(FNametextBox.Text,FQtextBox.Text);

                if (findPWD != null)
                {
                    MessageBox.Show($"비밀번호: {findPWD}");
                }
                else
                {
                    MessageBox.Show("비밀번호를 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}");
            }

        }





    }
}
