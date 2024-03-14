namespace baitaplonC_
{
    public partial class Gdchinh : Form
    {
        public Gdchinh()
        {
            InitializeComponent();
        }

        private void btnQltk_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
            qltk.ShowDialog();
        }

        private void btnQlhh_Click(object sender, EventArgs e)
        {
            Qlhhform qlhh = new Qlhhform();
            qlhh.ShowDialog();
        }

        private void btnQlgianhap_Click(object sender, EventArgs e)
        {
            NhapHang1 nhaphang1 = new NhapHang1();
            nhaphang1.ShowDialog();
        }
    }
}
