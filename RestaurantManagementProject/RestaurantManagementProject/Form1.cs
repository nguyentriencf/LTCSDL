using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{
    public partial class Form1 : Form
    {
        List<Category> listCategory = new List<Category>();
        List<Food> listFood = new List<Food>();
        // Đối tượng Food đang chon hiện hành
        Food foodCurrent = new Food();
        public Form1()
        {
            InitializeComponent();
        }

        // phương thức thêm dư liệu cho bảng Food
        public int InsertFood()
        {
            //khai báo đối tượng từ tần DataAcess
            Food food = new Food();
            food.ID = 0;
            // kiểm tra nếu các ô khác rỗng 
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("chưa nhập thành công, vui lòng nhập lại");
            else
            {
                //nhận giá trị Name, Unit và Notes tù người dùng nhập vào
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;

                // giá trụ price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // cố gắng lấy giá trị
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                // giá trị FoodCategoryID được lấy từ combox
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // khai boá đối tượng FoodBL từ tầng business
                FoodBL foodBL = new FoodBL();
                //chèn dữ liệu vào bảng 
                return foodBL.Insert(food);

            }
            return -1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            // gán các ô bằng giá trị mặc định
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";
            // thiết lập index = 0 cho combox
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }
        private void LoadCategory()
        {
            //Gọi đối tượng CategoryBL từ tầng BusinessLogic
            CategoryBL categoryBL = new CategoryBL();
            // Lấy dữ liệu gán cho biến toàn cục listCategory
            listCategory = categoryBL.GetAll();
            // Chuyển vào Combobox với dữ liệu là ID, hiển thị là Name
            cbbCategory.DataSource = listCategory;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }
        public void LoadFoodDataToListView()
        {
            //Gọi đối tượng FoodBL từ tầng BusinessLogic
            FoodBL foodBL = new FoodBL();
            // Lấy dữ liệu
            listFood = foodBL.GetAll();
            int count = 1; // Biến số thứ tự
                           // Xoá dữ liệu trong ListView
            lvFood.Items.Clear();
            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var food in listFood)
            {
                // Số thứ tự
                ListViewItem item = lvFood.Items.Add(count.ToString());
                // Đưa dữ liệu Name, Unit, price vào cột tiếp theo
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                // Theo dữ liệu của bảng Category ID, lấy Name để hiển thị
                string foodName = listCategory
                .Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                // Đưa dữ liệu Notes vào cột cuối
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();

            LoadFoodDataToListView();
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvFood.Items.Count; i++)
            {
                if (lvFood.Items[i].Selected)
                {
                    // lấy các tham sô và gán dữ liệu vào ô
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    // Lấy index của Combobox theo FoodCategoryID
                    cbbCategory.SelectedIndex = listCategory
                    .FindIndex(x => x.ID == foodCurrent.FoodCategoryID);


                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn xoá hay không? Nếu đồng ý thì
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Khai báo đối tượng FoodBL từ BusinessLogic
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)// Nếu xoá thành công
                {
                    MessageBox.Show("Xoá thực phẩm thành công");
                    // Tải tữ liệu lên ListView
                    LoadFoodDataToListView();
                }
                else MessageBox.Show("Xoá không thành công");
            }
        }

        public int UpdateFood()
        {
            //Khai báo đối tượng Food và lấy đối tượng hiện hành
            Food food = foodCurrent;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                //Nhận giá trị Name, Unit, và Notes khi người dùng sửa
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                //Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // Chuyển giá trị từ kiểu văn bản qua kiểu int
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;
                // Giá trị FoodCategoryID được lấy từ ComboBox
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // Khao báo đối tượng FoodBL từ tầng Business
                FoodBL foodBL = new FoodBL();
                // Cập nhật dữ liệu trong bảng
                return foodBL.Update(food);
            }
            return -1;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            // Gọi phương thức cập nhật dữ liệu
            int result = UpdateFood();
            if (result > 0) // Nếu cập nhật thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Cập nhật dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadFoodDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Gọi phương thức thêm dữ liệu
            int result = InsertFood();
            if (result > 0) // Nếu thêm thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Thêm dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadFoodDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
    }
}
