using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1812866
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            string[] arrPhong = { "Phong A", "Phong B", "Phong C" };

            cbPhongBan.DataSource = arrPhong;
     
        }

        quanLyNhanVien qlnv = new quanLyNhanVien();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nu";
            
            nhanVien nv = new nhanVien(mtbManv.Text, tbName.Text, gioitinh, tbDiachi.Text, mtbSDT.Text, dtpNgaySinh.Text, cbPhongBan.Text,tbHinh.Text ,tbEmail.Text);

            if (qlnv.themNhanvien(nv))
            {
                loadingListView();
             

                MessageBox.Show("Success!");
            }
            else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
        }
        private void loadingListView()
        {
            lvDSNV.Items.Clear();
            foreach (KeyValuePair<string, nhanVien> nv in qlnv.Listnv)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = nv.Value.MaNV;
                lv.SubItems.Add(nv.Value.TenNV);
                lv.SubItems.Add(nv.Value.Ngaysinh);
                lv.SubItems.Add(nv.Value.Gioitinh);
                lv.SubItems.Add(nv.Value.Diachi);
                lv.SubItems.Add(nv.Value.Email);

                lv.SubItems.Add(nv.Value.Sdt);
                lv.SubItems.Add(nv.Value.Phong);
                lv.SubItems.Add(nv.Value.Hinh);
                lvDSNV.Items.Add(lv);
            }
        }
        string maso =null;
       
        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioitinh;
            if(lvDSNV.SelectedItems.Count >0)
            {
                
                ListViewItem items = lvDSNV.SelectedItems[0];
                 maso = items.SubItems[0].Text;
                mtbManv.Text = maso;
                tbName.Text = items.SubItems[1].Text;
                dtpNgaySinh.Text = items.SubItems[2].Text;
               gioitinh = items.SubItems[3].Text;
                if (gioitinh == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                    
                tbDiachi.Text = items.SubItems[4].Text;
                tbEmail.Text = items.SubItems[5].Text;
                mtbSDT.Text = items.SubItems[6].Text;
                cbPhongBan.SelectedItem = items.SubItems[7].Text;


            }
        }
        private void reset()
        {
            tbDiachi.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            rdNam.Checked = true;
            mtbManv.Text = "";
            mtbSDT.Text = "";
            
                
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maso != null)
            {
                qlnv.Listnv.Remove(maso);
                loadingListView();
                MessageBox.Show("Delete success");
                reset();
                maso = null;
            }
            else
                MessageBox.Show("Ban chua chon ma so");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nu";
            if(qlnv.updateNV(mtbManv.Text, tbName.Text, tbDiachi.Text, tbEmail.Text, gioitinh, mtbSDT.Text, cbPhongBan.Text, dtpNgaySinh.Text))
            {
                MessageBox.Show("Update Success");
                loadingListView();
            }else
                MessageBox.Show("Update Fail!");
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
