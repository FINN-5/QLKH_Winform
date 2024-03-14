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
    public partial class In_thongtin : Form
    {
        public In_thongtin()
        {
            InitializeComponent();
        }
        public void DataAdapter()
        {
            string qquery = "select iddoituong as 'Tên đăng nhập', ten as 'Họ tên người dùng',dienthoai as 'Điện thoại',diachi as 'Địa chỉ' from doituong ";
            dtg_INThongTin.DataSource = DataProvider.Instance.ExecuteQuery(qquery);

        }
        private void In_thongtin_Load(object sender, EventArgs e)
        {
            DataAdapter();
        }
    }
}
