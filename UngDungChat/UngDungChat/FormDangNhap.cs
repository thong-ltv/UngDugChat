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
    public partial class FormDangNhap : Form
    {
        List<TaiKhoanDangNhap> listTaiKhoanDangNhap = DanhSachTaiKhoan.Instance.ListTaiKhoanDangNhap;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 2)
            {
                FormClient f1 = new FormClient();
                f1.Show();
                FormServer f = new FormServer();
                f.Show();

                this.Hide();
            }
            else if(KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
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

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            for(int i = 0; i < listTaiKhoanDangNhap.Count; i++)
            {
                if (tenDangNhap == listTaiKhoanDangNhap[i].TenDangNhap && matKhau == listTaiKhoanDangNhap[i].MatKhau && listTaiKhoanDangNhap[i].PhanQuyen == "admin")
                {
                    return 1;
                }
                if (tenDangNhap == listTaiKhoanDangNhap[i].TenDangNhap && matKhau == listTaiKhoanDangNhap[i].MatKhau && listTaiKhoanDangNhap[i].PhanQuyen == "user")
                {
                    return 2;
                }
            }
            return 0;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangKi f = new frmDangKi();
            f.Show();
            this.Hide();
        }
    }
}
