using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Onthicuoiki.DAO
{
    public class DataProvider
    {
        private static readonly DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) return new DataProvider(); return DataProvider.Instance; }
        }
        private DataProvider() { }
        private string strCon = @"SERVER=DESKTOP-UPDAPIH\SQLEXPRESS01;Database = RestaurantManagement ; integrated security =true ";
        private void hasParameter(SqlCommand cmd , string query, object[] para = null)
        {
            int i = 0;
            foreach (string parameter in query.Split(' ').ToArray().Where(p => p.Contains('@')))
            {
                cmd.Parameters.AddWithValue(parameter,para[i]);
                i++;
            }
        }
        public DataTable ExcuteQuery(string query, object[] para =null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(query,conn);
                    if (para != null)
                    {
                        hasParameter(cmd, query,para);
                    }
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(data);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ExcuteNonQuery(string query, object[] para)
        {
            int kq = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    if (para != null)
                    {
                        hasParameter(sqlCommand, query, para);
                    }
                    kq = sqlCommand.ExecuteNonQuery();
                }
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public int ExcuteScalar(string query, object[] para)
        {
            try
            {
                int count = 0;
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {
                        hasParameter(cmd, query, para);
                    }
                    if (cmd.ExecuteScalar() == null)
                    {
                        count = 0;
                    }
                    else
                    {
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                return count;     
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
