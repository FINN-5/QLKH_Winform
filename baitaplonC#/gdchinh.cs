namespace baitaplonC_
{
    public partial class Gdchinh : Form
    {
        public Gdchinh()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTaiKhoan quanLyTaiKhoan=new QuanLyTaiKhoan();
            quanLyTaiKhoan.ShowDialog();
        }
    }
}
