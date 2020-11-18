using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_lab2
{
    public partial class frmTiemKiemGV : Form
    {
        public frmTiemKiemGV(QuanLyGiaoVien listgv)
        {
            this.qlgv = listgv;
            InitializeComponent();
        }
        public QuanLyGiaoVien qlgv { get; set; }
        private void btnTiem_Click(object sender, EventArgs e)
        { 
            if(rdTMaSo.Checked)
            {
                frmTBGiaoVien frm = new frmTBGiaoVien();
                GiaoVien gv = new GiaoVien();
                string s ;
               
                gv=   qlgv.TimMaso(txtNhap.Text);
                s= gv.ToString();
                frm.Text = "Thông tin giáo viên vừa nhập là";
                frm.SetText(s);
                frm.ShowDialog();



            }    
        }
    }
}
