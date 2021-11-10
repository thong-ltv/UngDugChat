using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UngDungChat
{
    public partial class frmAdmmin : Form
    {
        List<TaiKhoanDangNhap> listTaiKhoanDangNhap = DanhSachTaiKhoan.Instance.ListTaiKhoanDangNhap;
        public frmAdmmin()
        {
            InitializeComponent();
        }

        private void frmAdmmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {   
                dgvThongTin.DataSource = listTaiKhoanDangNhap;   
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var timKiem = listTaiKhoanDangNhap.Find(
                (p) =>
                {
                    return p.TenDangNhap == txbTenDangNhap.Text || p.MatKhau == txbMatKhau.Text;
                }
                );
            if (timKiem == null)
            {
                listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap(txbTenDangNhap.Text, txbMatKhau.Text, txbPhanQuyen.Text));
                this.Hide();
                frmAdmmin f = new frmAdmmin();
                f.Show();
                MessageBox.Show("Bạn đã thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var i = listTaiKhoanDangNhap.FindIndex(
                (p) =>
                {
                    return p.TenDangNhap == txbTenDangNhap.Text;
                }
                );
            listTaiKhoanDangNhap.RemoveAt(i);
            this.Hide();
            frmAdmmin f = new frmAdmmin();
            f.Show();
            MessageBox.Show("Bạn đã xóa thành công!", "Thông báo");
        }
        private void frmAdmmin_Load(object sender, EventArgs e)
        {
            dgvThongTin.DataSource = listTaiKhoanDangNhap;
        }

        private void frmAdmmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txbTenDangNhap.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txbMatKhau.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txbPhanQuyen.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                var timKiem = listTaiKhoanDangNhap.Find(
                (p) =>
                {   
                        return p.TenDangNhap == txbTenDangNhap.Text;   
                }
                );
                if(timKiem != null)
                     {
                        txbTenDangNhap.Text = timKiem.TenDangNhap;
                        txbMatKhau.Text = timKiem.MatKhau;
                        txbPhanQuyen.Text = timKiem.PhanQuyen;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }

                
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            txbTenDangNhap.Clear();
            txbMatKhau.Clear();
            txbPhanQuyen.Clear();
        }
    }
}
