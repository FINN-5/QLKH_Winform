using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplonC_
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();

        }
        public void DataAdapter()
        {
            string qquery = "select iddoituong as 'Tên đăng nhập', ten as 'Họ tên người dùng',dienthoai as 'Điện thoại',diachi as 'Địa chỉ' from doituong ";
            dtg_QLTK.DataSource = DataProvider.Instance.ExecuteQuery(qquery);

        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            DataAdapter();
        }



        private void bt_them_Click(object sender, EventArgs e)
        {
            Them_QLTK them_QLTK = new Them_QLTK();
            them_QLTK.ShowDialog();
            DataAdapter();
           
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            Sua_QLTK sua_QLTK = new Sua_QLTK();
            sua_QLTK.ShowDialog();
            DataAdapter();
        }
        private string iddoituong = "";
        public bool XoaTK(string iddoituong)
        {
            string query = string.Format("DELETE FROM doituong where iddoituong = N'{0}'", iddoituong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                XoaTK(iddoituong);
                DataAdapter();
            }
            else
            {

                return;
            }
        }
        private void dtg_QLTK_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_QLTK.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = dtg_QLTK.SelectedCells[0];
                if (cell.Value != null)
                {
                    iddoituong = cell.Value.ToString();
                }
            }
        }
        public void Timkiem(string ten)
        {
            string query = string.Format("select iddoituong as 'Tên đăng nhập', ten as 'Họ tên người dùng',dienthoai as 'Điện thoại',diachi as 'Địa chỉ' from doituong where ten LIKE N'%{0}%'", ten);
            dtg_QLTK.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
      

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string query = tb_Timkiem.Text;
            Timkiem(query);


        }
    }
}
