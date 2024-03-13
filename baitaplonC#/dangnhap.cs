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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace baitaplonC_
{
    public partial class Dangnhap : Form
    {

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Gdchinh gdchinh = new Gdchinh();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False");
            try
            {
                conn.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                string sql = "select *from doituong where iddoituong='" + tk + "' and userpass='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    this.Hide();
                    gdchinh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }
    }
}
