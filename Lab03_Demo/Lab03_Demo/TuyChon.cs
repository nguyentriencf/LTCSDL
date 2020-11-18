using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Demo
{
    public partial class TuyChon : Form
    {
        //hàm khỏi tạo
        private QuanLySinhVien qlsv;
        public TuyChon(QuanLySinhVien qlsv)
        {
            InitializeComponent();
            this.qlsv = qlsv;
        }

        public static List<SinhVien> sv;


        public QuanLySinhVien Qlsv { get => qlsv; set => qlsv = value; }

        public delegate void LoadingDS(object sender, EventArgs arg);

        public event LoadingDS eventHandler;

        public class EventArgs
        {
            public List<SinhVien> dssv { get; set; }
            public EventArgs()
            {
               dssv =sv;   
            }      
        }
       
        public void Update()
        {
            EventArgs arg = new EventArgs();
            eventHandler.Invoke(this,arg );
        }

        private void TuyChon_Load(object sender, EventArgs e)
        {
             sv = new List<SinhVien>();    
        }

        private void btnSapsep_Click(object sender, System.EventArgs e)
        {
            sv = Qlsv.SapXepTheoMa();
            MessageBox.Show("success");
            Update();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            frmSinhVien frmsv = new frmSinhVien();

        }
    }
}
