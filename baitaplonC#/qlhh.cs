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
    }
    public void TruyVanDL()
    {
        string query = "SELECT * FROM doituong";
        DataProvider provider = new DataProvider();
        DataGridView.DataSource = provider.ExecuteQuery(query);
    }
}
