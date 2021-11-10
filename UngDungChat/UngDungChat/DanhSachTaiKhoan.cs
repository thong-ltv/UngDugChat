using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UngDungChat
{
    class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        internal static DanhSachTaiKhoan Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance; 
            } 
            set => instance = value; 
        }

        List<TaiKhoanDangNhap> listTaiKhoanDangNhap;

        internal List<TaiKhoanDangNhap> ListTaiKhoanDangNhap 
        { 
            get => listTaiKhoanDangNhap; 
            set => listTaiKhoanDangNhap = value; 
        }

        DanhSachTaiKhoan()
        {
            listTaiKhoanDangNhap = new List<TaiKhoanDangNhap>();
            listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap("thong", "123", "admin"));
            listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap("phong", "123", "admin"));
            listTaiKhoanDangNhap.Add(new TaiKhoanDangNhap("huan", "123", "user"));
        }
    }
}
