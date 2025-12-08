using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mee_Hotel.Entity
{
    class TaiKhoan
    {
        public TaiKhoan() { }
        public TaiKhoan(string MaTaiKhoan, string TenDangNhap, string MatKhau, string MaKH, string MaNV, string VaiTro)
        {
            this.MaTaiKhoan = MaTaiKhoan;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.MaKH = MaKH;
            this.MaNV = MaNV;
            this.VaiTro = VaiTro;
        }
        private string mataikhoan;
        public string MaTaiKhoan { get => mataikhoan; set => mataikhoan = value; }
        private string tendangnhap;
        public string TenDangNhap { get => tendangnhap; set => tendangnhap = value; }
        private string matKhau;
        public string MatKhau { get => matKhau; set => matKhau = value; }
        private string vaitro;
        public string VaiTro { get => vaitro; set => vaitro = value; }
        private string makh;
        public string MaKH { get => makh; set => makh = value; }
        private string manv;
        public string MaNV { get => manv; set => manv = value; }
    }
}
