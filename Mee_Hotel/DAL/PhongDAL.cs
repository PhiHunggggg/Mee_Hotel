using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;
using Mee_Hotel.Entity;
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
        public DataTable getDanhSachPhong()
        {
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_DanhSachPhongCoCanhBao");

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable ThongKePhongTrongChoDatPhong(DateTime ngayDen, DateTime ngayTra)
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
        public DataTable getDanhSachPhongTrongTheoNgay(DateTime ngayDen, DateTime ngayTra, string maLoaiPhong)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@NgayNhan",ngayDen),
                new SqlParameter("@NgayTra", ngayTra),
                new SqlParameter("@MaLoaiPhong", maLoaiPhong),
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_DanhSachPhongTrongKhoangNgay", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public ThongKePhongcs getThongKeTinhTrangPhong()
        {
            try
            {
                DataTable dt = DataProvider.Instance.CallProcQuery("sp_ThongKeTrangThaiPhong", null);

                if (dt.Rows.Count == 0)
                    return new ThongKePhongcs(); // trả về 0 hết

                DataRow row = dt.Rows[0];

                return new ThongKePhongcs
                {
                    TongPhong = Convert.ToInt32(row["TongSoPhong"]),
                    PhongTrong = Convert.ToInt32(row["PhongTrong"]),
                    PhongDangO = Convert.ToInt32(row["PhongDangO"]),
                    PhongDangDon = Convert.ToInt32(row["PhongDangDon"])
                };
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                MessageBox.Show("Lỗi thống kê phòng: " + ex.Message);
                return new ThongKePhongcs();
            }
        }
        public DataTable getDanhSachPhongTrong_CheckIn(string maLoaiPhong)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@LoaiPhong", maLoaiPhong),
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_LayPhongTring_CheckIn", pr);

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public (DataRow ThongTin, DataTable ChiTiet, decimal TongTien, string Loi) LayThongTinPhieuDat(string maDP)
        {
            if (string.IsNullOrWhiteSpace(maDP))
                return (null, null, 0, "Mã phiếu trống!");

            SqlParameter[] p = { new SqlParameter("@MaDP", maDP) };

            try
            {
                DataSet ds = DataProvider.Instance.CallProcQuerySet("sp_LayThongTinPhieuDat", p);

                // ds có 3 bảng: 0=Thông tin, 1=Chi tiết, 2=Tổng tiền
                if (ds == null || ds.Tables.Count < 3)
                    return (null, null, 0, "Không tìm thấy phiếu đặt phòng!");

                // Bảng 0: Thông tin phiếu + khách
                DataTable tbPhieu = ds.Tables[0];
                if (tbPhieu.Rows.Count == 0 || tbPhieu.Rows[0]["TrangThai"].ToString() == "ERROR")
                    return (null, null, 0, tbPhieu.Rows.Count > 0
                        ? tbPhieu.Rows[0]["ThongBao"].ToString()
                        : "Không tìm thấy phiếu!");
                if (tbPhieu.Rows[0]["TrangThai"].ToString() == "3")
                {
                    return (null, null, 0, "Phiếu đã checkin !");
                }
                if (tbPhieu.Rows[0]["TrangThai"].ToString() == "2")
                {
                    return (null, null, 0, "Phiếu đã bị từ chối !");
                }
                if (tbPhieu.Rows[0]["TrangThai"].ToString() == "4")
                {
                    return (null, null, 0, "Phiếu đã checkout !");
                }
                // Bảng 1: Chi tiết loại phòng đặt
                DataTable tbChiTiet = ds.Tables[1];

                // Bảng 2: Tổng tiền
                decimal tongTien = tbChiTiet.Compute("SUM(ThanhTien)", "") is DBNull
                    ? 0
                    : Convert.ToDecimal(tbChiTiet.Compute("SUM(ThanhTien)", ""));

                return (tbPhieu.Rows[0], tbChiTiet, tongTien, "OK");
            }
            catch (Exception ex)
            {
                return (null, null, 0, "Lỗi CSDL: " + ex.Message);
            }
        }
        public bool CheckInPhieu(string maDP, List<string> dsMaPhong, string maNV, out string loi)
        {
            XElement root = new XElement("root");
            foreach (var maPhong in dsMaPhong)
            {
                root.Add(new XElement("r", new XElement("p", maPhong)));
            }
            string xmlPhong = root.ToString(SaveOptions.DisableFormatting);
            MessageBox.Show(xmlPhong);
            SqlParameter[] p = {
        new SqlParameter("@MaDP", maDP),
        new SqlParameter("@DanhSachPhong", xmlPhong),
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@KetQua", SqlDbType.Bit) { Direction = ParameterDirection.Output },
        new SqlParameter("@Loi", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output }
    };

            try
            {
                DataProvider.Instance.CallProcNonQuery("sp_CheckInPhieuDatPhong", p);

                loi = p[4].Value?.ToString() ?? "";
                return Convert.ToBoolean(p[3].Value);
            }
            catch (Exception ex)
            {
                loi = "Lỗi: " + ex.Message;
                return false;
            }
        }
public DataTable TimKiemPhieuDatPhong(
    out string loi,
    string tuKhoa = null,
    DateTime? ngayDenTu = null,
    DateTime? ngayDenDen = null,
    DateTime? ngayTraTu = null,
    DateTime? ngayTraDen = null,
    int? trangThai = null)
        {
            loi = "";
            DataTable dt = new DataTable();

            SqlParameter[] parameters =
            {
        new SqlParameter("@TuKhoa", (object)tuKhoa ?? DBNull.Value),
        new SqlParameter("@NgayDenTu", (object)ngayDenTu ?? DBNull.Value),
        new SqlParameter("@NgayDenDen", (object)ngayDenDen ?? DBNull.Value),
        new SqlParameter("@NgayTraTu", (object)ngayTraTu ?? DBNull.Value),
        new SqlParameter("@NgayTraDen", (object)ngayTraDen ?? DBNull.Value),
        new SqlParameter("@TrangThai", (object)trangThai ?? DBNull.Value)
    };

            try
            {
                dt = DataProvider.Instance.CallProcQuery("sp_TimKiemPhieuDatPhong", parameters);

                // Nếu không có kết quả nào, trả về bảng rỗng để tránh lỗi khi bind
                if (dt.Rows.Count == 0)
                {
                    // Có thể thêm dòng thông báo nếu muốn
                    // DataRow emptyRow = dt.NewRow();
                    // emptyRow["MaDP"] = "Không tìm thấy phiếu đặt phòng nào.";
                    // dt.Rows.Add(emptyRow);
                }
            }
            catch (Exception ex)
            {
                loi = "Lỗi khi tìm kiếm phiếu đặt phòng: " + ex.Message;
                // Trả về bảng rỗng có cấu trúc để giao diện không crash
                return null;
            }

            return dt;
        }
        public bool SuaPhieuDatPhong(
           out string loi,
           string maDP,
           DateTime? ngayDenMoi,
           DateTime? ngayTraMoi,
           int? soNguoiMoi,
           string ghiChuMoi,
           string xmlLoaiPhongMoi = null)
        {
            loi = "";

            bool coThayDoiNgay = ngayDenMoi.HasValue || ngayTraMoi.HasValue;
            bool coThayDoiSoNguoi = soNguoiMoi.HasValue;
            bool coThayDoiGhiChu = !string.IsNullOrEmpty(ghiChuMoi);
            bool coThayDoiLoaiPhong = !string.IsNullOrEmpty(xmlLoaiPhongMoi);

            if (!coThayDoiNgay && !coThayDoiSoNguoi && !coThayDoiGhiChu && !coThayDoiLoaiPhong)
            {
                loi = "Không có thông tin nào để cập nhật!";
                return false;
            }

            var parameters = new[]
            {
        new SqlParameter { ParameterName = "@MaDP", Value = maDP },
        new SqlParameter { ParameterName = "@NgayDenMoi", Value = (object)ngayDenMoi ?? DBNull.Value },
        new SqlParameter { ParameterName = "@NgayTraMoi", Value = (object)ngayTraMoi ?? DBNull.Value },
        new SqlParameter { ParameterName = "@SoNguoiMoi", Value = (object)soNguoiMoi ?? DBNull.Value },
        new SqlParameter { ParameterName = "@GhiChuMoi", Value = (object)ghiChuMoi ?? DBNull.Value },
        new SqlParameter
        {
            ParameterName = "@DanhSachLoaiPhongMoi",
            Value = !string.IsNullOrEmpty(xmlLoaiPhongMoi) ? xmlLoaiPhongMoi : (object)DBNull.Value,
            SqlDbType = string.IsNullOrEmpty(xmlLoaiPhongMoi) ? SqlDbType.Xml : SqlDbType.Xml
        }
    };

            try
            {
                DataProvider.Instance.CallProcNonQuery("sp_SuaPhieuDatPhong", parameters);
                return true;
            }
            catch (SqlException ex)
            {
                loi = ex.Number >= 50000 ? ex.Message : "Lỗi cơ sở dữ liệu: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                loi = "Lỗi không xác định: " + ex.Message;
                return false;
            }
        }
        public bool XoaPhieuDatPhong(string maDP, string lyDoHuy, out string loi)
        {
            loi = "";

            SqlParameter[] parameters =
            {
        new SqlParameter("@MaDP", maDP),
        new SqlParameter("@LyDoHuy", (object)lyDoHuy ?? DBNull.Value)
    };

            try
            {
                DataProvider.Instance.CallProcNonQuery("sp_XoaPhieuDatPhong", parameters);
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number >= 50000)
                    loi = ex.Message;
                else
                    loi = "Lỗi cơ sở dữ liệu: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                loi = "Lỗi không xác định: " + ex.Message;
                return false;
            }
        }
    }
}
