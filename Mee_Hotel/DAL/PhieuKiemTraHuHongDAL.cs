using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mee_Hotel.DAL
{
    class PhieuKiemTraHuHongDAL : DataProvider
    {
        private static PhieuKiemTraHuHongDAL instance;
        public new static PhieuKiemTraHuHongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuKiemTraHuHongDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private PhieuKiemTraHuHongDAL() { }

        // 1. Lấy danh sách thiết bị trong phòng 
        public DataTable GetThietBiTheoPhong(string maPhong)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", maPhong)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetThietBiTheoPhong", parameters);
        }

        // 2. Lấy danh sách phòng đang ở 
        public DataTable GetDanhSachPhongDangO()
        {
            return DataProvider.Instance.CallProcQuery("proc_GetDanhSachPhongDangO");
        }

        // 3. Tạo mã phiếu mới tự động
        public string TaoMaPhieuMoi()
        {
            object result = DataProvider.Instance.CallProcScalar("proc_TaoMaPhieuKiemTraHuHong");
            return result?.ToString() ?? "KTHH001";
        }

        // 4. Lấy danh sách tất cả phiếu kiểm tra 
        public DataTable GetDanhSachPhieu(string maPhieu = "", string maPhong = "", string maNV = "", DateTime? ngayTim = null)
        {
            SqlParameter[] parameters =
            {
        new SqlParameter("@MaPhieu", string.IsNullOrEmpty(maPhieu) ? (object)DBNull.Value : maPhieu),
        new SqlParameter("@MaPhong", string.IsNullOrEmpty(maPhong) ? (object)DBNull.Value : maPhong),
        new SqlParameter("@MaNV", string.IsNullOrEmpty(maNV) ? (object)DBNull.Value : maNV),
        new SqlParameter("@NgayKiemTra", ngayTim.HasValue ? (object)ngayTim.Value : DBNull.Value)
    };

            return DataProvider.Instance.CallProcQuery("proc_GetDanhSachPhieuKiemTra", parameters);
        }


        // 5. Lấy thông tin 1 phiếu kiểm tra theo mã 
        public DataRow GetPhieuByMa(string maPhieu)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu_KTHH", maPhieu)
            };
            DataTable dt = DataProvider.Instance.CallProcQuery("proc_GetPhieuKiemTraByMa", parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // 6. Lấy chi tiết hư hỏng của 1 phiếu
        public DataTable GetChiTietPhieu(string maPhieu)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu_KTHH", maPhieu)
            };
            return DataProvider.Instance.CallProcQuery("proc_GetChiTietPhieuKiemTra", parameters);
        }
        // 7. Thêm phiếu mới 
        public bool ThemPhieu(string maPhieu, string maPhong, string maNV, DateTime ngayKiemTra, DataTable chiTietHuHong)
        {
            return LuuPhieu(maPhieu, maPhong, maNV, ngayKiemTra, chiTietHuHong, isUpdate: false);
        }

        // 8. Sửa phiếu
        public bool SuaPhieu(string maPhieu, string maPhong, string maNV, DateTime ngayKiemTra, DataTable chiTietHuHong)
        {
            return LuuPhieu(maPhieu, maPhong, maNV, ngayKiemTra, chiTietHuHong, isUpdate: true);
        }

        // 9. Hàm chung LuuPhieu
        private bool LuuPhieu(string maPhieu, string maPhong, string maNV, DateTime ngayKiemTra, DataTable chiTietHuHong, bool isUpdate)
        {
            try
            {
                // Bước 1: Nếu là sửa → xóa chi tiết cũ
                if (isUpdate)
                {
                    SqlParameter[] delParam = { new SqlParameter("@MaPhieu_KTHH", maPhieu) };
                    DataProvider.Instance.CallProcNonQuery("proc_XoaChiTietPhieu", delParam);
                }

                // Bước 2: Thêm/Sửa phiếu chính 
                SqlParameter[] paramPhieu =
                {
            new SqlParameter("@MaPhieu_KTHH", maPhieu),
            new SqlParameter("@MaPhong", maPhong),
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@NgayKiemTra", ngayKiemTra)
        };

                string procName = isUpdate ? "proc_SuaPhieuKiemTraHuHong" : "proc_ThemPhieuKiemTraHuHong";
                int result = DataProvider.Instance.CallProcNonQuery(procName, paramPhieu);
                if (result <= 0) return false;

                // Bước 3: Lưu chi tiết hư hỏng
                foreach (DataRow row in chiTietHuHong.Rows)
                {
                    int slHong = Convert.ToInt32(row["SoLuongHong"]);
                    if (slHong <= 0) continue;

                    SqlParameter[] paramCT =
                    {
                new SqlParameter("@MaPhieu_KTHH", maPhieu),
                new SqlParameter("@MaThietBi", row["MaThietBi"]),
                new SqlParameter("@SoLuongHong", slHong),
                new SqlParameter("@PhanTramHong", row["PhanTramHong"] == DBNull.Value ? (object)DBNull.Value : row["PhanTramHong"]),
                new SqlParameter("@ThanhTien", Convert.ToDecimal(row["ThanhTien"])),
                new SqlParameter("@GhiChu", row["GhiChu"] == DBNull.Value || string.IsNullOrEmpty(row["GhiChu"].ToString())
                    ? (object)DBNull.Value : row["GhiChu"])
            };

                    result = DataProvider.Instance.CallProcNonQuery("proc_ThemChiTietHuHong", paramCT);
                    if (result <= 0) return false;
                }

                // Bước 4: Cập nhật tổng tiền 
                SqlParameter[] updateParam = { new SqlParameter("@MaPhieu_KTHH", maPhieu) };
                int updateResult = DataProvider.Instance.CallProcNonQuery("proc_UpdateTongTienPhieu", updateParam);

                // Nếu update tổng tiền thất bại thì cũng báo lỗi 
                if (updateResult <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("Cảnh báo: Không cập nhật được tổng tiền cho phiếu " + maPhieu);
                }
                return true;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("LỖI KHI LƯU PHIẾU:\n" + ex.Message + "\n\nStackTrace:\n" + ex.StackTrace,
                                "LỖI HỆ THỐNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine("Lỗi lưu phiếu KTHH: " + ex.Message);
                return false;
            }
        }
        public bool XoaPhieu(string maPhieu)
             {
             SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu_KTHH", maPhieu)
            };

           
            int result = DataProvider.Instance.CallProcNonQuery("proc_XoaPhieuKiemTraHuHong", parameters);
            return result > 0;
        }
    }
}