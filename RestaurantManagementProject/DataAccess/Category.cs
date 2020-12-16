using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class Category
    {
        // ID của bảng, tự tăng trong CSdl
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

    }
}
