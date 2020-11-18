using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using baitapvidu.io;
namespace baitapvidu
{

    public partial class frmSinhVien : Form
    {
       
        public frmSinhVien()
        {
            InitializeComponent(); 
        }
        Quanly qlnv = new Quanly();

       
      


        private void btnthem_Click(object sender, EventArgs e)
        {
            
            if (qlnv.Insert(GetNhanVien()))
            {
                lvds.Items.Clear();

                LoadingListView();
                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Đã có mã số tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
        }
        public NhanVien GetNhanVien()
        {

            string gt = "Nam";
            if (rdnu.Checked)
                gt = "Nữ";

            NhanVien nv = new NhanVien(/*mkbmaso.Text, tbhoten.Text, dtkngaysinh.Value, cbphongban.Text, tbdiachi.Text, tbemail.Text, mkbdt.Text, gt, tbhinh.Text*/);
            nv.Manv = mkbmaso.Text;
            nv.Hoten = tbhoten.Text;
            nv.Ngaysinh = dtkngaysinh.Value;
            nv.Phongban = cbphongban.Text;
            nv.Diachi = tbdiachi.Text;
            nv.Email = tbemail.Text;
            nv.Sodt = mkbdt.Text;
            nv.Gioitinh = gt;
            tbhinh.Text = filemame;
            nv.Hinh = tbhinh.Text;
            return nv;
        }
        private void LoadingListView()
        {
            lvds.Items.Clear();
            foreach (KeyValuePair<string, NhanVien> items in qlnv.Qlnv)
            {
                ListViewItem lv = new ListViewItem(items.Value.Manv);
               // lv.Text = items.Value.Manv;
                lv.SubItems.Add(items.Value.Hoten);
                lv.SubItems.Add(items.Value.Ngaysinh.ToString());
                lv.SubItems.Add(items.Value.Gioitinh);
                lv.SubItems.Add(items.Value.Diachi);
                lv.SubItems.Add(items.Value.Email);
                lv.SubItems.Add(items.Value.Sodt);
                lv.SubItems.Add(items.Value.Phongban);
                lv.SubItems.Add(items.Value.Hinh);

                lvds.Items.Add(lv);
            }
        }
        string maso = null;
        private void lvds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioitinh;
            if (lvds.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvds.SelectedItems[0];
                maso = lv.SubItems[0].Text;
                mkbmaso.Text = maso;
                tbhoten.Text = lv.SubItems[1].Text;
                dtkngaysinh.Text = lv.SubItems[2].Text;
                gioitinh = lv.SubItems[3].Text;
                if (gioitinh == "Nam")
                    rdnam.Checked = true;
                else
                    rdnu.Checked = false;
                tbdiachi.Text = lv.SubItems[4].Text;
                tbemail.Text = lv.SubItems[5].Text;
                mkbdt.Text = lv.SubItems[6].Text;
                cbphongban.SelectedText = lv.SubItems[7].Text;
                tbhinh.Text = lv.SubItems[8].Text;
              
                if (tbhinh.Text=="")
                {
                    string imgdf = "default.png";
                    pbHinh.Image = Image.FromFile(@Application.StartupPath + "/Image/" + imgdf);
                }
                else
                    pbHinh.Image = Image.FromFile(@Application.StartupPath + "/Image/" + tbhinh.Text);


            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(lvds.SelectedItems.Count>0)
            {
                lvds.Items.Remove(lvds.SelectedItems[0]);
                qlnv.Qlnv.Remove(maso);
                MessageBox.Show("bạn đã xoá nhân viên");
                reset();
            }
            else
            {
                MessageBox.Show("chưa chon nhân viên");
            }
        }

        
        private void reset()
        {
            tbhoten.Text    = "";
            mkbmaso.Text    = "";
            tbdiachi.Text   = "";
            cbphongban.Text = "";
            tbhinh.Text     = "";
            rdnam.Checked   = true;
            mkbdt.Text      = "";
            tbemail.Text    = "";
            pbHinh.Image = null;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //if(lvds.SelectedItems.Count>0)
            //{

            //    ListViewItem lv = lvds.SelectedItems[0];               
            //    if (qlnv.Update(GetNhanVien()))
            //    {
            //        GetItem();
            //        MessageBox.Show("Sửa nhân viên thanh công","Thông báo");   
            //    }
            //    else
            //    {
            //        MessageBox.Show("chua chon hinh");
            //    }
            //}    
            qlnv.Qlnv.Remove(maso);
            LoadingListView();
        }

        string path;
        string filemame;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Title = "Open Dialog";        
            ofile.Filter = "file .jpg|*.jpg*|.png|*.png";
            if(ofile.ShowDialog() == DialogResult.OK)
            {
               
                path = ofile.FileName;
                filemame = Path.GetFileName(path);

                File.Copy(path,Path.Combine( Application.StartupPath+ "//Image//",filemame),true);

                pbHinh.Image = System.Drawing.Image.FromFile(Application.StartupPath + "//Image//" + filemame);
            }
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool kq = FileFactory.Savefile(qlnv.Qlnv, saveFileDialog1.FileName);
                if (kq)
                {
                    MessageBox.Show("Lưu thành công");
                }
            }

        }

        private void mnudoc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                qlnv.Qlnv= FileFactory.readfile(openFileDialog1.FileName);
                LoadingListView();
            }
        }
    }
}
