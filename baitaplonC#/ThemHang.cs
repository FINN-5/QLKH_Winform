using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitaplonC_
{
    public partial class ThemHang : Form
    {
        public ThemHang()
        {
            InitializeComponent();
        }
        public bool FuncThemHang(string id, string ten, string loai)
        {
            string query = string.Format("insert into dbo.hanghoa(idhang,ten,loaihang,iddoituong) values(N'{0}',N'{1}',N'{2}', N'ad')", id, ten, loai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = tbMahang.Text;
            string ten = tbTenhang.Text;
            string loai = (string)cbbPhanloaiHang.SelectedItem;
            if (FuncThemHang(id, ten, loai))
            {
                MessageBox.Show("Thêm thành công.");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thêm.");
            }
            this.Close();
        }

        private void tbMahang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                tbTenhang.Focus();
                e.Handled = true;
            }
        }

        private void tbTenhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cbbPhanloaiHang.Focus();
                e.Handled = true;
            }
        }

        private void ThemHang_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.Button || control is System.Windows.Forms.ComboBox)
                {
                    control.TabStop = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
