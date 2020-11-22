using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // tao chuỗi kế nối tới cơ sỏ dữ liệu RetaurantManagement
            string connectionString = "server= DESKTOP-UPDAPIH\\SQLEXPRESS01; Database = RestaurantManagement; Integrated Security = true";

            // tạo dối tươngj kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // tạo dối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // thiết lập lệnh truy vẫn cho đối tượng command
            string query = "Select ID, Name, Type from Category";
            

            // mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // thực thi lệnh
            sqlCommand.CommandText = query;

            // gọi phương thức thực thi trả về nhiều đòng dữ liệu
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            // gọi hàm hiển thị dữ liệu lên màn hình
            DisplayCategory(sqlDataReader);
            sqlConnection.Close();
               
        }
       private void DisplayCategory(SqlDataReader reader)
        {
            // xoá tát cả dòng hiện tại
            lvCategory.Items.Clear();

            // đọc một dòng dữ liệu
            while (reader.Read())
            {
                // tạo dong mới trong listview
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());

                lvCategory.Items.Add(item);              
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // tạo chuỗi kết nối
            string connectionString = "Server = DESKTOP-UPDAPIH\\SQLEXPRESS01; Database = RestaurantManagement; Integrated Security = true";

            // tạo đói tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // tạo đối tượng thục thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // tạo đối tượng thực thi lệnh
            sqlCommand.CommandText = "insert into Category(Name, [Type])  " +
                "values(N'" + txtName.Text + "'," + txtType.Text + ")";


            // mở kết nối cơ sở dữ liệu 
            sqlConnection.Open();

            // thực thi lệnh bằng phương thức lệnh bằng phương thức exvuteNonQuery
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            // đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("nhóm món ăn thành công!");

                // tải lại dữ liệu
                btnLoad.PerformClick();

                // xoá các ô nhập
                txtName.Text = "";
                txtType.Text = "";

            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }

        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            // lấy ra dòng được hon
            ListViewItem item = lvCategory.SelectedItems[0];

            //hiên thị lên controls
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server = DESKTOP-UPDAPIH\\SQLEXPRESS01; database = RestaurantManagement ; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string loai;
            if (txtName.Text == "Thức uống")
                loai = "0";
            else
                loai = "1";
            sqlCommand.CommandText = "update Category set Name = N'" + txtName.Text+"'" +
                                                               " ,[Type] = " + loai +
                                                               " where ID = " + txtID.Text;

            // mở kết nối
            sqlConnection.Open();
            int numOfRowsEffect = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffect == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = loai;
                btnLoad.PerformClick();
                MessageBox.Show("Cập nhật thành công");

                txtName.Text = "";
                txtType.Text = "";

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server = DESKTOP-UPDAPIH\\SQLEXPRESS01; database = RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "delete from Category where ID = " + txtID.Text;

            sqlConnection.Open();
            int numOfRowsEffects =  sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffects == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);
                txtName.Text = "";
                txtType.Text = "";
                btnLoad.PerformClick();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thât bại");
            }    

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
            else
                MessageBox.Show("mời chọn sp để xoá");
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                frmFood frm = new frmFood();
                frm.Show(this);
                frm.LoadFood(Int32.Parse(txtID.Text));
            }
        }
    }
}
