using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace La06_Basic_Command
{
    public class InitNameColumn
    {
        public static List<string> init(DataTable data)
        {
            List<string> NameCol = new List<string>();

            foreach (DataColumn column in data.Columns)
            {
                NameCol.Add(column.ColumnName.ToString());
            }
            return NameCol;

        }
    }
}
