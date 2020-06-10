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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
        private void tblquanlynhanvien_Click_1(object sender, EventArgs e)
        {
            quanlynhanvien qlnv = new quanlynhanvien();
            qlnv.ShowDialog();
        }

        private void tblquanlytaikhoan_Click_1(object sender, EventArgs e)
        {
            quanlytaikhoan qltk = new quanlytaikhoan();
            qltk.ShowDialog();
        }

        private void tblthongkedoanhso_Click_1(object sender, EventArgs e)
        {
            thongkedoanhso tkds = new thongkedoanhso();
            tkds.ShowDialog();
        }

        private void tblthoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Dispose();
        }
    }
}
