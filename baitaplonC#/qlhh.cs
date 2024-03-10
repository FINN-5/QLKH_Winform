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
    public partial class Qlhhform : Form
    {
        public Qlhhform()
        {
            InitializeComponent();
            TruyVanDL();
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
    }
}
