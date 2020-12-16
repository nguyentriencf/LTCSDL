using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    // lớp quản lý Food:
    public class FoodDA
    {
        //phương thức lấy hết dữ liêuuj thủ tục Food_GetAll
        public List<Food> GetAll()
        {
            // khai báo đối tượng sqlconnection và mở kết nối
            // đối tượng sqlConnection truyền vào chuỗi kết nối trong app.config
            SqlConnection sqlconn = new SqlConnection(Ultilities.ConnectionString);
            sqlconn.Open();

            // khai báo đối tượng sqlcommangd có kiểu xử lý là storeProcedure
            SqlCommand command = sqlconn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_GetAll;

            // đọc dữ liệu, trả về danh sách các đối tượng food
            SqlDataReader reader = command.ExecuteReader();

            List<Food> list = new List<Food>();

            while (reader.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(reader["ID"]);
                food.Name = reader["Name"].ToString();
                food.Unit = reader["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]);
                food.Price = Convert.ToInt32(reader["Price"]);
                food.Notes = reader["Notes"].ToString();
                list.Add(food);
            }
            sqlconn.Close();
            return list;              
        }
        public int Insert_Update_Delete(Food food, int action)
        {
            //khai báo đối tươngh sqlconnection và mở kết nối
            // đối tượng sslconnection truyền vào chuỗi kết nối trong app.config
            SqlConnection sqlconn = new SqlConnection(Ultilities.ConnectionString);
            sqlconn.Open();
            // khai báo đối tượng sqlcommand có kiểu xử lý là storeprocedure
            SqlCommand command = sqlconn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_InsertUpdateDelete;

            // thêm các tham số cho thủ thục, các tham số này chinh là các tham số trong thủ tục
            // ID là tham số có giá trị lấy ra kho thẻm và truyền vào khi xoá, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = food.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            command.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = food.Unit;
            command.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;
            int result = command.ExecuteNonQuery();

            //thực thi lệnh
            if (result > 0) // nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;

        }
    }
}
