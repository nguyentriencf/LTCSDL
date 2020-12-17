using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Lab07_Advanced_Command
{
    public class InitNameColumn
    {
        public static List<string> init(DataTable data)
        {
            List<string> Namecol = new List<string>();
            foreach (DataColumn column in data.Columns)
            {
                Namecol.Add(column.ColumnName.ToString());
            }
            return Namecol;
        }
    }
}
