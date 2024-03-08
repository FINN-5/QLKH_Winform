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
            string query = "SELECT * FROM doituong";
            dtgvHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }


        public bool ThemHang(string id, string ten, string loai)
        {
            string query = string.Format("insert into dbo.hanghoa values(N'{0}',N'{1}',N'{2}',N'',N'',N'')", id, ten, loai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
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
            themHang.Show();
        }
    }
}
