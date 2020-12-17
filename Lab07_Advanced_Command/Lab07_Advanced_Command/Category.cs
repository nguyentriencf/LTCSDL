using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab07_Advanced_Command
{
    public class Category
    {
        private int iD;
        private string name;
        private int type;
        List<string> listName = null;
        public Category() { }
        public Category(DataRow row, DataTable table)
        {
            listName = InitNameColumn.init(table);
            this.ID = int.Parse(row[listName[0]].ToString());
            this.Name = row[listName[1]].ToString();
            this.type = int.Parse(row[listName[2]].ToString());
        }

        public Category(int iD, string name, int type)
        {
            this.ID = iD;
            this.Name = name;
            this.Type = type;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
    }
}
