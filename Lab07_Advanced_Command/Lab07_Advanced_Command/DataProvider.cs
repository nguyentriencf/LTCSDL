using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab07_Advanced_Command
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) return new DataProvider(); return DataProvider.instance; }
        }
        private DataProvider() { }
        private readonly string strCon = @"SERVER=DESKTOP-UPDAPIH\SQLEXPRESS01;Database = RestaurantManagement ; integrated security =true ";

        private void hasParameter(SqlCommand cmd, string query, object[] para=null)
        {
            int i = 0;
            foreach ( string parameter in query.Split(' ').ToArray().Where(p => p.Contains('@')))
            {
                cmd.Parameters.AddWithValue(parameter, para[i]);
                i++;
            }
        }
        public DataTable ExcuteDataReader(string query, object[] para = null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (para != null)
                    {
                        hasParameter(cmd, query, para);
                    
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
        private bool ExcuteNonQuery(string query, object[] para = null)
        {
            try
            {
                int kq = 0;
                using (SqlConnection sqlcon = new SqlConnection(strCon))
                {
                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    if (para != null)
                    {
                        hasParameter(cmd, query, para);
                    }
                    kq = cmd.ExecuteNonQuery();
                }
                return kq > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
