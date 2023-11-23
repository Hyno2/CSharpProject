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
    public partial class FindID : Form
    {
        public FindID()
        {
            InitializeComponent();
            // 폼에 KeyDown 이벤트 핸들러 등록
            this.KeyPreview = true;
            this.KeyDown += FormEvent.CloseFormOnEscKey;
        }


        // 취소 버튼 눌렀을때
        private void CancelFIDbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 확인 버튼 눌렀을때
        private void FNCheckbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // 아이디 찾기
                string findIdByName = DBUserHelper.FindUserIdByName(FNametextBox.Text);
                if(findIdByName != null)
                {
                    MessageBox.Show($"아이디 : {findIdByName}");
                }
                else
                {
                    MessageBox.Show("아이디를 찾을수 없습니다!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}");

            }
           

        }

    }
}
