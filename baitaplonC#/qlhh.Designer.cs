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
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            dtgvHang = new DataGridView();
            panel4 = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHang).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(165, 410);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 63);
            panel4.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Wheat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(567, 20);
            button4.Name = "button4";
            button4.Size = new Size(127, 32);
            button4.TabIndex = 2;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(201, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(8, 111);
            button3.Name = "button3";
            button3.Size = new Size(152, 48);
            button3.TabIndex = 1;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Wheat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 57);
            button2.Name = "button2";
            button2.Size = new Size(152, 48);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Wheat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 3);
            button1.Name = "button1";
            button1.Size = new Size(152, 48);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(dtgvHang);
            panel1.Location = new Point(165, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 413);
            panel1.TabIndex = 6;
            // 
            // dtgvHang
            // 
            dtgvHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvHang.BackgroundColor = SystemColors.InactiveCaption;
            dtgvHang.BorderStyle = BorderStyle.None;
            dtgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHang.Location = new Point(0, 3);
            dtgvHang.Name = "dtgvHang";
            dtgvHang.ReadOnly = true;
            dtgvHang.RowHeadersWidth = 51;
            dtgvHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgvHang.Size = new Size(722, 211);
            dtgvHang.TabIndex = 5;
            dtgvHang.CellMouseEnter += dtgvHang_CellMouseEnter;
            dtgvHang.RowsAdded += dtgvHang_RowsAdded;
            dtgvHang.RowsRemoved += dtgvHang_RowsRemoved;
            // 
            // Qlhhform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 473);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "Qlhhform";
            Text = "Quản lý hàng hóa";
            Load += Qlhhform_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private DataGridView dtgvHang;
    }
}