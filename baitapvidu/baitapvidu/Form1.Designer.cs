namespace baitapvidu
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grTT = new System.Windows.Forms.GroupBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.mkbdt = new System.Windows.Forms.MaskedTextBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbhinh = new System.Windows.Forms.TextBox();
            this.cbphongban = new System.Windows.Forms.ComboBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.dtkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mkbmaso = new System.Windows.Forms.MaskedTextBox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.gbDSNV = new System.Windows.Forms.GroupBox();
            this.lvds = new System.Windows.Forms.ListView();
            this.cHma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHhoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHgioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHdiachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHhinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnmacdinh = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuluu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbDSNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grTT
            // 
            this.grTT.Controls.Add(this.btnbrowse);
            this.grTT.Controls.Add(this.tbemail);
            this.grTT.Controls.Add(this.mkbdt);
            this.grTT.Controls.Add(this.rdnu);
            this.grTT.Controls.Add(this.rdnam);
            this.grTT.Controls.Add(this.label9);
            this.grTT.Controls.Add(this.label8);
            this.grTT.Controls.Add(this.label7);
            this.grTT.Controls.Add(this.tbhinh);
            this.grTT.Controls.Add(this.cbphongban);
            this.grTT.Controls.Add(this.tbdiachi);
            this.grTT.Controls.Add(this.dtkngaysinh);
            this.grTT.Controls.Add(this.tbhoten);
            this.grTT.Controls.Add(this.label6);
            this.grTT.Controls.Add(this.label5);
            this.grTT.Controls.Add(this.label4);
            this.grTT.Controls.Add(this.label3);
            this.grTT.Controls.Add(this.label2);
            this.grTT.Controls.Add(this.label1);
            this.grTT.Controls.Add(this.mkbmaso);
            this.grTT.Controls.Add(this.pbHinh);
            this.grTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.grTT.Location = new System.Drawing.Point(0, 0);
            this.grTT.Name = "grTT";
            this.grTT.Size = new System.Drawing.Size(800, 191);
            this.grTT.TabIndex = 0;
            this.grTT.TabStop = false;
            this.grTT.Text = "thông tin";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(517, 156);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 20;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(558, 132);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(128, 20);
            this.tbemail.TabIndex = 19;
            // 
            // mkbdt
            // 
            this.mkbdt.Location = new System.Drawing.Point(569, 79);
            this.mkbdt.Mask = "(0633.) 000-0000";
            this.mkbdt.Name = "mkbdt";
            this.mkbdt.Size = new System.Drawing.Size(164, 20);
            this.mkbdt.TabIndex = 18;
            this.mkbdt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(694, 23);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 17;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Checked = true;
            this.rdnam.Location = new System.Drawing.Point(609, 23);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 16;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số ĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "MẪ NV";
            // 
            // tbhinh
            // 
            this.tbhinh.Location = new System.Drawing.Point(292, 159);
            this.tbhinh.Name = "tbhinh";
            this.tbhinh.ReadOnly = true;
            this.tbhinh.Size = new System.Drawing.Size(170, 20);
            this.tbhinh.TabIndex = 12;
            // 
            // cbphongban
            // 
            this.cbphongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbphongban.FormattingEnabled = true;
            this.cbphongban.Items.AddRange(new object[] {
            "Phòng 1",
            "Phòng 2",
            "Phòng 3"});
            this.cbphongban.Location = new System.Drawing.Point(292, 132);
            this.cbphongban.Name = "cbphongban";
            this.cbphongban.Size = new System.Drawing.Size(109, 21);
            this.cbphongban.TabIndex = 11;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(292, 102);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(170, 20);
            this.tbdiachi.TabIndex = 10;
            // 
            // dtkngaysinh
            // 
            this.dtkngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtkngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkngaysinh.Location = new System.Drawing.Point(293, 76);
            this.dtkngaysinh.Name = "dtkngaysinh";
            this.dtkngaysinh.Size = new System.Drawing.Size(109, 20);
            this.dtkngaysinh.TabIndex = 9;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(293, 50);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(262, 20);
            this.tbhoten.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MẪ NV";
            // 
            // mkbmaso
            // 
            this.mkbmaso.Location = new System.Drawing.Point(292, 22);
            this.mkbmaso.Mask = "NV.00000";
            this.mkbmaso.Name = "mkbmaso";
            this.mkbmaso.Size = new System.Drawing.Size(170, 20);
            this.mkbmaso.TabIndex = 1;
            this.mkbmaso.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbmaso.ValidatingType = typeof(int);
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(12, 19);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(121, 151);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // gbDSNV
            // 
            this.gbDSNV.Controls.Add(this.lvds);
            this.gbDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDSNV.Location = new System.Drawing.Point(0, 191);
            this.gbDSNV.Name = "gbDSNV";
            this.gbDSNV.Size = new System.Drawing.Size(800, 171);
            this.gbDSNV.TabIndex = 1;
            this.gbDSNV.TabStop = false;
            this.gbDSNV.Text = "Danh sách nhân viên";
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHma,
            this.cHhoten,
            this.cHngaysinh,
            this.cHgioitinh,
            this.cHdiachi,
            this.cHemail,
            this.cHsdt,
            this.cHphong,
            this.cHhinh});
            this.lvds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.HideSelection = false;
            this.lvds.Location = new System.Drawing.Point(3, 16);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(794, 152);
            this.lvds.TabIndex = 0;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.SelectedIndexChanged += new System.EventHandler(this.lvds_SelectedIndexChanged);
            // 
            // cHma
            // 
            this.cHma.Text = "Mã NV";
            this.cHma.Width = 58;
            // 
            // cHhoten
            // 
            this.cHhoten.Text = "Họ và Tên";
            this.cHhoten.Width = 139;
            // 
            // cHngaysinh
            // 
            this.cHngaysinh.Text = "Ngày Sinh";
            this.cHngaysinh.Width = 93;
            // 
            // cHgioitinh
            // 
            this.cHgioitinh.Text = "Giới tính";
            this.cHgioitinh.Width = 53;
            // 
            // cHdiachi
            // 
            this.cHdiachi.Text = "Địa chỉ";
            // 
            // cHemail
            // 
            this.cHemail.Text = "Email";
            // 
            // cHsdt
            // 
            this.cHsdt.Text = "Số ĐT";
            // 
            // cHphong
            // 
            this.cHphong.Text = "Phòng";
            this.cHphong.Width = 91;
            // 
            // cHhinh
            // 
            this.cHhinh.Text = "Hình";
            this.cHhinh.Width = 264;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnmacdinh);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 2;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(558, 41);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 37);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnmacdinh
            // 
            this.btnmacdinh.Location = new System.Drawing.Point(436, 41);
            this.btnmacdinh.Name = "btnmacdinh";
            this.btnmacdinh.Size = new System.Drawing.Size(88, 37);
            this.btnmacdinh.TabIndex = 10;
            this.btnmacdinh.Text = "Mặc định";
            this.btnmacdinh.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(189, 41);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 37);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(314, 41);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 37);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(75, 41);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 37);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudoc,
            this.mnuluu});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(35, 20);
            this.mnufile.Text = "file";
            // 
            // mnudoc
            // 
            this.mnudoc.Name = "mnudoc";
            this.mnudoc.Size = new System.Drawing.Size(180, 22);
            this.mnudoc.Text = "đọc file";
            this.mnudoc.Click += new System.EventHandler(this.mnudoc_Click);
            // 
            // mnuluu
            // 
            this.mnuluu.Name = "mnuluu";
            this.mnuluu.Size = new System.Drawing.Size(180, 22);
            this.mnuluu.Text = "lưu";
            this.mnuluu.Click += new System.EventHandler(this.mnuluu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDSNV);
            this.Controls.Add(this.grTT);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSinhVien";
            this.Text = "Form1";
            this.grTT.ResumeLayout(false);
            this.grTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbDSNV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTT;
        private System.Windows.Forms.GroupBox gbDSNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkbmaso;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.MaskedTextBox mkbdt;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbhinh;
        private System.Windows.Forms.ComboBox cbphongban;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.DateTimePicker dtkngaysinh;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.ColumnHeader cHma;
        private System.Windows.Forms.ColumnHeader cHhoten;
        private System.Windows.Forms.ColumnHeader cHngaysinh;
        private System.Windows.Forms.ColumnHeader cHgioitinh;
        private System.Windows.Forms.ColumnHeader cHdiachi;
        private System.Windows.Forms.ColumnHeader cHemail;
        private System.Windows.Forms.ColumnHeader cHsdt;
        private System.Windows.Forms.ColumnHeader cHphong;
        private System.Windows.Forms.ColumnHeader cHhinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnmacdinh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnudoc;
        private System.Windows.Forms.ToolStripMenuItem mnuluu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

