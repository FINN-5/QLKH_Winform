namespace baitaplonC_
{
    partial class QuanLyTaiKhoan
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
            bt_timkiem = new Button();
            tb_Timkiem = new TextBox();
            label1 = new Label();
            bt_xoa = new Button();
            bt_sua = new Button();
            bt_them = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bt_timkiem
            // 
            bt_timkiem.BackColor = Color.Wheat;
            bt_timkiem.Location = new Point(790, 484);
            bt_timkiem.Name = "bt_timkiem";
            bt_timkiem.Size = new Size(167, 50);
            bt_timkiem.TabIndex = 10;
            bt_timkiem.Text = "Tìm Kiếm";
            bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // tb_Timkiem
            // 
            tb_Timkiem.Location = new Point(281, 496);
            tb_Timkiem.Name = "tb_Timkiem";
            tb_Timkiem.Size = new Size(407, 27);
            tb_Timkiem.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 495);
            label1.Name = "label1";
            label1.Size = new Size(140, 26);
            label1.TabIndex = 8;
            label1.Text = "Tên tài khoản";
            // 
            // bt_xoa
            // 
            bt_xoa.BackColor = Color.Wheat;
            bt_xoa.Font = new Font("Times New Roman", 12F);
            bt_xoa.Location = new Point(9, 169);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(167, 50);
            bt_xoa.TabIndex = 4;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_sua
            // 
            bt_sua.BackColor = Color.Wheat;
            bt_sua.Font = new Font("Times New Roman", 12F);
            bt_sua.Location = new Point(9, 96);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(167, 50);
            bt_sua.TabIndex = 5;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = false;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_them
            // 
            bt_them.BackColor = Color.Wheat;
            bt_them.Font = new Font("Times New Roman", 12F);
            bt_them.Location = new Point(9, 27);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(167, 50);
            bt_them.TabIndex = 6;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = false;
            bt_them.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(195, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 443);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 267);
            dataGridView1.TabIndex = 0;
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(982, 553);
            Controls.Add(bt_timkiem);
            Controls.Add(tb_Timkiem);
            Controls.Add(label1);
            Controls.Add(bt_xoa);
            Controls.Add(bt_sua);
            Controls.Add(bt_them);
            Controls.Add(groupBox1);
            Name = "QuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyTaiKhoan";
            Load += QuanLyTaiKhoan_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_timkiem;
        private TextBox tb_Timkiem;
        private Label label1;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}