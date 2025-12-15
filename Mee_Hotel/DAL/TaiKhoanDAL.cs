using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mee_Hotel.Entity;
using System.Data.SqlClient;
using System.Data;
namespace Mee_Hotel.DAL
{
    class TaiKhoanDAL : DataProvider
    {
        private static TaiKhoanDAL instance;
        public new static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAL() { }

        public TaiKhoan Login(string user, string pass)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@Account", user),
                new SqlParameter("@Password",pass)
             };

            DataTable dt = DataProvider.Instance.CallProcQuery("sp_Login", pr);

            if (dt.Rows.Count == 0)
                return null; 

            DataRow row = dt.Rows[0];

            return new TaiKhoan
            {
                MaTaiKhoan = row["MaTaiKhoan"].ToString(),
                TenDangNhap = row["TenDangNhap"].ToString(),
                MatKhau = row["MatKhau"].ToString(),
                VaiTro = row["VaiTro"].ToString(),
                MaKH = row["MaKH"].ToString(),
                MaNV = row["MaNV"].ToString()
            };
        }
    }
}
