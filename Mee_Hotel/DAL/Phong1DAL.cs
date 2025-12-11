using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mee_Hotel.DAL
{
    class Phong1DAL : DataProvider
    {
        private static Phong1DAL instance;
        public new static Phong1DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Phong1DAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private Phong1DAL() { }

        public DataTable GetDanhSachPhong()
        {
            DataTable dt = DataProvider.Instance.CallProcQuery("GetDanhSachPhong");  // Giả định có stored proc GetDanhSachPhong trả về MaPhong, TenPhong, etc.

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
