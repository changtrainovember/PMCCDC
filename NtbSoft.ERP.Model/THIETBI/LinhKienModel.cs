using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtbSoft.ERP.Model.THIETBI
{
    public class LinhKienModel
    {
        public DataTable GetDSLinhKien()
        {
            SqlConnection conn = null;
            try
            {
                conn = NtbSoft.ERP.Libs.SqlHelper.GetConnection();
                SqlCommand cmd = new SqlCommand("sp_LinhKien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Get");
                cmd.Parameters.AddWithValue("@Parameter", "");
                using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable();
                    adt.Fill(ds);
                    return ds;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { if (conn != null) { conn.Close(); conn.Dispose(); } }

        }

        public string PostLinhKien(string action, DataTable tblLinhKien)
        {
            SqlConnection conn = null;
            try
            {
                conn = NtbSoft.ERP.Libs.SqlHelper.GetConnection();
                SqlCommand cmd = new SqlCommand("sp_LinhKien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue("@Parameter", "");
                cmd.Parameters.AddWithValue("@TypeTableLinhKien", tblLinhKien);
                cmd.ExecuteNonQuery();
                return "True";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally { if (conn != null) { conn.Close(); conn.Dispose(); } }
        }

        public string DeleteLinhKien(int ID)
        {
            SqlConnection conn = null;
            try
            {
                conn = NtbSoft.ERP.Libs.SqlHelper.GetConnection();
                SqlCommand cmd = new SqlCommand("sp_LinhKien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Delete");
                cmd.Parameters.AddWithValue("@Parameter", ID.ToString());
                cmd.ExecuteNonQuery();
                return "True";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally { if (conn != null) { conn.Close(); conn.Dispose(); } }
        }
    }
}
