using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO_NhanVien;

namespace project_QLNV
{
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();   
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           //dgvNhanVien.DataSource = busNhanVien.getData();
            dgvNhanVien.DataSource = busNhanVien.LayDS();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
