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
    public partial class Sua_QLTK : Form
    {
        public Sua_QLTK()
        {
            InitializeComponent();
        }
        public bool SuaQLTK(string iddoituong, string ten, string matkhau, string dienthoai, string diachi, int kieu)
        {
            string query = string.Format("update doituong set iddoituong=N'{0}',  ten=N'{1}', userpass=N'{2}',dienthoai=N'{3}',diachi=N'{4}',kieu=N'{5}' where iddoituong=N'{0}'", iddoituong,ten, matkhau, dienthoai, diachi, kieu, iddoituong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        QuanLyTaiKhoan quanLyTaiKhoan=new QuanLyTaiKhoan(); 

        private void Sua_QLTK_Load(object sender, EventArgs e)
        {

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            int kieu;
            string iddoituong = tb_tendangnhap.Text;
            string ten = tb_hoten.Text;
            string matkhau = tb_matkhau.Text;
            string dienthoai = tb_dienthoai.Text;
            string diachi = tb_diachi.Text;
            string kieuuuuu = (string)cbb_kieu.SelectedItem;
            if (kieuuuuu == "ADMIN")
            {
                kieu = 0;
            }
            else { kieu = 1; }
            if (SuaQLTK(iddoituong, ten, matkhau, dienthoai, diachi, kieu))
            {
                MessageBox.Show("Sửa thành công.");
                
                quanLyTaiKhoan.DataAdapter();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa.");
            }

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
