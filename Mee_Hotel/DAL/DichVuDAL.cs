using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Mee_Hotel.DAL
{
    class DichVuDAL : DataProvider
    {
        private static DichVuDAL instance;
        public new static DichVuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DichVuDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private DichVuDAL() { }

        public DataTable getDanhSachDichVu(String tuKhoa, DateTime? tuNgay, DateTime? denNgay)
        {
            SqlParameter[] pr =
           {
                new SqlParameter("@TuKhoa", tuKhoa),
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay),


             };

            DataTable dt = DataProvider.Instance.CallProcQuery("sp_getDanhSachDichVuKhachHang", pr);

            if (dt.Rows.Count == 0)
                return null;

            return dt;
        }
        public DataTable getDanhSachDichVu(DateTime? tuNgay, DateTime? denNgay)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay),
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_getDanhSachDichVu", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public (bool Success, string Message, DataTable Data) ThemDichVuPhong(string maPhong, string maDV, DateTime? ngay, int soLuong, string maNV = null, string ghiChu = null)
        {
            {
                SqlParameter[] p =
                {
        new SqlParameter("@MaPhong", maPhong),
        new SqlParameter("@MaDV", maDV),
        new SqlParameter("@NgaySuDung", (object)ngay ?? DBNull.Value),
        new SqlParameter("@SoLuong", soLuong),
        new SqlParameter("@MaNV", (object)maNV ?? DBNull.Value),
        new SqlParameter("@GhiChu", (object)ghiChu ?? DBNull.Value),

        new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
        new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
    };

                DataTable dt = DataProvider.Instance.CallProcQuery("sp_ThemDichVuChoPhong", p);

                bool ok = Convert.ToBoolean(p[6].Value);
                string msg = p[7].Value.ToString();

                return (ok, msg, dt);
            }
        }
        public DataTable getDichVubyMaDichVu(string MaDichVu)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaDichVu", MaDichVu)
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_getDichVubyMaDichVu", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public (bool Success, string Message, DataTable Data) SuaDichVuPhong(
    string maPhong, string maDV, DateTime ngaySuDung, int soLuongMoi,
    string maNV_Sua = null, string ghiChuMoi = null)
        {
            SqlParameter[] p =
            {
        new SqlParameter("@MaPhong", maPhong),
        new SqlParameter("@MaDV", maDV),
        new SqlParameter("@NgaySuDung", ngaySuDung),
        new SqlParameter("@SoLuongMoi", soLuongMoi),
        new SqlParameter("@GhiChuMoi", (object)ghiChuMoi ?? DBNull.Value),
        new SqlParameter("@MaNV_Sua", (object)maNV_Sua ?? DBNull.Value),

        new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
        new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
    };

            DataTable dt = DataProvider.Instance.CallProcQuery("sp_SuaDichVuPhong", p);

            return (
                Convert.ToBoolean(p[6].Value),
                p[7].Value.ToString(),
                dt
            );
        }
        public (bool Success, string Message) XoaDichVuPhong(
        string maPhong, string maDV, DateTime ngaySuDung, string maNV_Xoa = null)
        {
            SqlParameter[] p =
            {
        new SqlParameter("@MaPhong", maPhong),
        new SqlParameter("@MaDV", maDV),
        new SqlParameter("@NgaySuDung", ngaySuDung),
        new SqlParameter("@MaNV_Xoa", (object)maNV_Xoa ?? DBNull.Value),

        new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
        new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
        };

            DataProvider.Instance.CallProcNonQuery("sp_XoaDichVuPhong", p);

            return (
                Convert.ToBoolean(p[4].Value),
                p[5].Value.ToString()
            );
        }
    }

}

