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
using DTO;

namespace project_QLNV
{
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        int luu = -1;
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
            int dong = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
            txtTDHV.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
            txtMT.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
            txtQT.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
            txtTonGiao.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            txtDanToc.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[dong].Cells[8].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.Rows[dong].Cells[9].Value.ToString();
            txtNoiSinh.Text = dgvNhanVien.Rows[dong].Cells[10].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[11].Value.ToString();
            txtMaLuong.Text = dgvNhanVien.Rows[dong].Cells[12].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[dong].Cells[13].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[dong].Cells[14].Value.ToString();
            txtChuyenMon.Text = dgvNhanVien.Rows[dong].Cells[15].Value.ToString();
         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto = new DTO_NhanVien(txtMaNV.Text, txtGioiTinh.Text, txtTDHV.Text, txtMT.Text, txtQT.Text,txtTonGiao.Text,
                txtDanToc.Text,txtHoTen.Text,txtNoiSinh.Text,txtDiaChi.Text,txtMaLuong.Text,txtEmail.Text,txtChuyenMon.Text,txtCMND.Text,txtSDT.Text, DateTime.Parse(txtNgaySinh.Text));
            try
            {
                if (busNhanVien.ThemNV(dto) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
            finally
            {
                dgvNhanVien.DataSource = busNhanVien.LayDS();
            }

        }
        
        private void clearText()
        {
            txtMaNV.Clear();
            txtGioiTinh.Clear();
            txtTDHV.Clear();
            txtMT.Clear();
            txtQT.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            txtNoiSinh.Clear();
            txtDiaChi.Clear();
            txtTonGiao.Clear();
            txtSDT.Clear();
            txtSDT.Clear();
            txtChuyenMon.Clear();
            txtMaLuong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto = new DTO_NhanVien(txtMaNV.Text, txtGioiTinh.Text, txtTDHV.Text, txtMT.Text, txtQT.Text, txtTonGiao.Text,
                txtDanToc.Text, txtHoTen.Text, txtNoiSinh.Text, txtDiaChi.Text, txtMaLuong.Text, txtEmail.Text, txtChuyenMon.Text, txtCMND.Text, txtSDT.Text, DateTime.Parse(txtNgaySinh.Text));
            try
            {
                if (busNhanVien.XoaNVK(dto) == true)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                else MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
            finally
            {
                dgvNhanVien.DataSource = busNhanVien.LayDS();
            }
        }

    

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto = new DTO_NhanVien(txtMaNV.Text, txtGioiTinh.Text, txtTDHV.Text, txtMT.Text, txtQT.Text, txtTonGiao.Text,
                txtDanToc.Text, txtHoTen.Text, txtNoiSinh.Text, txtDiaChi.Text, txtMaLuong.Text, txtEmail.Text, txtChuyenMon.Text, txtCMND.Text, txtSDT.Text, DateTime.Parse(txtNgaySinh.Text));
            try
            {
                if (busNhanVien.SuaNV(dto) == true)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else MessageBox.Show("Sửa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
            finally
            {
                dgvNhanVien.DataSource = busNhanVien.LayDS();
            }
        }
    }
}
