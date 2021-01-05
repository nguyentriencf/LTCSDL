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
        List<Category> listCategory = null;
        int foodId;
        string namefood = null;
        string unit;
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
            //listCategory = DataProvider.Instance.ExcuteDataReader("select * from Category");
            cbbCategory.DataSource = DataProvider.Instance.ExcuteDataReader("select * from Category");
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
          
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbCategory.SelectedValue.ToString());
            int idCategory;  //int.Parse(cbbCategory.GetItemText(this.cbbCategory.SelectedItem));
            //MessageBox.Show(idCategory.ToString());
            if (cbbCategory.SelectedIndex == -1) return;
            if(cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                idCategory = int.Parse(rowView["ID"].ToString());
            }
            else
            {
                idCategory = int.Parse(cbbCategory.SelectedValue.ToString());
            }
            dgvFoodList.DataSource = DataProvider.Instance.ExcuteDataReader("select * from Food where FoodCategoryID =" +  idCategory);


            string quantity = (dgvFoodList.Rows.Count - 1).ToString();
            lblQuantity.Text = quantity;
            lblCatName.Text = cbbCategory.Text;
        }

        private void dgvFoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = int.Parse(dgvFoodList[0, e.RowIndex].FormattedValue.ToString());
            namefood = dgvFoodList[1, e.RowIndex].FormattedValue.ToString();
            unit = dgvFoodList[2, e.RowIndex].FormattedValue.ToString();
            
        }
        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            var result = DataProvider.Instance.ExcuteScalar("select SUM(Quantity) from BillDetails where FoodID = " + foodId);
            if (dgvFoodList.SelectedRows.Count > 0 )
            {
                MessageBox.Show("Tổng số món ăn " + namefood + " đã bán là: " + result + " " + unit);
            }
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {

        }
    }
}
