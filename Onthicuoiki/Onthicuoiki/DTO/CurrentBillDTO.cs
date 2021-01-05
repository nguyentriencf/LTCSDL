using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onthicuoiki.DAO;
using System.Data;

namespace Onthicuoiki.DTO
{
   public class CurrentBillDTO
    {
        public string namecrr_ { get; set; }
        public string unit_ { get; set; }
        public int quantity_ { get; set; }
        public decimal price_ { get; set; }
        public decimal total_ { get; set; }
        List<string> listName;
        public CurrentBillDTO()
        {

        }
        public CurrentBillDTO(DataRow row, DataTable table)
        {
            listName = Initcolumn.init(table);
            this.namecrr_ = row[listName[0]].ToString();
            this.unit_ = row[listName[1]].ToString();
            this.quantity_ = int.Parse(row[listName[2]].ToString());
            this.price_ = decimal.Parse(row[listName[3]].ToString());
            this.total_ = decimal.Parse(row[listName[4]].ToString());
        }
        public CurrentBillDTO(string name_, string unit_, int quantity_, decimal price_, decimal total_)
        {
            this.namecrr_ = name_;
            this.unit_ = unit_;
            this.quantity_ = quantity_;
            this.price_ = price_;
            this.total_ = total_;
        }
    }

}
