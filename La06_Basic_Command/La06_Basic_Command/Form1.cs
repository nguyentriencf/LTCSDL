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
        List<Category> listCategory = null;
        int[] arrIDU = new int[] { 0, 1, 2 };
        int IDCategory = 0;
        List<Food> listFood = null;
        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            listCategory = new List<Category>();
            DataTable table =  DataProvider.Instance.ExcuteDataReader("select * from Category");
            foreach (DataRow row in table.Rows)
            {
                Category category = new Category(row, table);
                listCategory.Add(category);
            }
            dgvCategory.DataSource = listCategory;
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var filter = from p in listCategory
                         where p.Name.CompareTo(txtName.Text)==0
                         select p;
            if (filter.Count()==0)
            {
                DataProvider.Instance.ExcuteNonQuery("[dbo].[Food_Insert] @Name , @Type", new object[] { txtName.Text, txtType.Text });
                btnLoad.PerformClick();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNonQuery("[dbo].[Category_InsertUpdateDelete] @ID , @Name , @Type , @Action", new object[] {txtID.Text, txtName.Text, txtType.Text, arrIDU[1]}); 
           // dgvCategory.Rows.Clear();
            btnLoad.PerformClick();
            MessageBox.Show("Update thành công");
            Resetform();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {     
            listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExcuteDataReader("select * from Food");
            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row, data);
                listFood.Add(food);
            }
            var filter = from f in listFood
                         where f.FoodCategoryID.CompareTo(txtID.Text) == 0
                         select f;
            if (filter.Count() ==0)
            {
                DataProvider.Instance.ExcuteNonQuery("[dbo].[Category_InsertUpdateDelete] @ID , @Name , @Type , @Action", new object[] { txtID.Text, txtName.Text, txtType.Text, arrIDU[2] });
                // dgvCategory.Rows.Clear();
                btnLoad.PerformClick();
                MessageBox.Show("xoá thành công");
            }
            else
            {
                MessageBox.Show("Đã tồn tại ID category trong csdl");
            }
            Resetform();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCategory[0, e.RowIndex].FormattedValue.ToString();
            txtName.Text = dgvCategory[1, e.RowIndex].FormattedValue.ToString();
            txtType.Text = dgvCategory[2, e.RowIndex].FormattedValue.ToString();
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
           
        }
        private void Resetform()
        {
            txtID.Text = "";
            txtType.Text = "";
            txtName.Text = "";
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void xemNhómMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.LoadFood(int.Parse(txtID.Text));
            foodForm.Show();
        }
    }
}
