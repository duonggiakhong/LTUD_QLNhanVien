using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_QLNV
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pbNhanVien_Click(object sender, EventArgs e)
        {
            Form nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
        }
    }
}
