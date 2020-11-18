using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1812860_lab05_NguyenDinhPhatTrien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        QuanLySinhVien qlsv;
       private SinhVien GetSinhVien()
        {
            bool gt = true;
            SinhVien sv = new SinhVien();
            sv.MSSV = this.mtbMSSV.Text;
            sv.HoTenLot = this.tbTenLot.Text;
            sv.Ten = this.tbTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.SoCMND = this.mtbCMND.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.Lop = this.cbLop.Text;
            sv.SDT = this.mtbSDT.Text;
            sv.DiaChiLienLac = tbDiaChi.Text;
        
            for (int i = 0; i < clbDKMH.Items.Count; i++)
            {
                if (clbDKMH.GetItemChecked(i))
                {
                    sv.DangKyMH.Add(clbDKMH.Items[i].ToString());
                }
            }          
            return sv;
        }
        private SinhVien Getlistviewitem(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.SoCMND = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
            {
                sv.GioiTinh = true;
            }

            sv.Lop = lvitem.SubItems[6].Text;
            sv.SDT = lvitem.SubItems[7].Text;
            sv.DiaChiLienLac = lvitem.SubItems[8].Text;

            string[] mh = lvitem.SubItems[9].Text.Split(',');
            foreach (var item in mh)
            {
                sv.DangKyMH.Add(item);
            }

            return sv;
        }
        public void Thietlapsinhvien(SinhVien sv)
        {
            this.mtbMSSV.Text = sv.MSSV;
            this.tbTenLot.Text = sv.HoTenLot;
            this.tbTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.mtbCMND.Text = sv.SoCMND;

            if (sv.GioiTinh)
                this.rdNam.Checked = true;   
            else           
                this.rdNu.Checked = true;
            
            this.cbLop.Text = sv.Lop;
            this.mtbSDT.Text = sv.SDT;
            this.tbDiaChi.Text = sv.DiaChiLienLac;

            bool kt = false;
            for (int i = 0; i < clbDKMH.Items.Count; i++)
            {
                this.clbDKMH.SetItemChecked(i, kt);
                foreach (string item in sv.DangKyMH)
                {
                    if (item.CompareTo(this.clbDKMH.Items[i]) == 0)
                    {
                        kt = true;
                        this.clbDKMH.SetItemChecked(i, kt);
                    }
                    kt = false;
                }
            }
        }

        private void ThemSV(SinhVien sv)
        {
            
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.SoCMND);

            string gt = "Nam";
            if (sv.GioiTinh == false)
                gt = "Nữ";

            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChiLienLac);
            string dsmh = null;
            foreach (var mh in sv.DangKyMH)
            {
                dsmh += mh + ",";
            }
            lvitem.SubItems.Add(dsmh);
            this.lvSinhVien.Items.Add(lvitem);
        }

        public void Loadlistview()
        {
            this.lvSinhVien.Items.Clear();
            foreach  (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            
            qlsv.Doctufile();
            Loadlistview();
            List<string> lop ;
            lop = new List<string>();
            lop.Add("CTK41");
            lop.Add("CTK42");
            lop.Add("CTK43");
            lop.Add("CTK44");
            this.cbLop.DataSource = lop ;
   
        }

        private bool checkTT(SinhVien sv)
        {
            bool kt = true;
            if((sv.MSSV=="" && sv.MSSV.Length != 6)  || sv.HoTenLot =="" || sv.Ten =="" || sv.SoCMND=="" && sv.SoCMND.Length != 8|| sv.Lop=="" || sv.SDT=="" && sv.SDT.Length != 9 || sv.DiaChiLienLac=="" )
            {
                kt = false;       
            }
            return kt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV, SoSanhTheoMa);         
            if (kq != null)
            {
                MessageBox.Show("Đã tồn tại mã MSSV", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkTT(sv) == false)
                {
                    string tt = "Xin vui lòng kiểm tra lại thông tin để đủ điều kiện";
                    MessageBox.Show(tt, "Lỗi thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    qlsv.them(sv);
                    MessageBox.Show("Thêm sinh viên thành công", "Tông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    qlsv.Ghifile();
                    Loadlistview();
                }                
            }
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            SinhVien sv = GetSinhVien();      
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MSSV, SoSanhTheoMa);
            if (kqsua)
            {
                qlsv.Ghifile();
                this.Loadlistview();
            }    
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvSinhVien.SelectedItems.Count;
            if (count >0)
            {
                ListViewItem lvitem = lvSinhVien.SelectedItems[0];

                SinhVien sv = Getlistviewitem(lvitem);

                Thietlapsinhvien(sv);
            }           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ctmnuThemMH_Click(object sender, EventArgs e)
        {
            frmThemMH themMH = new frmThemMH();
            themMH.Show();
            
        }
    }
}
