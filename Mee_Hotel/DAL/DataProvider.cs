using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Mee_Hotel.DAL
{
    class DataProvider : SQL_Connection
    {
        #region Properties
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        #endregion
        #region Constructor
        protected DataProvider() { }
        #endregion
        public DataTable CallProcQuery(string procName, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
        public object CallProcScalar(string procName, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    result = cmd.ExecuteScalar();
                }

                return result;
            }
            catch (Exception ex) { throw ex; }
            finally { CloseConnection(); }
        }

        public int CallProcNonQuery(string procName, SqlParameter[] parameters = null)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    affectedRows = cmd.ExecuteNonQuery();
                }
                return affectedRows;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                CloseConnection();
            }
        }
    }
}
