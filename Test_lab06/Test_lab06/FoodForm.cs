using System;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_lab06
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();

           
        }
        public void LoadFood(int categoryID)
        {
            // tạo chuỗi kết nối
            string connectionString = "server = DESKTOP-UPDAPIH\\SQLEXPRESS01; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select Name from Category where ID= " + categoryID;

            sqlConnection.Open();

            // thực thi câu lệnh trả về một ô dữ liệu
            string CatName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "danh sach nhóm món ăn: "+ CatName;

            sqlCommand.CommandText = "select * from Food where FoodCategoryID = " + categoryID;

          
            //tạo đối tương DataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            

            // tạo dataTable để chứa dưc liệu
            DataTable data = new DataTable("Food");
            sqlDataAdapter.Fill(data);

            // hiển thị dữ liệu lên màn hình
            dgvFood.DataSource = data;

            //dóng kết nối
            sqlConnection.Close();
            // giải phóng tài nguyên
            sqlConnection.Dispose();
            sqlDataAdapter.Dispose();
        }

        private void dgvFood_Click(object sender, EventArgs e)
        {
            //dgvFood.Rows[0].Selected = true;
            //DataGridViewRow row = new DataGridViewRow();
            //txtID.DataBindings.Add();
            
        }
    }
}
