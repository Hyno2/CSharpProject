namespace 맛집API해보기
{
    partial class MyPlace
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPlace));
            this.User_label = new System.Windows.Forms.Label();
            this.MyPlace_dataGridView = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPlace_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.BackColor = System.Drawing.Color.White;
            this.User_label.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.User_label.Location = new System.Drawing.Point(45, 73);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(0, 40);
            this.User_label.TabIndex = 0;
            // 
            // MyPlace_dataGridView
            // 
            this.MyPlace_dataGridView.AllowUserToAddRows = false;
            this.MyPlace_dataGridView.AllowUserToDeleteRows = false;
            this.MyPlace_dataGridView.AllowUserToOrderColumns = true;
            this.MyPlace_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyPlace_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyPlace_dataGridView.Location = new System.Drawing.Point(34, 296);
            this.MyPlace_dataGridView.Name = "MyPlace_dataGridView";
            this.MyPlace_dataGridView.ReadOnly = true;
            this.MyPlace_dataGridView.RowTemplate.Height = 23;
            this.MyPlace_dataGridView.Size = new System.Drawing.Size(582, 242);
            this.MyPlace_dataGridView.TabIndex = 1;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.BackgroundImage = global::맛집API해보기.Properties.Resources.제목을_입력해주세요__002;
            this.Delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.FlatAppearance.BorderSize = 0;
            this.Delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(535, 208);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(57, 53);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MyPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.MyPlace_dataGridView);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MyPlace";
            this.Size = new System.Drawing.Size(680, 580);
            ((System.ComponentModel.ISupportInitialize)(this.MyPlace_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.DataGridView MyPlace_dataGridView;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
