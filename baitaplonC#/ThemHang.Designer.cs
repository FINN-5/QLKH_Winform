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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tbMahang = new TextBox();
            tbTenhang = new TextBox();
            cbbPhanloaiHang = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SteelBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(78, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(128, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "Mã hàng hóa";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SteelBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(78, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(128, 30);
            textBox2.TabIndex = 1;
            textBox2.Text = "Tên hàng hóa";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SteelBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(78, 158);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(128, 30);
            textBox3.TabIndex = 2;
            textBox3.Text = "Phân loại";
            // 
            // tbMahang
            // 
            tbMahang.Location = new Point(277, 47);
            tbMahang.Multiline = true;
            tbMahang.Name = "tbMahang";
            tbMahang.Size = new Size(229, 30);
            tbMahang.TabIndex = 3;
            // 
            // tbTenhang
            // 
            tbTenhang.Location = new Point(277, 101);
            tbTenhang.Multiline = true;
            tbTenhang.Name = "tbTenhang";
            tbTenhang.Size = new Size(229, 30);
            tbTenhang.TabIndex = 4;
            // 
            // cbbPhanloaiHang
            // 
            cbbPhanloaiHang.BackColor = SystemColors.ScrollBar;
            cbbPhanloaiHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbPhanloaiHang.FormattingEnabled = true;
            cbbPhanloaiHang.Items.AddRange(new object[] { "Hàng đông lạnh", "Hàng tươi sống" });
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
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ThemHang";
            Text = "ThemHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        internal TextBox tbMahang;
        internal TextBox tbTenhang;
        internal ComboBox cbbPhanloaiHang;
        private Button button1;
        private Button button2;
    }
}