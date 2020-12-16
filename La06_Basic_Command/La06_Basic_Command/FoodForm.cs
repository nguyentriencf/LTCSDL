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
        List<Food> listFoodbyCateID = null;

        private void FoodForm_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadFood(int categoryID)
        {
            listFoodbyCateID = new List<Food>();   
          DataTable table =  DataProvider.Instance.ExcuteDataReader("select * from Food where FoodCategoryID = " + categoryID);
            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row, table);
                listFoodbyCateID.Add(food);
            }
            dgvFood.DataSource = listFoodbyCateID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
