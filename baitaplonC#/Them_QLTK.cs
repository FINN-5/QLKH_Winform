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
    public partial class Them_QLTK : Form
    {
        public Them_QLTK()
        {
            InitializeComponent();
        }
        QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
        public bool ThemTK(string iddoituong, string ten, string matkhau, string dienthoai, string diachi, int kieu)
        {
            string query = string.Format("insert into doituong(iddoituong,ten,userpass,dienthoai,diachi,kieu) values(N'{0}',N'{1}',N'{2}', N'{3}',N'{4}',N'{5}')", iddoituong, ten, matkhau, dienthoai, diachi, kieu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        private void Them_QLTK_Load(object sender, EventArgs e)
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
            if (ThemTK(iddoituong, ten, matkhau, dienthoai, diachi, kieu))
            {

                MessageBox.Show("Thêm thành công.");
                quanLyTaiKhoan.DataAdapter();
                this.Close();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thêm.");
            }


        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_QLTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tb_tendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
