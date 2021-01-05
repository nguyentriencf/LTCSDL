using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onthicuoiki.DTO;
using Onthicuoiki.DAO;
using System.Data;

namespace Onthicuoiki.DAO
{
    public class TableDAO
    {
        private static readonly TableDAO instance;
       
        public static TableDAO Instance
        {
            get { if (instance == null) return new TableDAO(); return TableDAO.Instance; }
        }
        public List<TableDTO> LayDSBanAn()
        {
            List<TableDTO> ListTable = new List<TableDTO>();
            string query = "select * from [Table]";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                TableDTO tabledto = new TableDTO(row, table);
                ListTable.Add(tabledto);
            }
            return ListTable;
        }
        public bool InsertTable(string name_, int status_, int capacity_)
        {
       
             string query = "[dbo].[InsertTable] @name , @status , @capacity";
             bool result= DataProvider.Instance.ExcuteNonQuery(query,new object[]{name_, status_, capacity_});
             return result;
        }
        public bool UpdateTable(TableDTO tableDTO)
        {
            string query = "[dbo].[Table_Update] @id , @Name , @status , @Capacity";
            bool result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {tableDTO.iD_, tableDTO.name_, tableDTO.status_, tableDTO.capacity_});
            return result;
        }
        public bool DeleteTable(int ID)
        {
            TableDTO tableDTO = new TableDTO();
            tableDTO.iD_ = ID;
            string query = "[dbo].[Table_Delete] @id";
            bool result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {tableDTO.iD_} );
            return result;
        }
    }
}
