using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UngDungChat
{
    class TaiKhoanDangNhap
    {
        private string tenDangNhap;

        public string TenDangNhap 
        {
            get => tenDangNhap; 
            set => tenDangNhap = value; 
        }
       
        private string matKhau;
        public string MatKhau 
        { 
            get => matKhau; 
            set => matKhau = value; 
        }

        private string phanQuyen;
        public string PhanQuyen 
        { 
            get => phanQuyen;
            set => phanQuyen = value; 
        }

        public TaiKhoanDangNhap(string tenDangNhap, string matKhau, string phanQuyen)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.phanQuyen = phanQuyen;
        }
    }
}
