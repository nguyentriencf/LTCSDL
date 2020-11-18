using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1812860_lab05_NguyenDinhPhatTrien
{
    public partial class frmThemMH : Form
    {
        public frmThemMH()
        {
            InitializeComponent();
            
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSV = new frmSinhVien();
            bool check = true;

            foreach (var item in frmSV.clbDKMH.Items)
            {
                if (this.tbThemMH.Text == item.ToString())
                {
                    check = false;
                    MessageBox.Show("trùng môn", "thông báo");

                }
                else
                {
                    if (check)
                    {                      
                            frmSV.clbDKMH.Items.Add(this.tbThemMH.Text);
                            MessageBox.Show("thêm môn học thành công", "thông báo");
                        break;
                        
                    }
                  
                }

            }



            //for (int i = 0; i <= frmSV.clbDKMH.Items.Count; i++)
            //{
            //    if (this.tbThemMH.Text != frmSV.clbDKMH.Items[i].ToString())
            //    {
            //        frmSV.clbDKMH.Items.Add(this.tbThemMH.Text);
            //        MessageBox.Show("Thêm môn học thành công", "thông báo");
            //        break;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đã có môn học tồn tại trong Danh sách", "Lỗi thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    }
            //}


        }
    }
}
