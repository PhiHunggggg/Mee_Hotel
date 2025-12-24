using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Mee_Hotel.DAL
{
    class ThongKeDAL:DataProvider
    {
        private static ThongKeDAL instance;
        public new static ThongKeDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private ThongKeDAL() { }

        public (DataRow ThongTinChiTietPhong, DataRow ThongTinDatPhong, string Loi) ThongKeThongTinPhong()
        {

            try
            {
                DataSet ds = DataProvider.Instance.CallProcQuerySet("sp_ThongKeTinhTrangPhongHomNay");

                // ds có 3 bảng: 0=Thông tin, 1=Chi tiết, 2=Tổng tiền
                if (ds == null || ds.Tables.Count < 2)
                    return (null, null, "Không thấy dữ leieuj!");

                // Bảng 0: Thông tin phiếu + khách
                DataTable tbPhieu = ds.Tables[0];
                if (tbPhieu.Rows.Count == 0)
                    return (null, null, tbPhieu.Rows.Count > 0
                        ? tbPhieu.Rows[0]["ThongBao"].ToString()
                        : "Không tìm thấy phiếu!");
                // Bảng 1: Chi tiết loại phòng đặt
                DataTable tbChiTiet = ds.Tables[1];

                // Bảng 2: Tổng tiền

                return (tbPhieu.Rows[0], tbChiTiet.Rows[0], "OK");
            }
            catch (Exception ex)
            {
                return (null, null, "Lỗi CSDL: " + ex.Message);
            }
        }
        public DataTable ThongKeDoanhThu(DateTime ngayDen, DateTime ngayTra)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@TuNgay",ngayDen),
                new SqlParameter("@DenNgay", ngayTra),
             };
            DataTable dt = DataProvider.Instance.CallProcQuery("sp_ThongKeDoanhThu", pr);
            return dt;
        }
    }
}
