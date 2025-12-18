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

        public string TaoHoaDon(string MaKH, string MaDP, DateTime NgayThanhToan, decimal TongTienPhong, decimal TongTienHH, decimal Thue, decimal PhiDichVu, string TrangThaiTT, string GhiChu, string MaPhieu_KTHH)
        {
            SqlParameter pMaHoaDon = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 8);
            pMaHoaDon.Direction = ParameterDirection.Output;
            SqlParameter[] pr =
            {
                new SqlParameter("@MaKH", MaKH),
        new SqlParameter("@MaDP", MaDP),
        new SqlParameter("@NgayThanhToan", NgayThanhToan),
        new SqlParameter("@TongTienPhong", TongTienPhong),
        new SqlParameter("@TongTienHH", TongTienHH),
        new SqlParameter("@Thue", Thue),
        new SqlParameter("@PhiDichVu", PhiDichVu),
        new SqlParameter("@TrangThaiTT", TrangThaiTT),
        new SqlParameter("@GhiChu", GhiChu),
        new SqlParameter("@MaPhieu_KTHH", MaPhieu_KTHH),
        pMaHoaDon
            };

            DataProvider.Instance.CallProcNonQuery("sp_ThemHoaDon", pr);

            return pMaHoaDon.Value.ToString(); // 🔥 trả mã HD
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

        public decimal LayTongTienHoaDon(string maHD)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaHD", maHD)
            };

            object result = DataProvider.Instance
                .CallProcScalar("sp_LayTongTienHoaDon", param);

            return (result == null || result == DBNull.Value)
                ? 0
                : Convert.ToDecimal(result);
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

        public DataTable GetSoNgayOThucHD(string maPhongList)
        {
            SqlParameter[] parameters =
            {
            new SqlParameter("@MaPhongList", maPhongList)
        };
            return DataProvider.Instance.CallProcQuery("proc_GetSoNgayOThucTeHD", parameters);
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
            return DataProvider.Instance.CallProcQuery("proc_GetHuHongTheoPhongListHD", parameters);
        }

        public int ThanhToan(string MaHD, string GhiChu, string TT)
        {
            SqlParameter[] pr =
            {
                    new SqlParameter("@MaHD",MaHD),
                    new SqlParameter("@GhiChu",GhiChu),
                    new SqlParameter("@TT",TT)

            };
            return DataProvider.Instance.CallProcNonQuery("sp_ThanhToanHD", pr);
        }

        public int XoaHD(string MaHD)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHD",MaHD)
            };
            return DataProvider.Instance.CallProcNonQuery("XoaHD", pr);
        }

        public int Chitiethd_proc(string MaHD, string MaPhong, decimal Tien, string MaNV)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHD",MaHD),
                new SqlParameter("@MaPhong",MaPhong),
                new SqlParameter("@Tien", SqlDbType.Decimal)
                {
                    Precision = 18,
                    Scale = 2,
                    Value = Tien
                },
                new SqlParameter("@MaNV",MaNV)
            };

            return DataProvider.Instance.CallProcNonQuery("Them_HoaDonCT", pr);
        }
    }





    class HoaDon_DVDAL : DataProvider
    {
        private static HoaDon_DVDAL instance;

        public new static HoaDon_DVDAL Instance
        {
            get
            {
                if (instance == null)
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

            DataTable dt = DataProvider.Instance.CallProcQuery("CheckPhong", pr);

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

            DataTable dt = DataProvider.Instance.CallProcQuery("HienThiDV_Phong", pr);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
        public DataTable GetPhongCuaPhieuHD(string maDP)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDP", maDP)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetPhongCuaPhieuHD", parameters);
        }



    }

}

