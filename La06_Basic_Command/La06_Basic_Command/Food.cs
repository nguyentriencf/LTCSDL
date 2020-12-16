using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace La06_Basic_Command
{
    public class Food
    {
        private int iD;
        private string name;
        private string unit;
        private int foodCategoryID;
        private int price;
        private string notes;
        List<string> listName = null;
        public Food(DataRow row, DataTable table)
        {
            listName = InitNameColumn.init(table);
            this.ID = int.Parse(row[listName[0]].ToString());
            this.Name = row[listName[1]].ToString();
            this.unit = row[listName[2]].ToString();
            this.FoodCategoryID = int.Parse(row[listName[3]].ToString());
            this.Price = int.Parse(row[listName[4]].ToString());
            this.Notes = row[listName[5]].ToString();
        }

        public Food(int iD, string name, string unit, int foodCategoryID, int price, string notes)
        {
            this.iD = iD;
            this.name = name;
            this.Unit = unit;
            this.foodCategoryID = foodCategoryID;
            this.price = price;
            this.notes = notes;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public int FoodCategoryID { get => foodCategoryID; set => foodCategoryID = value; }
        public int Price { get => price; set => price = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
