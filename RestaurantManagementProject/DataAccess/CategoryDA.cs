using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    
   public class CategoryDA
    {
        // phương thức lấy dữ liệu thủ tục Food_GetAll
        public List<Category> GetAll()
        {
            // khai báo đối tượng sql và mở kết nối
            // đối tượng sql conection truyền vào chuỗi kết nối trong app.cònig
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            // khai báo 
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_GetAll;
            // đọc dữ liệu, trả về danh sách đối tượng Category
            SqlDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();
            while(reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }
            // đóng kết nối
            sqlConnection.Close();
            return list;
        }

        //  phương thức thêm xoá sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            // khai báo đối tượng sqlConnection và mở kết nối
            // đối tượng sqlConnection truyền vào chuỗi kết nối trong lơp app.config
            SqlConnection sqlconn = new SqlConnection(Ultilities.ConnectionString);
            sqlconn.Open();

            //khai báo đối tượng sqlCommand có kiểu xủ lý là StoreProcedure

            SqlCommand command = sqlconn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_InsertUpdateDelete;
            // thêm các tham số cho thủ thục; các tham số này chính là các tham số trong thủ tục
            // ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // vừa vào vừa ra
            command.Parameters.Add(IDPara).Value = category.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;

            command.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
