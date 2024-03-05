namespace baitaplonC_
{
    partial class gdchinh
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            qlhhbtn = new Button();
            qlgianhapbtn = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(204, 34);
            button1.Name = "button1";
            button1.Size = new Size(173, 63);
            button1.TabIndex = 0;
            button1.Text = "Đổi Mật Khẩu";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(204, 127);
            button3.Name = "button3";
            button3.Size = new Size(173, 63);
            button3.TabIndex = 2;
            button3.Text = "Đăng Xuất";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(39, 220);
            button2.Name = "button2";
            button2.Size = new Size(312, 45);
            button2.TabIndex = 3;
            button2.Text = "Thông Tin Cá Nhân";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(39, 288);
            button4.Name = "button4";
            button4.Size = new Size(312, 45);
            button4.TabIndex = 4;
            button4.Text = "Quản Lý Tài Khoản";
            button4.UseVisualStyleBackColor = false;
            // 
            // qlhhbtn
            // 
            qlhhbtn.BackColor = SystemColors.ActiveCaption;
            qlhhbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qlhhbtn.Location = new Point(39, 352);
            qlhhbtn.Name = "qlhhbtn";
            qlhhbtn.Size = new Size(312, 45);
            qlhhbtn.TabIndex = 5;
            qlhhbtn.Text = "Quản Lý Hàng Hóa";
            qlhhbtn.UseVisualStyleBackColor = false;
            qlhhbtn.Click += qlhhbtn_Click;
            // 
            // qlgianhapbtn
            // 
            qlgianhapbtn.BackColor = SystemColors.ActiveCaption;
            qlgianhapbtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qlgianhapbtn.Location = new Point(39, 415);
            qlgianhapbtn.Name = "qlgianhapbtn";
            qlgianhapbtn.Size = new Size(312, 45);
            qlgianhapbtn.TabIndex = 6;
            qlgianhapbtn.Text = "Quản Lý Giá Nhập";
            qlgianhapbtn.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Location = new Point(39, 627);
            button8.Name = "button8";
            button8.Size = new Size(312, 45);
            button8.TabIndex = 9;
            button8.Text = "Xuất Kho";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaption;
            button9.Location = new Point(39, 555);
            button9.Name = "button9";
            button9.Size = new Size(312, 45);
            button9.TabIndex = 8;
            button9.Text = "Nhập Kho";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.Location = new Point(39, 482);
            button10.Name = "button10";
            button10.Size = new Size(312, 45);
            button10.TabIndex = 7;
            button10.Text = "Quản Lý Giá Xuất";
            button10.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5212876671755_bbb3e0cae80caaa7587d208235d2ee32;
            ClientSize = new Size(1310, 762);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(qlgianhapbtn);
            Controls.Add(qlhhbtn);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Phần Mềm Quản Lý Kho Hàng";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button qlhhbtn;
        private Button qlgianhapbtn;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
