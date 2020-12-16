using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
    // lớp CategoryDA từ DataAccess
    public class CategoryBL
    {
        // đối tượng CategoryDA từ DataAcess
        CategoryDA categoryDA = new CategoryDA();

        //phương thức lấy hết dữ liệu
        public List<Category> GetAll()
        {
            return categoryDA.GetAll();
        }
        // Phương thức thêm dữ liệu
        public int Insert(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 0);
        }
        public int Update(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 1);
        }
        public int Delete(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 2);
        }
             
    }
}
