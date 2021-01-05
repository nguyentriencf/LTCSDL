using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Onthicuoiki.DAO;
using Onthicuoiki.DTO;

namespace Onthicuoiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<TableDTO> listTableDTO = null;
        List<CurrentBillDTO> listCurrentBillDTO = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDSBan();   
        }

        public void loadDSBan()
        {
            listTableDTO = TableDAO.Instance.LayDSBanAn();
            dgvListTable.DataSource = listTableDTO;
        }
        private void dgvListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvListTable[0, e.RowIndex].FormattedValue.ToString();
            txtName.Text = dgvListTable[1, e.RowIndex].FormattedValue.ToString();
            int trangthai =int.Parse(dgvListTable[2, e.RowIndex].FormattedValue.ToString());
            if (trangthai == 0)
                cbStatus.Text = cbStatus.Items[0].ToString();
            else
                cbStatus.Text = cbStatus.Items[1].ToString();
            numricCapacity.Value = int.Parse(dgvListTable[3, e.RowIndex].FormattedValue.ToString());
            CurrrentBill(int.Parse(txtID.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int check=0;
            if (cbStatus.Text =="có người")
                check = 1;
            
            bool kq= TableDAO.Instance.InsertTable(txtName.Text, check, int.Parse(numricCapacity.Value.ToString()));
            if (kq)
            {
                MessageBox.Show("Thêm bàn thành công");
                loadDSBan();
            }                   
            else     
                MessageBox.Show("Thêm bàn thất bại");            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (cbStatus.Text != "trống")
                check = 1;
            TableDTO tableDTO = new TableDTO(int.Parse(txtID.Text), txtName.Text, check, int.Parse(numricCapacity.Value.ToString()));
            bool kq = TableDAO.Instance.UpdateTable(tableDTO);
            if (kq)
            {
                MessageBox.Show("Update bàn thành công");
                loadDSBan();
            }
            else
                MessageBox.Show("Update bàn thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = TableDAO.Instance.DeleteTable(int.Parse(txtID.Text));
            if (kq)
            {
                MessageBox.Show("Xoá bàn thành công");
                loadDSBan();
            }    
            else
                MessageBox.Show("Đã tồn tại bàn trong csdl");

        }
        public void CurrrentBill(int IdTable)
        {
             listCurrentBillDTO = CurrentBillDAO.Instance.GetCurrentBill(IdTable);
             dgvCurrentBill.DataSource = listCurrentBillDTO;       
        }
    }
}
