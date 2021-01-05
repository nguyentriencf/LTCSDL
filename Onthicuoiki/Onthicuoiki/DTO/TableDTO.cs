using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Onthicuoiki.DAO;

namespace Onthicuoiki.DTO
{
    public class TableDTO
    {
        public int iD_ { get; set; }
        public string name_ { get; set; }
        public int status_ { get; set; }
        public int capacity_ { get; set; }
        List<string> listName = null;
        public TableDTO()
        {

        }
        public TableDTO(DataRow row, DataTable table)
        {
            listName = Initcolumn.init(table);
            this.iD_ = int.Parse(row[listName[0]].ToString());
            this.name_ = row[listName[1]].ToString();
            this.status_ = int.Parse(row[listName[2]].ToString());
            this.capacity_ = int.Parse(row[listName[3]].ToString());
        }

        public TableDTO(int iD_, string name_, int status_, int capacity)
        {
            this.iD_ = iD_;
            this.name_ = name_;
            this.status_ = status_;
            this.capacity_ = capacity;
        }
    }
}
