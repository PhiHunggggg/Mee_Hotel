using System;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    class CheckOutDAL : DataProvider
    {
        private static CheckOutDAL instance;
        public new static CheckOutDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckOutDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private CheckOutDAL() { }

        // Lấy danh sách phòng đang ở (TinhTrang = 3) 
        public DataTable GetDanhSachPhongDangO()
        {
            return DataProvider.Instance.CallProcQuery("proc_GetDanhSachPhongDangO");         }

        // Lấy thông tin checkout theo phòng (PhieuDP + KhachHang)
        public DataTable GetThongTinCheckOut(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetThongTinCheckOut", parameters);         }

        // Lấy số ngày ở thực tế (DATEDIFF)
        public int GetSoNgayOThucTe(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            object result = DataProvider.Instance.CallProcScalar("proc_GetSoNgayOThucTe", parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // Lấy dịch vụ sử dụng theo phòng
        public DataTable GetDichVuTheoPhong (string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetDichVuTheoPhong", parameters); 
        }

        // Lấy phiếu hư hỏng theo phòng (nếu có)
        public DataTable GetHuHongTheoPhong(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetHuHongTheoPhong", parameters); 
        }

        // Thực hiện checkout: Update phòng, PhieuDP, tạo hóa đơn nếu cần
        public bool CheckOut(string maPhong, string maDP, decimal tongTienDV, decimal tongTienHuHong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@TongTienDV", tongTienDV),
                new SqlParameter("@TongTienHuHong", tongTienHuHong),
                new SqlParameter("@NgayCheckOut", DateTime.Now)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_CheckOut", parameters); 
            return result > 0;
        }
    }
}