namespace baitaplonC_
{
    partial class Dangnhap
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản ";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // button1
            // 
            button1.Location = new Point(187, 283);
            button1.Name = "button1";
            button1.Size = new Size(153, 35);
            button1.TabIndex = 4;
            button1.Text = "✅ Đăng Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 283);
            button2.Name = "button2";
            button2.Size = new Size(153, 35);
            button2.TabIndex = 5;
            button2.Text = "📤 Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkBox1.Location = new Point(187, 189);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Hiện Mật Khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0b549b82e4d3c640ead42f9b66697d92;
            ClientSize = new Size(559, 351);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Dangnhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
    }
}