﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace La06_Basic_Command
{
    public class DataProvider
    {

        private static readonly DataProvider instance;

        public static DataProvider Instance

        {
            get { if (instance == null) return new DataProvider(); return DataProvider.instance; }
        }

        private DataProvider()
        {

        }

        //   private readonly string strCon = @"SERVER=Rin;Database =HotelManagement;Integrated security =true";
        //private readonly string strCon = @"SERVER=DESKTOP-4ICDD5V\SQLEXPRESS;Database =HotelManagement;User Id=test;password=nguyenmautuan123";

        //  private readonly string strCon = @"SERVER=Rin;Database =HotelManagement;Integrated security =true";
        //   private readonly string strCon = @"SERVER=DESKTOP-4ICDD5V\SQLEXPRESS;Database =HotelManagement;User Id=test;password=nguyenmautuan123";


        //private readonly string strCon = @"SERVER=DESKTOP-VVRMOD7\HQHSQLSERVER;Database = HotelManagement ; integrated security =true ";
        private readonly string strCon = @"SERVER=DESKTOP-UPDAPIH\SQLEXPRESS01;Database = RestaurantManagement ; integrated security =true ";
        private void hasParameter(SqlCommand cmd, string query, object[] para = null)
        {
            int i = 0;
            foreach (string parameter in query.Split(' ').ToArray().Where(p => p.Contains('@')))
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
                using (SqlConnection conn = new SqlConnection(strCon))
                {

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {

                        {
                            hasParameter(cmd, query, para);
                        }

                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
                return data;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool ExcuteNonQuery(string query, object[] para = null)
        {
            try
            {
                int kq = 0;
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {
                        hasParameter(cmd, query, para);
                    }
                    kq = cmd.ExecuteNonQuery();

                }
                return kq > 0;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public int ExcuteScalar(string query, object[] para = null)
        {
            try
            {
                int count;
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

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

            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
