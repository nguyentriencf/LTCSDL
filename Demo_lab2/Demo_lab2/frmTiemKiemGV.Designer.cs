namespace Demo_lab2
{
    partial class frmTiemKiemGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdTMaSo = new System.Windows.Forms.RadioButton();
            this.rdTSoDT = new System.Windows.Forms.RadioButton();
            this.rdTHoTen = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.btnTiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiềm kiếm";
            // 
            // rdTMaSo
            // 
            this.rdTMaSo.AutoSize = true;
            this.rdTMaSo.Location = new System.Drawing.Point(61, 81);
            this.rdTMaSo.Name = "rdTMaSo";
            this.rdTMaSo.Size = new System.Drawing.Size(54, 17);
            this.rdTMaSo.TabIndex = 1;
            this.rdTMaSo.TabStop = true;
            this.rdTMaSo.Text = "Mã số";
            this.rdTMaSo.UseVisualStyleBackColor = true;
            // 
            // rdTSoDT
            // 
            this.rdTSoDT.AutoSize = true;
            this.rdTSoDT.Location = new System.Drawing.Point(311, 81);
            this.rdTSoDT.Name = "rdTSoDT";
            this.rdTSoDT.Size = new System.Drawing.Size(93, 17);
            this.rdTSoDT.TabIndex = 2;
            this.rdTSoDT.TabStop = true;
            this.rdTSoDT.Text = "Số Điên Thoại";
            this.rdTSoDT.UseVisualStyleBackColor = true;
            // 
            // rdTHoTen
            // 
            this.rdTHoTen.AutoSize = true;
            this.rdTHoTen.Location = new System.Drawing.Point(174, 81);
            this.rdTHoTen.Name = "rdTHoTen";
            this.rdTHoTen.Size = new System.Drawing.Size(61, 17);
            this.rdTHoTen.TabIndex = 3;
            this.rdTHoTen.TabStop = true;
            this.rdTHoTen.Text = "Họ Tên";
            this.rdTHoTen.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(120, 135);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(228, 20);
            this.txtNhap.TabIndex = 4;
            // 
            // lblChuyen
            // 
            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(47, 140);
            this.lblChuyen.Name = "lblChuyen";
            this.lblChuyen.Size = new System.Drawing.Size(56, 13);
            this.lblChuyen.TabIndex = 5;
            this.lblChuyen.Text = "Mã Sô GV";
            // 
            // btnTiem
            // 
            this.btnTiem.Location = new System.Drawing.Point(363, 135);
            this.btnTiem.Name = "btnTiem";
            this.btnTiem.Size = new System.Drawing.Size(75, 23);
            this.btnTiem.TabIndex = 6;
            this.btnTiem.Text = "Ok";
            this.btnTiem.UseVisualStyleBackColor = true;
            this.btnTiem.Click += new System.EventHandler(this.btnTiem_Click);
            // 
            // frmTiemKiemGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.btnTiem);
            this.Controls.Add(this.lblChuyen);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.rdTHoTen);
            this.Controls.Add(this.rdTSoDT);
            this.Controls.Add(this.rdTMaSo);
            this.Controls.Add(this.label1);
            this.Name = "frmTiemKiemGV";
            this.Text = "frmTiemKiemGV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTMaSo;
        private System.Windows.Forms.RadioButton rdTSoDT;
        private System.Windows.Forms.RadioButton rdTHoTen;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.Button btnTiem;
    }
}