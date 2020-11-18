using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Standard
{
    public partial class Form1 : Form
    {
        private readonly StudentManager studentManager;
        private readonly List<string> dsMonHocDK;
        private readonly List<string> dsLop;
        public Form1()
        {
            InitializeComponent();
            //string txtFilePath = Utilitys.GetPathTo("DanhSachSV.txt");
            //string jsonFilePath = Utilitys.GetPathTo("DanhSachSV.json");

            studentManager = new StudentManager(new PlainTextDataSourcecs("DanhSachSV.txt"));
            dsLop = new List<string>
            {
                "CTK41",
                "CTK42",
                "CTK43",
                "CTK44",
            };
            dsMonHocDK = new List<string>()
            {
                "Mạng máy tính",
                "Hệ điều hành",
                "Lập trình CSDL",
                "Lập trình mạmg",
                "Đồ án cơ sở",
                "Phương pháp NCKH",
                "Lập trình trên thiết bị di động",
                "An toàn và bảo mật hệ thống"
            };
        }
        private Student GetSinhVien()
        {
            string mssv = mtbMSSV.Text;
            StringValidator.CheckRequire(mssv, "Mã sinh viên không hợp lệ");
            StringValidator.CheckLengthEqualTO(mssv, 7, "Mã sinh viên phải đủ 7 kí tự");
            string hoVaTenlot = tbHoTenLot.Text;
            StringValidator.CheckRequire(hoVaTenlot, "Họ và tên lót không hợp lệ");
            string ten = tbTen.Text;
            StringValidator.CheckRequire(ten, "Tên không hợp tệ");
            DateTime ngaysinh = dtpNgaySinh.Value;
            string lop = cbLop.Text;
            StringValidator.CheckRequire(lop, "Lớp không hợp lê");
            string cmnd = mtbCMND.Text;       
            StringValidator.CheckLengthEqualTO(cmnd, 9, "CMND phải đủ 9 kí tự");
            string sdt = mtbSDT.Text;
            StringValidator.CheckLengthEqualTO(sdt, 10, "Số điện thoại phải đủ 10 ký tự");
            string diachi = tbDiaChi.Text;
            StringValidator.CheckRequire(diachi, "Địa chỉ không hợp lệ");
            bool gt;
            gt= rdNam.Checked? true : false;

            List<string> DSMH = new List<string>();
            foreach (var item in clbMH.CheckedItems)
            {
                DSMH.Add(item as string);   
            }

            return new Student(mssv, hoVaTenlot, ten, ngaysinh, cmnd, gt, lop, sdt, diachi, DSMH);
        }

        public Student GetStudentFromLV(ListViewItem lvItem)
        {
            string mssv = lvItem.SubItems[0].Text;
            string hotenlot = lvItem.SubItems[1].Text;
            string ten = lvItem.SubItems[2].Text;
            DateTime ngsinh = DateTime.Parse(lvItem.SubItems[3].Text);
            string lop = lvItem.SubItems[4].Text;
            string cmnd = lvItem.SubItems[5].Text;
            string sdt = lvItem.SubItems[6].Text;
            string diachi = lvItem.SubItems[7].Text;
            bool gt = (lvItem.SubItems[8].Text == "Nam")? true : false;

            string[] stringComma = new string[] { ", " };
            string[] dsmh = lvItem.SubItems[9].Text.Split(stringComma, StringSplitOptions.None);
            List<string> monhoc = new List<string>(dsmh);
            return new Student(mssv, hotenlot, ten, ngsinh, cmnd, gt, lop, sdt, diachi, monhoc);
        }

        public void RenderStudent(Student student)
        {
            mtbMSSV.Text = student.MSSV;
            mtbMSSV.Enabled = false;

            tbHoTenLot.Text = student.HoVaTenLot;
            tbTen.Text = student.Ten;
            mtbCMND.Text = student.CMND;

            dtpNgaySinh.Value = student.NgaySinh;
            rdNam.Checked = false;
            rdNu.Checked = false;
            student.GioiTinh = true ? rdNam.Checked = true : rdNu.Checked = true;
            //if (student.GioiTinh == true)
            //    rdNam.Checked = true;           
            //else
            //    rdNu.Checked = true;
            

            cbLop.Text = student.Lop;
            mtbSDT.Text = student.SDT;
            tbDiaChi.Text = student.DiaChi;

            for (int i = 0; i < clbMH.Items.Count; i++)
            {
                clbMH.SetItemChecked(i, false);
            }
            foreach (var mh in student.DangKyMH)
            {
                for (int i = 0; i < clbMH.Items.Count; i++)
                {
                    if (clbMH.Items[i].ToString() == mh)                   
                        clbMH.SetItemChecked(i, true);                 
                }
            }
        }
        public void ClearForm()
        {
            mtbMSSV.Text = "";
            mtbMSSV.Enabled = true;

            tbHoTenLot.Text= "";
            tbTen.Text = "";

            dtpNgaySinh.Value = DateTime.Now;
            mtbCMND.Text = "";
            tbDiaChi.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            cbLop.Text = "";
            mtbSDT.Text = "";

            for (int i = 0; i < clbMH.Items.Count; i++)
                clbMH.SetItemChecked(i, false);
            
        }

        public ListViewItem createLVItem(Student student)
        {
            ListViewItem lvItem = new ListViewItem(student.MSSV);
            lvItem.SubItems.Add(student.HoVaTenLot);
            lvItem.SubItems.Add(student.Ten);
            lvItem.SubItems.Add(student.NgaySinh.ToShortDateString());
            lvItem.SubItems.Add(student.Lop);
            lvItem.SubItems.Add(student.CMND);
            lvItem.SubItems.Add(student.SDT);
            lvItem.SubItems.Add(student.DiaChi);
            string gt = student.GioiTinh == true ? "Nam" : "Nữ";
            lvItem.SubItems.Add(gt);
            lvItem.SubItems.Add(string.Join(" ,", student.DangKyMH));
            return lvItem;
        }
        public void RenderListView(List<Student> dsSinhVien)
        {
            lvSinhVien.Items.Clear();
            foreach (var student in dsSinhVien)
            {
                lvSinhVien.Items.Add(createLVItem(student));
            }
        }
        public void RenderDSMH(List<string> dsMH)
        {
            foreach (var mh in dsMH)
            {
                clbMH.Items.Add(mh, false);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RenderDSMH(dsMonHocDK);
            RenderListView(studentManager.GetALLStudents());
            foreach (var item in dsLop)
            {
                cbLop.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = GetSinhVien();
                studentManager.AddStudent(student);
                RenderListView(studentManager.GetALLStudents());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;
            Student student = GetStudentFromLV(lvSinhVien.SelectedItems[0]);
            RenderStudent(student);
        }

        private void ctmDelSV_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.CheckedIndices.Count==0)
            {
                MessageBox.Show("Vui lòng đánh dấu SV cần xoá");
                return;
            }
            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                Student student = GetStudentFromLV(item);
                studentManager.DelByID(student.MSSV);
            }
            ClearForm();
            RenderListView(studentManager.GetALLStudents());
        }

        private void mnuDelMH_Click(object sender, EventArgs e)
        {
            if (clbMH.Items.Count== 0)
            {
                MessageBox.Show("Không tồn tại môn học nào");
                return;
            }

            if (clbMH.CheckedItems.Count==0)
            {
                MessageBox.Show("Chưa chọn môn học để xoá");
                return;
            }

            foreach (var monhoc in clbMH.CheckedItems)
                dsMonHocDK.Remove(monhoc as string);

            clbMH.Items.Clear();
            foreach (var monhoc in dsMonHocDK)
                clbMH.Items.Add(monhoc, false);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = GetSinhVien();
                studentManager.UpdateByID(student.MSSV, student);
                RenderListView(studentManager.GetALLStudents());
                ClearForm();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void mnuInserMH_Click(object sender, EventArgs e)
        {
            var frmThemMH = new frmThemMH();
            var result = frmThemMH.ShowDialog();

            if (result == DialogResult.OK)
            {
                string tenMonHoc = frmThemMH.TenMonHoc;

                if (dsMonHocDK.Exists(mh => mh== tenMonHoc ))
                {
                    MessageBox.Show("Đã tồn tại môn học");
                    return;
                }

                dsMonHocDK.Add(tenMonHoc);
                clbMH.Items.Clear();
                foreach (var mhoc in dsMonHocDK)
                {
                    clbMH.Items.Add(mhoc, false);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
