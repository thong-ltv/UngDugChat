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
    public partial class frmDangNhapClient : Form
    {
        List<TaiKhoanDangNhap> listTaiKhoanDangNhap = DanhSachTaiKhoan.Instance.ListTaiKhoanDangNhap;
        public frmDangNhapClient()
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 2)
            {
                //FormClient f1 = new FormClient();
                //f1.Show();
                //FormServer f = new FormServer();
                //f.Show();
                this.Hide();

                FormClient f1 = new FormClient();
                f1.Show();
            }
            else if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
            {
                frmAdmmin f2 = new frmAdmmin();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Loi");
                txtTaiKhoan.Focus();
            }
        }

        private void frmDangNhapClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            for (int i = 0; i < listTaiKhoanDangNhap.Count; i++)
            {
                if (tenDangNhap == listTaiKhoanDangNhap[i].TenDangNhap && MD5(matKhau) == listTaiKhoanDangNhap[i].MatKhau && listTaiKhoanDangNhap[i].PhanQuyen == "admin")
                {
                    return 1;
                }
                if (tenDangNhap == listTaiKhoanDangNhap[i].TenDangNhap && MD5(matKhau) == listTaiKhoanDangNhap[i].MatKhau && listTaiKhoanDangNhap[i].PhanQuyen == "user")
                {
                    return 2;
                }
            }
            return 0;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangKiClient f = new frmDangKiClient();
            f.Show();
            this.Hide();
        }

        private void frmDangNhapClient_Load(object sender, EventArgs e)
        {

        }
    }
}
