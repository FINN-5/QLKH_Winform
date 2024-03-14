using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitaplonC_
{
    public partial class NhapHang1 : Form
    {
        public NhapHang1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void NhapHang1_Load(object sender, EventArgs e)
        {

            hienthi();
        }
        public void hienthi()
        {
            try
            {
                dataGridView4.DataSource = modify.Table("select idhang as 'Mã hàng hóa', ten as 'Tên hàng hóa', loaihang as 'Phân loại',gianhap as 'Giá Nhập',giaxuat as 'Giá Xuất'  from hanghoa");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE hanghoa SET
            gianhap = N'" + textBox4.Text + @"',
            giaxuat = N'" + textBox5.Text + @"'
            WHERE idhang = '" + textBox1.Text + "'";
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Sửa thành công !");
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView4.CurrentRow != null && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView4.CurrentRow;

                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString();
                textBox5.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fdg(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM hanghoa WHERE idhang = N'" + textBox1.Text + @"'";
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Xóa thành công !");
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thông báo
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                // Nếu chọn "Yes", thoát và dừng chương trình
                this.Close();
            }
            // Nếu chọn "No", không làm gì cả và tiếp tục chương trình
        }
    }
}
