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

namespace baitaplonC_
{
    public partial class Qlhhform : Form
    {
        public Qlhhform()
        {
            InitializeComponent();
            TruyVanDL();
            MaximizeBox = false;
        }

        public void TruyVanDL()
        {
            string query = "select idhang as 'Mã hàng hóa', ten as 'Tên hàng hóa', loaihang as 'Phân loại' from hanghoa";
            dtgvHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }


        private void dtgvHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgvHang.AutoResizeRows();
        }

        private void dtgvHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dtgvHang.AutoResizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHang themHang = new ThemHang();
            themHang.ShowDialog();
            TruyVanDL();
        }

        private void Qlhhform_Load(object sender, EventArgs e)
        {
            dtgvHang.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuaHang suaHang = new SuaHang();
            suaHang.ShowDialog();
            TruyVanDL();
        }
        private string idxoahang = "";

        private void dtgvHang_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHang.SelectedCells.Count > 0)
            {
                // Lấy ô được chọn
                DataGridViewCell cell = dtgvHang.SelectedCells[0];
                if (cell.Value != null)
                {
                    idxoahang = cell.Value.ToString(); // Lưu giá trị của ô vào biến cellValue
                }
            }
        }

        public bool FuncXoaHang(string idhang)
        {
            string query = string.Format("DELETE FROM hanghoa where idhang = N'{0}'", idhang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo);

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                // Xóa dữ liệu
                FuncXoaHang(idxoahang);
                TruyVanDL();
            }
            else
            {
                // Không xóa dữ liệu
                return;
            }
        }
    }
}
