using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace La06_Basic_Command
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadFood(int categoryID)
        {
            string con = "server = DESKTOP - UPDAPIH\\SQLEXPRESS01; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select Name From Category where ID = " + categoryID;

            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc loại: "+ catName;

            sqlCommand.CommandText = "select * from Food where FoodCategoryID = " + categoryID;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable data = new DataTable("Food");

            dataAdapter.Fill(data);

            dgvFood.DataSource = data;

            sqlCommand.Clone();
            sqlConnection.Dispose();
            dataAdapter.Dispose();
        }
    }
}
