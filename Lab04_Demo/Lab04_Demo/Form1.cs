using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Demo
{
    public partial class frmPicture : Form
    {
     
        Point p = new Point();
        // Phương thưcs tạo lập frmPicture
        public frmPicture()
        {
            InitializeComponent();
        }
        // Phương thức tạo lập frmPicture có tham số
        public frmPicture(string name)
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
        }

        //Reload file cho hình
        private void reLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            string title = "";
            if (dlg==DialogResult.OK)
            {
                title = this.Text.Substring(0, this.Text.LastIndexOf('-')) + openFileDialog1.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openFileDialog1.FileName;
            }
        }

        // Phớng lớn hình
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        //Thu nhỏ hình
        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }

        // sự kiện scroll trên thanh Vscroll
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

        //sự kiện mở paint để chỉnh sửa hình
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", this.pbHinh.ImageLocation);
        }
    }
}
