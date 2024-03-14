namespace baitaplonC_
{
    partial class SuaHang
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
            tbttMahang_sua = new TextBox();
            tbttTenhang_sua = new TextBox();
            tbttLoai_sua = new TextBox();
            tbMahang_sua = new TextBox();
            tbTenhang_sua = new TextBox();
            cbbPhanloaihang_sua = new ComboBox();
            btnLuu_sua = new Button();
            btnThoat_sua = new Button();
            tbttMacansua_sua = new TextBox();
            tbMacansua_sua = new TextBox();
            SuspendLayout();
            // 
            // tbttMahang_sua
            // 
            tbttMahang_sua.BackColor = Color.SteelBlue;
            tbttMahang_sua.BorderStyle = BorderStyle.None;
            tbttMahang_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbttMahang_sua.ForeColor = SystemColors.Window;
            tbttMahang_sua.Location = new Point(78, 95);
            tbttMahang_sua.Multiline = true;
            tbttMahang_sua.Name = "tbttMahang_sua";
            tbttMahang_sua.ReadOnly = true;
            tbttMahang_sua.Size = new Size(128, 30);
            tbttMahang_sua.TabIndex = 0;
            tbttMahang_sua.Text = "Mã hàng hóa";
            // 
            // tbttTenhang_sua
            // 
            tbttTenhang_sua.BackColor = Color.SteelBlue;
            tbttTenhang_sua.BorderStyle = BorderStyle.None;
            tbttTenhang_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbttTenhang_sua.ForeColor = SystemColors.Window;
            tbttTenhang_sua.Location = new Point(78, 145);
            tbttTenhang_sua.Multiline = true;
            tbttTenhang_sua.Name = "tbttTenhang_sua";
            tbttTenhang_sua.ReadOnly = true;
            tbttTenhang_sua.Size = new Size(128, 30);
            tbttTenhang_sua.TabIndex = 1;
            tbttTenhang_sua.Text = "Tên hàng hóa";
            // 
            // tbttLoai_sua
            // 
            tbttLoai_sua.BackColor = Color.SteelBlue;
            tbttLoai_sua.BorderStyle = BorderStyle.None;
            tbttLoai_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbttLoai_sua.ForeColor = SystemColors.Window;
            tbttLoai_sua.Location = new Point(78, 198);
            tbttLoai_sua.Multiline = true;
            tbttLoai_sua.Name = "tbttLoai_sua";
            tbttLoai_sua.ReadOnly = true;
            tbttLoai_sua.Size = new Size(128, 30);
            tbttLoai_sua.TabIndex = 2;
            tbttLoai_sua.Text = "Phân loại";
            // 
            // tbMahang_sua
            // 
            tbMahang_sua.Location = new Point(277, 95);
            tbMahang_sua.Multiline = true;
            tbMahang_sua.Name = "tbMahang_sua";
            tbMahang_sua.Size = new Size(229, 30);
            tbMahang_sua.TabIndex = 3;
            tbMahang_sua.TextChanged += tbMahang_sua_TextChanged;
            tbMahang_sua.KeyPress += tbMahang_sua_KeyPress;
            // 
            // tbTenhang_sua
            // 
            tbTenhang_sua.Location = new Point(277, 145);
            tbTenhang_sua.Multiline = true;
            tbTenhang_sua.Name = "tbTenhang_sua";
            tbTenhang_sua.Size = new Size(229, 30);
            tbTenhang_sua.TabIndex = 4;
            tbTenhang_sua.KeyPress += tbTenhang_sua_KeyPress;
            // 
            // cbbPhanloaihang_sua
            // 
            cbbPhanloaihang_sua.BackColor = SystemColors.ScrollBar;
            cbbPhanloaihang_sua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbPhanloaihang_sua.FormattingEnabled = true;
            cbbPhanloaihang_sua.Items.AddRange(new object[] { "Hàng đông lạnh", "Hàng tươi sống" });
            cbbPhanloaihang_sua.Location = new Point(277, 198);
            cbbPhanloaihang_sua.Name = "cbbPhanloaihang_sua";
            cbbPhanloaihang_sua.Size = new Size(229, 30);
            cbbPhanloaihang_sua.TabIndex = 6;
            // 
            // btnLuu_sua
            // 
            btnLuu_sua.BackColor = Color.FromArgb(255, 192, 128);
            btnLuu_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu_sua.ForeColor = SystemColors.ControlText;
            btnLuu_sua.Location = new Point(327, 257);
            btnLuu_sua.Name = "btnLuu_sua";
            btnLuu_sua.Size = new Size(72, 31);
            btnLuu_sua.TabIndex = 7;
            btnLuu_sua.Text = "Lưu";
            btnLuu_sua.UseVisualStyleBackColor = false;
            btnLuu_sua.Click += btnLuu_sua_Click;
            // 
            // btnThoat_sua
            // 
            btnThoat_sua.BackColor = Color.Lavender;
            btnThoat_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat_sua.Location = new Point(434, 257);
            btnThoat_sua.Name = "btnThoat_sua";
            btnThoat_sua.Size = new Size(72, 31);
            btnThoat_sua.TabIndex = 8;
            btnThoat_sua.Text = "Thoát";
            btnThoat_sua.UseVisualStyleBackColor = false;
            btnThoat_sua.Click += btnThoat_sua_Click;
            // 
            // tbttMacansua_sua
            // 
            tbttMacansua_sua.BackColor = Color.SteelBlue;
            tbttMacansua_sua.BorderStyle = BorderStyle.None;
            tbttMacansua_sua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbttMacansua_sua.ForeColor = SystemColors.Window;
            tbttMacansua_sua.Location = new Point(78, 47);
            tbttMacansua_sua.Multiline = true;
            tbttMacansua_sua.Name = "tbttMacansua_sua";
            tbttMacansua_sua.ReadOnly = true;
            tbttMacansua_sua.Size = new Size(128, 30);
            tbttMacansua_sua.TabIndex = 0;
            tbttMacansua_sua.Text = "Mã cần chỉnh";
            // 
            // tbMacansua_sua
            // 
            tbMacansua_sua.Location = new Point(277, 47);
            tbMacansua_sua.Multiline = true;
            tbMacansua_sua.Name = "tbMacansua_sua";
            tbMacansua_sua.Size = new Size(229, 30);
            tbMacansua_sua.TabIndex = 3;
            tbMacansua_sua.KeyPress += tbMacansua_sua_KeyPress;
            // 
            // SuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(621, 330);
            Controls.Add(tbMacansua_sua);
            Controls.Add(tbttMacansua_sua);
            Controls.Add(btnThoat_sua);
            Controls.Add(btnLuu_sua);
            Controls.Add(cbbPhanloaihang_sua);
            Controls.Add(tbTenhang_sua);
            Controls.Add(tbMahang_sua);
            Controls.Add(tbttLoai_sua);
            Controls.Add(tbttTenhang_sua);
            Controls.Add(tbttMahang_sua);
            Name = "SuaHang";
            Text = "Sửa hàng hóa";
            Load += SuaHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbttMahang_sua;
        private TextBox tbttTenhang_sua;
        private TextBox tbttLoai_sua;
        private TextBox tbMahang_sua;
        private TextBox tbTenhang_sua;
        private ComboBox cbbPhanloaihang_sua;
        private Button btnLuu_sua;
        private Button btnThoat_sua;
        private TextBox tbttMacansua_sua;
        private TextBox tbMacansua_sua;
    }
}