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
    public partial class nhaphang : Form
    {
        public nhaphang()
        {
            InitializeComponent();
        }

        private void nhaphang_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }


        private Form currentchildform;
        private void openchildform(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
                //neu form tren da khoi tao roi thi dong lai
            }
            currentchildform = childform;
            childform.TopLevel = false;
            //khi show form nay thi can thuc hien len form cha
            childform.FormBorderStyle = FormBorderStyle.None;
            //bo hop thoai cua from
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //su kien khi an nut sua

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new suanhap());
        }

       
    }

}

