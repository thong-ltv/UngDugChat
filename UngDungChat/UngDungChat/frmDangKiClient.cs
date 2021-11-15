using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UngDungChat
{
    public partial class frmDangKiClient : Form
    {
        List<TaiKhoanDangNhap> listTaiKhoanDangNhap = DanhSachTaiKhoan.Instance.ListTaiKhoanDangNhap;
        public frmDangKiClient()
        {
            InitializeComponent();
        }

        public string MD5(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
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
                listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap(txbTaiKhoan.Text, MD5(txbMatKhau.Text), "user"));
                this.Hide();
                MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo");

                frmDangNhapClient f = new frmDangNhapClient();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhapClient f = new frmDangNhapClient();
            f.Show();
        }

        private void frmDangKiClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmDangKiClient_Load(object sender, EventArgs e)
        {

        }
    }
}
