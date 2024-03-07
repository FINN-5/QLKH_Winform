using System.Text;

namespace baitaplonC_
{
    partial class Qlhhform
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
            Panel panel4;
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(165, 410);
            panel4.Name = "panel4";
            panel4.Size = new Size(722, 63);
            panel4.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SteelBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.AliceBlue;
            textBox1.Location = new Point(18, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Tên hàng hóa";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(-1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 479);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(8, 111);
            button3.Name = "button3";
            button3.Size = new Size(152, 48);
            button3.TabIndex = 1;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 57);
            button2.Name = "button2";
            button2.Size = new Size(152, 48);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 3);
            button1.Name = "button1";
            button1.Size = new Size(152, 48);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeight = 43;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3 });
            dataGridView1.Location = new Point(-3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 55;
            dataGridView1.Size = new Size(722, 73);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 90F;
            Column1.HeaderText = "Tên đăng nhập";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Họ và tên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Điện thoại";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa chỉ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(165, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 413);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.Wheat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(567, 20);
            button4.Name = "button4";
            button4.Size = new Size(127, 32);
            button4.TabIndex = 2;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            // 
            // Qlhhform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 473);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "Qlhhform";
            Text = "Quản lý hàng hóa";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
    }
}