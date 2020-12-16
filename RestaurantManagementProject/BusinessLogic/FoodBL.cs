using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
  public  class FoodBL
    {
        // đôi tươngh Category từ DataAccess
        FoodDA foodDA = new FoodDA();
        // phương thức lấy hết dữ liệu
        public List<Food> GetAll()
        {
            return foodDA.GetAll();
        }
        public Food GetByID(int ID)
        {
            // lấy hết
            List<Food> list = GetAll();

            //dyệt để tìm kiếm
            foreach (var item in list)
            {
                if (item.ID == ID) // nếu gặp khoá chính
                    return item; // thì trả về kết quả
            }
            return null;
        }
        // phương thức tìm kiếm theo từ khoá
        public List<Food> Find(string key)
        {
            List<Food> list = GetAll();
            List<Food> result = new List<Food>();
            // duyệt theo danh sách
            foreach (var item in list)
            {
                // nếu từng trường hợp chứa khoá
                if (item.ID.ToString().Contains(key)
                    || item.Name.Contains(key)
                    || item.Unit.Contains(key)
                    || item.Price.ToString().Contains(key)
                    || item.Notes.Contains(key))
                    result.Add(item); // thì thêm vào danh sách kết quả         
            }
            return result;
        }

        //phương thức thêm dữ liệu
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }
        // phương thức Update
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }
        // phương thức xoá dữ liệu với ID cho trước
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }
    }
}
