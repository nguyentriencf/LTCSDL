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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectString = "server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database=RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select ID, Name, Type from Category";
            sqlCommand.CommandText = query;
            
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);

            sqlConnection.Close();
        }

        private void DisplayCategory( SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
                lvCategory.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string  con = "server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database=RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Insert into Category(Name,[Type])" + "values(N'" + txtName.Text + "'," + txtType.Text + ")";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            int sodonganhhuong = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (sodonganhhuong >0)
            {
                MessageBox.Show("thêm thành công");
                btnLoad.PerformClick();

                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("đã có lỗi xảy ra");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = this.lvCategory.SelectedItems[0];
            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0"? "Thức uống" : "Thức ăn";
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string con = "server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database=RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string type;
            if (txtType.Text == "Thức uống")
                type = "0";
            else
                type = "1";


            sqlCommand.CommandText = "update Category set Name= N'" + txtName.Text+ "', Type = " + type +
                                  " where ID =" + txtID.Text;
            sqlConnection.Open();

            int data = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            if (data == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;

                item.SubItems[2].Text = txtType.Text;              

                MessageBox.Show("cập nhật thành công");         
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string con ="server=DESKTOP-UPDAPIH\\SQLEXPRESS01; database=RestaurantManagement; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"DELETE FROM Category  where ID = { txtID.Text}"; 
            
            sqlConnection.Open();

            int data = sqlCommand.ExecuteNonQuery();

           
            if (data != 1)
            {

                MessageBox.Show("Đã có lỗi xảy ra");
                return;                
            }
            else
            {
                ListViewItem lvItem = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(lvItem);
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                MessageBox.Show("Xoá thành công");
                sqlConnection.Close();

            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnXoa.PerformClick();
            
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
