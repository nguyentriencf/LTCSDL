namespace _1812860_lab05_NguyenDinhPhatTrien
{
    partial class frmThemMH
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
            this.tbThemMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbThemMH
            // 
            this.tbThemMH.Location = new System.Drawing.Point(145, 64);
            this.tbThemMH.Name = "tbThemMH";
            this.tbThemMH.Size = new System.Drawing.Size(138, 20);
            this.tbThemMH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập môn học;";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(301, 64);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(100, 23);
            this.btnThemMH.TabIndex = 3;
            this.btnThemMH.Text = "Ok";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // frmThemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 140);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThemMH);
            this.Name = "frmThemMH";
            this.Text = "Thêm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMH;
        public System.Windows.Forms.TextBox tbThemMH;
    }
}