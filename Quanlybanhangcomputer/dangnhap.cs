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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        private void tbldangnhap_Click_1(object sender, EventArgs e)
        {
            if (txtquyentruycap.Text == "User")
            {
                user us = new user();
                us.ShowDialog();
            }
            else
            {
                admin ad = new admin();
                ad.ShowDialog();
            }
        }

        private void tblthoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Dispose();
        }
    }
}
