﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Onthicuoiki.DAO
{
   public class Initcolumn
    {
        public static List<string> init(DataTable table)
        {
            List<string> listNameCol = new List<string>();
            foreach (DataColumn column in table.Columns)
            {
                listNameCol.Add(column.ColumnName.ToString());
            }
            return listNameCol;
        }
    }
}
