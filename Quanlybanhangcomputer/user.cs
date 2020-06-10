using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhangcomputer
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void tblbanhang_Click(object sender, EventArgs e)
        {
            quanlybanhang qlbh = new quanlybanhang();
            qlbh.ShowDialog();
        }

        private void tblquanlysanpham_Click(object sender, EventArgs e)
        {
            quanlysanpham qlSP = new quanlysanpham();
            qlSP.ShowDialog();
        }

        private void tblquanlyhoadon_Click(object sender, EventArgs e)
        {
            quanlyhoadon qlhd = new quanlyhoadon();
            qlhd.ShowDialog();
        }

        private void tblthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Dispose();
        }
        
    }
}
