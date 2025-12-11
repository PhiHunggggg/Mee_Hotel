using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Mee_Hotel.DAL
{
    class SQL_Connection
    {
        #region Properties
        string StrCon = @"Data Source=MEICHAN;Initial Catalog=Quan_Ly_Khach_San;Integrated Security=True;TrustServerCertificate=True;";
        public SqlConnection conn;
        protected SqlCommand cmd = new SqlCommand();
        #endregion
        #region Connection
        public SQL_Connection()
        {
            try
            {
                conn = new SqlConnection(StrCon);
            }
            catch
            {
                MessageBox.Show("Mất kết nối đến cơ sở dữ liệu111!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

        }
        #endregion
        #region Open
        public void OpenConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mất kết nối đến cơ sở dữ liệu222!", "Thông báo", MessageBoxButtons.OKCancel);
                throw ex;
            }
        }
        #endregion
        #region CLose
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        #endregion
    }
}
