﻿namespace GoodRestaurantAPI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBox2PWD = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelPWD = new System.Windows.Forms.LinkLabel();
            this.linkLabelSign = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.linkLabelID = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(233, 182);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 21);
            this.textBoxID.TabIndex = 0;
            // 
            // textBox2PWD
            // 
            this.textBox2PWD.Location = new System.Drawing.Point(233, 217);
            this.textBox2PWD.Name = "textBox2PWD";
            this.textBox2PWD.Size = new System.Drawing.Size(150, 21);
            this.textBox2PWD.TabIndex = 1;
            this.textBox2PWD.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(401, 182);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(65, 56);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // linkLabelPWD
            // 
            this.linkLabelPWD.AutoSize = true;
            this.linkLabelPWD.Location = new System.Drawing.Point(338, 275);
            this.linkLabelPWD.Name = "linkLabelPWD";
            this.linkLabelPWD.Size = new System.Drawing.Size(77, 12);
            this.linkLabelPWD.TabIndex = 4;
            this.linkLabelPWD.TabStop = true;
            this.linkLabelPWD.Text = "비밀번호찾기";
            this.linkLabelPWD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPWD_LinkClicked);
            // 
            // linkLabelSign
            // 
            this.linkLabelSign.AutoSize = true;
            this.linkLabelSign.Location = new System.Drawing.Point(431, 275);
            this.linkLabelSign.Name = "linkLabelSign";
            this.linkLabelSign.Size = new System.Drawing.Size(53, 12);
            this.linkLabelSign.TabIndex = 5;
            this.linkLabelSign.TabStop = true;
            this.linkLabelSign.Text = "회원가입";
            this.linkLabelSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSign_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "비밀번호";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(481, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 56);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "종료";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // linkLabelID
            // 
            this.linkLabelID.AutoSize = true;
            this.linkLabelID.Location = new System.Drawing.Point(255, 275);
            this.linkLabelID.Name = "linkLabelID";
            this.linkLabelID.Size = new System.Drawing.Size(65, 12);
            this.linkLabelID.TabIndex = 9;
            this.linkLabelID.TabStop = true;
            this.linkLabelID.Text = "아이디찾기";
            this.linkLabelID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelID_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodRestaurantAPI.Properties.Resources.맛집쓰_로고;
            this.pictureBox1.Location = new System.Drawing.Point(161, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 152);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelSign);
            this.Controls.Add(this.linkLabelPWD);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBox2PWD);
            this.Controls.Add(this.textBoxID);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBox2PWD;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelPWD;
        private System.Windows.Forms.LinkLabel linkLabelSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.LinkLabel linkLabelID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}