using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_lab2
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        QuanLyGiaoVien listgv = new QuanLyGiaoVien();
            
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linkLbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.LBMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int i = this.LBMonHocDay.SelectedItems.Count - 1;
            //while (i > 0)
            //{
            //    this.lbDanhSachMH.Items.Add(LBMonHocDay.SelectedItems[i]);
            //    this.lbDanhSachMH.Items.Remove(LBMonHocDay.SelectedItems[i]);
            //    i--;
            //}
            for (int i = 0; i < LBMonHocDay.Items.Count; i++)
            {
                this.lbDanhSachMH.Items.Add(LBMonHocDay.SelectedItems[i]);
                this.LBMonHocDay.Items.Remove(LBMonHocDay.SelectedItems[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
           
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxSoDT.Text = "";
            this.rdNam.Checked = true;
            // Bỏ chọn trên 
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            //chuyển các môn học từ lbMonHocDay sang lbDanhMucMH
            foreach (object ob in this.LBMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
               
            }
            this.LBMonHocDay.Items.Clear();

           
        }

        private void linkLbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
           
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxSoDT.Text;
            // lấy thông tin ngoại ngữ
            string ngoaingu ="";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count -1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i]+ "; ";
            gv.NgoaiNgu = ngoaingu.Split(';');
            // lấy thông tin danh sách môn học
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in LBMonHocDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            return gv;
 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            GiaoVien item = new GiaoVien();
            item = GetGiaoVien();
            if (listgv.Themgv(item))
            {

                MessageBox.Show("Thêm thanh công", "Thông báo",MessageBoxButtons.OK );
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã số","Thông báo", MessageBoxButtons.OK);
            }
             
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTiemKiemGV frm = new frmTiemKiemGV(listgv);
            frm.Show();
        }
    }
}
