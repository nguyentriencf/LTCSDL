using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace Lab07_Advanced_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();

        }
        public void LoadCategory()
        {
            //string connection = "server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database= RestaurentManagement; Integrated Security = true";
            string connectString = "server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database=RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectString);

            SqlCommand sqlComman = sqlConnection.CreateCommand();
            sqlComman.CommandText = "select ID, Name from Category";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComman);
            DataTable data = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(data);
            sqlConnection.Close();
            sqlConnection.Dispose();

            cbbCategory.DataSource = data;

            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";        
        }
    }
}
