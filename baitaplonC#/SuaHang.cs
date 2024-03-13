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
    public partial class SuaHang : Form
    {
        public SuaHang()
        {
            InitializeComponent();
        }
        public bool FuncSuaHang(string idhang, string ten, string loai, string idcansua)
        {
            string query = string.Format("update hanghoa set idhang=N'{0}', ten=N'{1}', loaihang=N'{2}' where idhang=N'{3}'", idhang, ten, loai, idcansua);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        private void btnLuu_sua_Click(object sender, EventArgs e)
        {
            string id = tbMahang_sua.Text;
            string ten = tbTenhang_sua.Text;
            string loai = (string)cbbPhanloaihang_sua.SelectedItem;
            string idcansua = tbMacansua_sua.Text;
            if (FuncSuaHang(id, ten, loai, idcansua))
            {
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa.");
            }
            this.Close();
        }

        private void tbMacansua_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbMahang_sua.Focus();
                e.Handled = true;
            }
        }

        private void tbTenhang_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cbbPhanloaihang_sua.Focus();
                e.Handled = true;
            }
        }

        private void tbMahang_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbTenhang_sua.Focus();
                e.Handled = true;
            }
        }

        private void SuaHang_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.Button || control is System.Windows.Forms.ComboBox)
                {
                    control.TabStop = false;
                }
            }
        }

        private void btnThoat_sua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMahang_sua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
