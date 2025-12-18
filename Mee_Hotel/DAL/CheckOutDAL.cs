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
            
        // Lấy số ngày ở thực tế cho nhiều phòng
        public DataTable GetSoNgayOThucTeList(string maPhongList)
        {
            SqlParameter[] parameters =
            {
             new SqlParameter("@MaPhongList", maPhongList)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetSoNgayOThucTeList", parameters);
        }
        // Lấy dịch vụ sử dụng cho nhiều phòng
        public DataTable GetDichVuTheoPhongList(string maPhongList)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@MaPhongList", maPhongList)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetDichVuTheoPhongList", parameters);
        }
        // Lấy hư hỏng cho nhiều phòng
        public DataTable GetHuHongTheoPhongList(string maPhongList)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@MaPhongList", maPhongList)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetHuHongTheoPhongList", parameters);
        }
        // Tìm phiếu đã check in
        public DataTable GetPhieuDaCheckIn(string maDP = "", string tenKH = "", string sdt = "", string cccd = "")
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDP", string.IsNullOrEmpty(maDP) ? (object)DBNull.Value : maDP),
                new SqlParameter("@TenKH", string.IsNullOrEmpty(tenKH) ? (object)DBNull.Value : tenKH),
                new SqlParameter("@SDT", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt),
                new SqlParameter("@CCCD", string.IsNullOrEmpty(cccd) ? (object)DBNull.Value : cccd)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetPhieuDaCheckIn", parameters);
        }
        // Lấy phòng của phiếu
        public DataTable GetPhongCuaPhieu(string maDP)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDP", maDP)
        };
            return DataProvider.Instance.CallProcQuery("proc_GetPhongCuaPhieu", parameters);
        }
        // Check out batch
        public bool CheckOutTheoPhieu(string maDP, decimal tongTienDV, decimal tongTienHuHong, string maPhongList)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@TongTienDV", tongTienDV),
                new SqlParameter("@TongTienHuHong", tongTienHuHong),
                new SqlParameter("@NgayCheckOut", DateTime.Now),
                new SqlParameter("@MaPhongList", maPhongList)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_CheckOutTheoPhieu", parameters);
            return result > 0;
        }
    }
}