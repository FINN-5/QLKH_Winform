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

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Them_QLTK them_QLTK = new Them_QLTK();
            them_QLTK.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sua_QLTK sua_QLTK=new Sua_QLTK();
            sua_QLTK.ShowDialog();
        }
    }
}
