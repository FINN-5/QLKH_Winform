namespace baitaplonC_
{
    partial class ThemHang
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
            tbttMahang_them = new TextBox();
            tbTenhang_them = new TextBox();
            tbPhanloai_them = new TextBox();
            tbMahang = new TextBox();
            tbTenhang = new TextBox();
            cbbPhanloaiHang = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbttMahang_them
            // 
            tbttMahang_them.BackColor = Color.SteelBlue;
            tbttMahang_them.BorderStyle = BorderStyle.None;
            tbttMahang_them.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbttMahang_them.ForeColor = SystemColors.Window;
            tbttMahang_them.Location = new Point(78, 47);
            tbttMahang_them.Multiline = true;
            tbttMahang_them.Name = "tbttMahang_them";
            tbttMahang_them.ReadOnly = true;
            tbttMahang_them.Size = new Size(128, 30);
            tbttMahang_them.TabIndex = 0;
            tbttMahang_them.Text = "Mã hàng hóa";
            // 
            // tbTenhang_them
            // 
            tbTenhang_them.BackColor = Color.SteelBlue;
            tbTenhang_them.BorderStyle = BorderStyle.None;
            tbTenhang_them.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTenhang_them.ForeColor = SystemColors.Window;
            tbTenhang_them.Location = new Point(78, 101);
            tbTenhang_them.Multiline = true;
            tbTenhang_them.Name = "tbTenhang_them";
            tbTenhang_them.ReadOnly = true;
            tbTenhang_them.Size = new Size(128, 30);
            tbTenhang_them.TabIndex = 1;
            tbTenhang_them.Text = "Tên hàng hóa";
            // 
            // tbPhanloai_them
            // 
            tbPhanloai_them.BackColor = Color.SteelBlue;
            tbPhanloai_them.BorderStyle = BorderStyle.None;
            tbPhanloai_them.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPhanloai_them.ForeColor = SystemColors.Window;
            tbPhanloai_them.Location = new Point(78, 158);
            tbPhanloai_them.Multiline = true;
            tbPhanloai_them.Name = "tbPhanloai_them";
            tbPhanloai_them.ReadOnly = true;
            tbPhanloai_them.Size = new Size(128, 30);
            tbPhanloai_them.TabIndex = 2;
            tbPhanloai_them.Text = "Phân loại";
            // 
            // tbMahang
            // 
            tbMahang.Location = new Point(277, 47);
            tbMahang.Multiline = true;
            tbMahang.Name = "tbMahang";
            tbMahang.Size = new Size(229, 30);
            tbMahang.TabIndex = 3;
            tbMahang.KeyPress += tbMahang_KeyPress;
            // 
            // tbTenhang
            // 
            tbTenhang.Location = new Point(277, 101);
            tbTenhang.Multiline = true;
            tbTenhang.Name = "tbTenhang";
            tbTenhang.Size = new Size(229, 30);
            tbTenhang.TabIndex = 4;
            tbTenhang.KeyPress += tbTenhang_KeyPress;
            // 
            // cbbPhanloaiHang
            // 
            cbbPhanloaiHang.BackColor = SystemColors.ScrollBar;
            cbbPhanloaiHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbPhanloaiHang.FormattingEnabled = true;
            cbbPhanloaiHang.Items.AddRange(new object[] { "Hàng đông lạnh", "Hàng tươi sống", "Khác" });
            cbbPhanloaiHang.Location = new Point(277, 158);
            cbbPhanloaiHang.Name = "cbbPhanloaiHang";
            cbbPhanloaiHang.Size = new Size(229, 30);
            cbbPhanloaiHang.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(316, 209);
            button1.Name = "button1";
            button1.Size = new Size(72, 31);
            button1.TabIndex = 7;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(410, 209);
            button2.Name = "button2";
            button2.Size = new Size(72, 31);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ThemHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(621, 304);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbbPhanloaiHang);
            Controls.Add(tbTenhang);
            Controls.Add(tbMahang);
            Controls.Add(tbPhanloai_them);
            Controls.Add(tbTenhang_them);
            Controls.Add(tbttMahang_them);
            Name = "ThemHang";
            Text = "Thêm hàng hóa";
            Load += ThemHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbttMahang_them;
        private TextBox tbTenhang_them;
        private TextBox tbPhanloai_them;
        internal TextBox tbMahang;
        internal TextBox tbTenhang;
        internal ComboBox cbbPhanloaiHang;
        private Button button1;
        private Button button2;
    }
}