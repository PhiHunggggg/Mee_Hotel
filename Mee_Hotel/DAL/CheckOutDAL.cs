using System;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    class CheckOutDAL : DataProvider
    {
        private static CheckOutDAL instance;
        public static CheckOutDAL Instance
        {
            get => instance ?? (instance = new CheckOutDAL());
            private set => instance = value;
        }
        private CheckOutDAL() { }

        // Lấy danh sách phòng đang ở (TinhTrang = 2)
        public DataTable GetPhongDangO()
        {
            return DataProvider.Instance.CallProcQuery("proc_GetPhongDangO"); // SELECT MaPhong, TenPhong FROM Phong WHERE TinhTrang = 2
        }

        // Lấy thông tin checkout theo phòng (PhieuDP + KhachHang)
        public DataTable GetThongTinCheckOut(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetThongTinCheckOut", parameters); // Join PhieuDP, KhachHang WHERE MaPhong = @MaPhong AND TrangThai = 2
        }

        // Lấy số ngày ở thực tế (DATEDIFF)
        public int GetSoNgayOThucTe(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            object result = DataProvider.Instance.CallProcScalar("proc_GetSoNgayOThucTe", parameters); // SELECT DATEDIFF(DAY, NgayDen, GETDATE()) FROM PhieuDP WHERE MaPhong = @MaPhong
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // Lấy dịch vụ sử dụng theo phòng
        public DataTable GetDichVuSuDung(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetDichVuSuDungTheoPhong", parameters); // SELECT dv.TenDV, sudv.NgaySuDung, sudv.SoLuong, sudv.DonGiaLucDung FROM SuDungDichVu sudv JOIN DichVu dv ON sudv.MaDV = dv.MaDV WHERE sudv.MaPhong = @MaPhong
        }

        // Lấy phiếu hư hỏng theo phòng (nếu có)
        public DataTable GetHuHongTheoPhong(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetHuHongTheoPhong", parameters); // SELECT tb.TenThietBi, cthh.SoLuongHong, cthh.PhanTramHong, cthh.ThanhTien, cthh.GhiChu FROM ChiTiet_HuHong cthh JOIN TrangThietBi tb ON cthh.MaThietBi = tb.MaTB JOIN Phieu_KiemTraHuHong pk ON cthh.MaPhieu_KTHH = pk.MaPhieu_KTHH WHERE pk.MaPhong = @MaPhong
        }

        // Thực hiện checkout: Update phòng, PhieuDP, tạo hóa đơn nếu cần
        public bool ThucHienCheckOut(string maPhong, string maDP, decimal tongTienDV, decimal tongTienHuHong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@TongTienDV", tongTienDV),
                new SqlParameter("@TongTienHuHong", tongTienHuHong),
                new SqlParameter("@NgayCheckOut", DateTime.Now)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_ThucHienCheckOut", parameters); // UPDATE Phong SET TinhTrang = 1; UPDATE PhieuDP SET TrangThai = 4, NgayTraThucTe = @NgayCheckOut; INSERT INTO HoaDon (...) VALUES (...)
            return result > 0;
        }
    }
}