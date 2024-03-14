namespace baitaplonC_
{
    partial class Gdchinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gdchinh));
            btnDangxuat = new Button();
            btnTtcanhan = new Button();
            btnQltk = new Button();
            btnQlhh = new Button();
            btnQlgianhap = new Button();
            SuspendLayout();
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(255, 128, 0);
            btnDangxuat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangxuat.Location = new Point(969, 75);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(173, 63);
            btnDangxuat.TabIndex = 2;
            btnDangxuat.Text = "Đăng Xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // btnTtcanhan
            // 
            btnTtcanhan.BackColor = Color.Wheat;
            btnTtcanhan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTtcanhan.Location = new Point(130, 269);
            btnTtcanhan.Name = "btnTtcanhan";
            btnTtcanhan.Size = new Size(312, 57);
            btnTtcanhan.TabIndex = 3;
            btnTtcanhan.Text = "Thông Tin Cá Nhân";
            btnTtcanhan.UseVisualStyleBackColor = false;
            // 
            // btnQltk
            // 
            btnQltk.BackColor = Color.Wheat;
            btnQltk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQltk.Location = new Point(130, 350);
            btnQltk.Name = "btnQltk";
            btnQltk.Size = new Size(312, 57);
            btnQltk.TabIndex = 4;
            btnQltk.Text = "Quản Lý Tài Khoản";
            btnQltk.UseVisualStyleBackColor = false;
            btnQltk.Click += btnQltk_Click;
            // 
            // btnQlhh
            // 
            btnQlhh.BackColor = Color.Wheat;
            btnQlhh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQlhh.Location = new Point(130, 430);
            btnQlhh.Name = "btnQlhh";
            btnQlhh.Size = new Size(312, 57);
            btnQlhh.TabIndex = 5;
            btnQlhh.Text = "Quản Lý Hàng Hóa";
            btnQlhh.UseVisualStyleBackColor = false;
            btnQlhh.Click += btnQlhh_Click;
            // 
            // btnQlgianhap
            // 
            btnQlgianhap.BackColor = Color.Wheat;
            btnQlgianhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQlgianhap.Location = new Point(130, 515);
            btnQlgianhap.Name = "btnQlgianhap";
            btnQlgianhap.Size = new Size(312, 57);
            btnQlgianhap.TabIndex = 6;
            btnQlgianhap.Text = "Quản Lý Giá Nhập, Giá Xuất";
            btnQlgianhap.UseVisualStyleBackColor = false;
            btnQlgianhap.Click += btnQlgianhap_Click;
            // 
            // Gdchinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1293, 730);
            Controls.Add(btnQlgianhap);
            Controls.Add(btnQlhh);
            Controls.Add(btnQltk);
            Controls.Add(btnTtcanhan);
            Controls.Add(btnDangxuat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gdchinh";
            Text = "Phần Mềm Quản Lý Kho Hàng";
            ResumeLayout(false);
        }

        #endregion
        private Button btnDangxuat;
        private Button btnTtcanhan;
        private Button btnQltk;
        private Button btnQlhh;
        private Button btnQlgianhap;
    }
}
