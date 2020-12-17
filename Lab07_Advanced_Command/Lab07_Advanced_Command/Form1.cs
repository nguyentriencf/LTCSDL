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
            cbbCategory.DataSource = DataProvider.Instance.ExcuteDataReader("select * from Category");
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
           
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idCategory = int.Parse(cbbCategory.GetItemText(this.cbbCategory.SelectedItem));
            dgvFoodList.DataSource = DataProvider.Instance.ExcuteDataReader("select * from Food where FoodCategoryID =" + idCategory);

            lblQuantity.Text = dgvFoodList.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }
    }
}
