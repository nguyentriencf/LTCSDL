using Onthicuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onthicuoiki.DAO
{
   public class CurrentBillDAO
    {
        private static readonly CurrentBillDAO instance;
       

        public static CurrentBillDAO Instance
        {
            get { if (instance == null) return new CurrentBillDAO(); return CurrentBillDAO.instance; }
        }
        public List<CurrentBillDTO> GetCurrentBill(int tableID)
        {
            List<CurrentBillDTO> listCurrentBill = new List<CurrentBillDTO>();
            DataTable table=   DataProvider.Instance.ExcuteQuery("[dbo].[CurrentBill] @tableID", new object[] {tableID });
            foreach (DataRow row in table.Rows)
            {
                CurrentBillDTO currentBill = new CurrentBillDTO(row, table);
                listCurrentBill.Add(currentBill);
            }
            return listCurrentBill;
        }
    }
}
