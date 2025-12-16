// TrangThietBiDAL.cs
using System;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    class TrangThietBiDAL : DataProvider
    {
        private static TrangThietBiDAL instance;
        public static TrangThietBiDAL Instance
        {
            get => instance ?? (instance = new TrangThietBiDAL());
            private set => instance = value;
        }
        private TrangThietBiDAL() { }

        



        public DataTable GetLoaiPhong()
        {
            return DataProvider.Instance.CallProcQuery("proc_GetLoaiPhong"); // Stored proc: SELECT MaLoaiPhong, TenLoaiPhong FROM LoaiPhong
        }

        



        public DataTable GetPhongTheoLoai(string maLoaiPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaLoaiPhong", maLoaiPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetPhongTheoLoai", parameters); // Stored proc: SELECT MaPhong, TenPhong FROM Phong WHERE MaLoaiPhong = @MaLoaiPhong
        }

        


        public DataTable GetAllTrangThietBi()
        {
            return DataProvider.Instance.CallProcQuery("proc_GetAllTrangThietBi"); // Stored proc: SELECT MaTB, TenThietBi FROM TrangThietBi
        }

        


        public DataTable GetTrangThietBiTheoPhong(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetTrangThietBiTheoPhong", parameters); // Stored proc: SELECT tb.MaTB, tb.TenThietBi, ttbp.SoLuongGoc, ttbp.SoLuongHienTai FROM TrangThietBi_Phong ttbp JOIN TrangThietBi tb ON ttbp.MaTB = tb.MaTB WHERE ttbp.MaPhong = @MaPhong
        }

       


        public bool ThemTrangThietBiPhong(string maPhong, string maTB, int soLuongGoc, int soLuongHienTai)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaTB", maTB),
                new SqlParameter("@SoLuongGoc", soLuongGoc),
                new SqlParameter("@SoLuongHienTai", soLuongHienTai)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_ThemTrangThietBiPhong", parameters); // Stored proc: INSERT INTO TrangThietBi_Phong (MaPhong, MaTB, SoLuongGoc, SoLuongHienTai) VALUES (@MaPhong, @MaTB, @SoLuongGoc, @SoLuongHienTai)
            return result > 0;
        }

        


        public bool SuaTrangThietBiPhong(string maPhong, string maTB, int soLuongGocMoi, int soLuongHienTaiMoi)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaTB", maTB),
                new SqlParameter("@SoLuongGocMoi", soLuongGocMoi),
                new SqlParameter("@SoLuongHienTaiMoi", soLuongHienTaiMoi)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_SuaTrangThietBiPhong", parameters); // Stored proc: UPDATE TrangThietBi_Phong SET SoLuongGoc = @SoLuongGocMoi, SoLuongHienTai = @SoLuongHienTaiMoi WHERE MaPhong = @MaPhong AND MaTB = @MaTB
            return result > 0;
        }

        


        public bool XoaTrangThietBiPhong(string maPhong, string maTB)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaTB", maTB)
            };
            int result = DataProvider.Instance.CallProcNonQuery("proc_XoaTrangThietBiPhong", parameters); // Stored proc: DELETE FROM TrangThietBi_Phong WHERE MaPhong = @MaPhong AND MaTB = @MaTB
            return result > 0;
        }
    }
}