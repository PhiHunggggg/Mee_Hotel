using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace Mee_Hotel.DAL
{
    class PhongDAL : DataProvider
    {
        private static PhongDAL instance;
        public new static PhongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private PhongDAL() { }
        public DataTable getKhachHangHienTai(string maPhong)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaPhong", maPhong)
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_getKhachHang_Phong_HienTai", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable ThongKePhongTrongChoDatPhong(DateTime ngayDen,DateTime ngayTra)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@NgayNhan", ngayDen),
                new SqlParameter("@NgayTra", ngayTra),
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_ThongKePhongTrongChoDatPhong", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public (bool KetQua, string Loi, string MaPhieu, string MaKhach) DatPhongTuXMLSan(
        DateTime ngayNhan,
        DateTime ngayTra,
        string hoTen,
        string cccd = null,
        string sdt = null,
        DateTime? ngaySinh = null,
        string gioiTinh = null,
        string quocTich = "Việt Nam",
        string diaChi = null,
        string email = null,


        int soNguoi = 2,

        string xmlDaTaoSan = "<root></root>",   // bắt buộc truyền, dù rỗng

        string ghiChu = null,
        string maNV = "NV001")
        {
            // Kiểm tra XML có hợp lệ không
            if (string.IsNullOrWhiteSpace(xmlDaTaoSan) || xmlDaTaoSan == "<root></root>" || !xmlDaTaoSan.Contains("<lp>"))
                return (false, "Danh sách phòng đặt trống hoặc không hợp lệ!", null, null);

            SqlParameter[] p =
            {
        new SqlParameter("@HoTen", hoTen),
        new SqlParameter("@CCCD", (object)cccd ?? DBNull.Value),
        new SqlParameter("@SDT", (object)sdt ?? DBNull.Value),
        new SqlParameter("@NgaySinh", (object)ngaySinh ?? DBNull.Value),
        new SqlParameter("@GioiTinh", (object)gioiTinh ?? DBNull.Value),
        new SqlParameter("@QuocTich", quocTich ?? "Việt Nam"),
        new SqlParameter("@DiaChi", (object)diaChi ?? DBNull.Value),
        new SqlParameter("@Email", (object)email ?? DBNull.Value),

        new SqlParameter("@NgayNhan", ngayNhan.Date),
        new SqlParameter("@NgayTra", ngayTra.Date),
        new SqlParameter("@SoLuong", soNguoi),

        new SqlParameter("@DanhSachPhong", xmlDaTaoSan),   // DÙNG THẲNG XML TỪ FORM KHÁC

        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@GhiChu", (object)ghiChu ?? DBNull.Value),

        // OUTPUT
        new SqlParameter("@MaDP", SqlDbType.VarChar, 8) { Direction = ParameterDirection.Output },
        new SqlParameter("@MaKH", SqlDbType.VarChar, 8) { Direction = ParameterDirection.Output },
        new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
        new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
    };

            try
            {
                DataProvider.Instance.CallProcQuery("sp_DatPhong", p);

                return (
                    Convert.ToBoolean(p[15].Value),
                    p[16].Value?.ToString() ?? "",
                    p[13].Value?.ToString(),
                    p[14].Value?.ToString()
                );
            }
            catch (Exception ex)
            {
                return (false, "Lỗi kết nối CSDL: " + ex.Message, null, null);
            }
        }
        public (bool KetQua, string Loi, string MaPhieu, string MaKhach) DatPhongTuXMLSan2(
    DateTime ngayNhan,
    DateTime ngayTra,
    string hoTen,
    string cccd = null,
    string sdt = null,
    DateTime? ngaySinh = null,
    string gioiTinh = null,
    string quocTich = "Việt Nam",
    string diaChi = null,
    string email = null,
    int soNguoi = 2,
    string xmlDaTaoSan = "<root></root>",
    string ghiChu = null,
    string maNV = "NV001")
        {
            if (string.IsNullOrWhiteSpace(xmlDaTaoSan) || xmlDaTaoSan == "<root></root>" || !xmlDaTaoSan.Contains("<lp>"))
                return (false, "Danh sách phòng đặt trống hoặc không hợp lệ!", null, null);

            using (SqlConnection conn = new SqlConnection(SQL_Connection.StrCon))
            using (SqlCommand cmd = new SqlCommand("sp_DatPhong", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(new SqlParameter[]
                {
            new SqlParameter("@HoTen", hoTen),
            new SqlParameter("@CCCD", (object)cccd ?? DBNull.Value),
            new SqlParameter("@SDT", (object)sdt ?? DBNull.Value),
            new SqlParameter("@NgaySinh", (object)ngaySinh ?? DBNull.Value),
            new SqlParameter("@GioiTinh", (object)gioiTinh ?? DBNull.Value),
            new SqlParameter("@QuocTich", quocTich ?? "Việt Nam"),
            new SqlParameter("@DiaChi", (object)diaChi ?? DBNull.Value),
            new SqlParameter("@Email", (object)email ?? DBNull.Value),
            new SqlParameter("@NgayNhan", ngayNhan.Date),
            new SqlParameter("@NgayTra", ngayTra.Date),
            new SqlParameter("@SoLuong", soNguoi),
            new SqlParameter("@DanhSachPhong", xmlDaTaoSan),
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@GhiChu", (object)ghiChu ?? DBNull.Value),

            new SqlParameter("@MaDP", SqlDbType.VarChar, 8) { Direction = ParameterDirection.Output },
            new SqlParameter("@MaKH", SqlDbType.VarChar, 8) { Direction = ParameterDirection.Output },
            new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
            new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
                });

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // ← DÙNG CÁI NÀY MỚI ĐỌC ĐƯỢC OUTPUT!

                    return (
                        Convert.ToBoolean(cmd.Parameters["@KetQua"].Value),
                        cmd.Parameters["@Loi"].Value?.ToString() ?? "",
                        cmd.Parameters["@MaDP"].Value?.ToString(),
                        cmd.Parameters["@MaKH"].Value?.ToString()
                    );
                }
                catch (Exception ex)
                {
                    return (false, "Lỗi kết nối CSDL: " + ex.Message, null, null);
                }
            }
        }
    }
}
