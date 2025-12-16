using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    class HoaDonDAL : DataProvider
    {
        private static HoaDonDAL instance;
        public new static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private HoaDonDAL() { }

        public DataTable getDanhSachCheckOut(String phong, String hoTen, String SDT, DateTime tuNgay, DateTime denNgay)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@Phong", phong),
                new SqlParameter("@HoTen",hoTen),
                new SqlParameter("@SDT",SDT),
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };

            DataTable dt = DataProvider.Instance.CallProcQuery("getDanhSachCheckOut", pr);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public DataTable getDanhSachCO()
        {
            DataTable dt = DataProvider.Instance.CallProcQuery("getDanhSachCO");

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public int TaoHoaDon(String MaKH, String MaDP, DateTime NgayThanhToan, Decimal TongTien, Decimal Thue, Decimal PhiDichVu, String TrangThaiTT, String GhiChu, String MaPhieu_KTTH)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaDP", MaDP),
                new SqlParameter("@NgayThanhToan", NgayThanhToan),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@Thue", Thue),
                new SqlParameter("@PhiDichVu", PhiDichVu),
                new SqlParameter("@TrangThaiTT", TrangThaiTT),
                new SqlParameter("@GhiChu", GhiChu),
                new SqlParameter("@MaPhieu_KTTH", MaPhieu_KTTH),
            };

            int tst = DataProvider.Instance.CallProcNonQuery("sp_ThemHoaDon", pr);

            return tst;
        }

        public DataTable HienThiHoaDon()
        {
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_LoadHDFull");
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public DataTable getDanhSachHD(String MaHD, String hoTen, String SDT, DateTime tuNgay, DateTime denNgay)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@HoTen",hoTen),
                new SqlParameter("@SDT",SDT),
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };

            DataTable dt = DataProvider.Instance.CallProcQuery("getDanhSachHD", pr);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }

    class HoaDon_DVDAL : DataProvider
    {
        private static HoaDon_DVDAL instance;
         
        public new static HoaDon_DVDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new HoaDon_DVDAL(); 
                }
                return instance;
            }
            private set => instance = value;
        }

        private HoaDon_DVDAL() { }

        public DataTable GetDanhSachPhong(String MaDP)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaDP",MaDP)
            };

            DataTable dt = DataProvider.Instance.CallProcQuery("CheckPhong",pr);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public DataTable HienThiDV_Phong(String MaPhong)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaPhong", MaPhong)
            };

            DataTable dt = DataProvider.Instance.CallProcQuery("HienThiDV_Phong",pr);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        
    }

    
}

