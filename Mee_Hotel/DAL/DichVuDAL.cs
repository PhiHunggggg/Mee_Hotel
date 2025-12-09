using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Mee_Hotel.DAL
{
    class DichVuDAL: DataProvider
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

        public DataTable getDanhSachDichVu(String tuKhoa, DateTime tuNgay, DateTime denNgay)
        {
            SqlParameter[] pr =
           {
                new SqlParameter("@TuKhoa", tuKhoa),
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay),


             };

            DataTable dt = DataProvider.Instance.CallProcQuery("getDanhSachDichVu", pr);

            if (dt.Rows.Count == 0)
                return null; 

            return dt;
        }
        public DataTable getChiTietDichVu()
        { 

            DataTable dt = DataProvider.Instance.CallProcQuery("getChiTietDichVu");

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}

