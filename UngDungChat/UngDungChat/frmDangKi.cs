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
    public partial class frmDangKi : Form
    {
        List<TaiKhoanDangNhap> listTaiKhoanDangNhap = DanhSachTaiKhoan.Instance.ListTaiKhoanDangNhap;
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            var timKiem = listTaiKhoanDangNhap.Find(
                (p) =>
                {
                    return p.TenDangNhap == txbTaiKhoan.Text || p.MatKhau == txbMatKhau.Text;
                }
                );
            if (timKiem == null)
            {
                listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap(txbTaiKhoan.Text, txbMatKhau.Text, "user"));
                this.Hide();
                MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo");

                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
            
            
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }
    }
}
