namespace Onthicuoiki
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListTable = new System.Windows.Forms.DataGridView();
            this.iD_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numricCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCurrentBill = new System.Windows.Forms.DataGridView();
            this.namecrr_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bàn ăn";
            // 
            // dgvListTable
            // 
            this.dgvListTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD_,
            this.name_,
            this.status_,
            this.capacity_});
            this.dgvListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListTable.GridColor = System.Drawing.Color.White;
            this.dgvListTable.Location = new System.Drawing.Point(3, 16);
            this.dgvListTable.Name = "dgvListTable";
            this.dgvListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTable.Size = new System.Drawing.Size(383, 431);
            this.dgvListTable.TabIndex = 0;
            this.dgvListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTable_CellClick);
            // 
            // iD_
            // 
            this.iD_.DataPropertyName = "iD_";
            this.iD_.HeaderText = "ID";
            this.iD_.Name = "iD_";
            // 
            // name_
            // 
            this.name_.DataPropertyName = "name_";
            this.name_.HeaderText = "Name";
            this.name_.Name = "name_";
            // 
            // status_
            // 
            this.status_.DataPropertyName = "status_";
            this.status_.HeaderText = "Status";
            this.status_.Name = "status_";
            // 
            // capacity_
            // 
            this.capacity_.DataPropertyName = "capacity_";
            this.capacity_.HeaderText = "Capacity";
            this.capacity_.Name = "capacity_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.numricCapacity);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(389, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bàn ăn";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(179, 167);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(298, 167);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 167);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numricCapacity
            // 
            this.numricCapacity.Location = new System.Drawing.Point(209, 125);
            this.numricCapacity.Name = "numricCapacity";
            this.numricCapacity.Size = new System.Drawing.Size(121, 20);
            this.numricCapacity.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "trống ",
            "có người"});
            this.cbStatus.Location = new System.Drawing.Point(209, 86);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(209, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgvCurrentBill
            // 
            this.dgvCurrentBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrentBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namecrr_,
            this.unit_,
            this.quantity_,
            this.price_,
            this.total_});
            this.dgvCurrentBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentBill.GridColor = System.Drawing.Color.White;
            this.dgvCurrentBill.Location = new System.Drawing.Point(389, 202);
            this.dgvCurrentBill.Name = "dgvCurrentBill";
            this.dgvCurrentBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentBill.Size = new System.Drawing.Size(411, 248);
            this.dgvCurrentBill.TabIndex = 2;
            // 
            // namecrr_
            // 
            this.namecrr_.DataPropertyName = "namecrr_";
            this.namecrr_.HeaderText = "Name";
            this.namecrr_.Name = "namecrr_";
            // 
            // unit_
            // 
            this.unit_.DataPropertyName = "unit_";
            this.unit_.HeaderText = "Unit";
            this.unit_.Name = "unit_";
            // 
            // quantity_
            // 
            this.quantity_.DataPropertyName = "quantity_";
            this.quantity_.HeaderText = "Quantity";
            this.quantity_.Name = "quantity_";
            // 
            // price_
            // 
            this.price_.DataPropertyName = "price_";
            this.price_.HeaderText = "Price";
            this.price_.Name = "price_";
            // 
            // total_
            // 
            this.total_.DataPropertyName = "total_";
            this.total_.HeaderText = "Tatol";
            this.total_.Name = "total_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCurrentBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListTable;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iD_;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity_;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numricCapacity;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dgvCurrentBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecrr_;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_;
    }
}

