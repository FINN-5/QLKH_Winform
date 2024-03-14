namespace baitaplonC_
{
    partial class In_thongtin
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
            dtg_INThongTin = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_INThongTin).BeginInit();
            SuspendLayout();
            // 
            // dtg_INThongTin
            // 
            dtg_INThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_INThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_INThongTin.Location = new Point(12, 12);
            dtg_INThongTin.Name = "dtg_INThongTin";
            dtg_INThongTin.RowHeadersWidth = 51;
            dtg_INThongTin.Size = new Size(776, 426);
            dtg_INThongTin.TabIndex = 0;
            // 
            // In_thongtin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtg_INThongTin);
            Name = "In_thongtin";
            Text = "In_thongtin";
            Load += In_thongtin_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_INThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_INThongTin;
    }
}