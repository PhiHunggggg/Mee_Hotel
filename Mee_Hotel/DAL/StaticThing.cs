using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    public static class StaticThing
    {
        public static string LoaiTaiKhoan = null;
        public static string MaNV = null;
        public static string MaKH = null;
        public static string MaQL = null;
        public static string idTaiKhoan = null;
        public static string mk = "";
        public static string TenDangNhap = null;
        public static int chieudai = 0;
        public static int TinhTuoi(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int tuoi = today.Year - ngaySinh.Year;
            return (tuoi < 0) ? 0 : tuoi;
        }
    }

    public static class ThongTinDonHang
    {
        public static string TenKH;
        public static string MaKH;
        public static string NgayDat;
        public static string MaDP;
        /*
        public static string TenKH;
        public static string TenKH;
        public static string TenKH;
        public static string TenKH;
        public static string TenKH;
        */
        public static DateTime NgayBD;
        public static DateTime NgayKT;
        public static Decimal TongTienDV;
        public static DataTable DSPhong;
    }
}
