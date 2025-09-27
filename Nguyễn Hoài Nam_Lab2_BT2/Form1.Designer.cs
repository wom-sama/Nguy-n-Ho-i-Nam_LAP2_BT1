namespace Nguyễn_Hoài_Nam_Lab2_BT2
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
            this.lblName = new System.Windows.Forms.Label();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grBGT = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.labMSSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.grBGT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(440, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(536, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Quản Lý Thông Tin Sinh Viên";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // dataStudent
            // 
            this.dataStudent.AllowUserToAddRows = false;
            this.dataStudent.AllowUserToDeleteRows = false;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.GT,
            this.DTB,
            this.CN});
            this.dataStudent.Location = new System.Drawing.Point(447, 101);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.ReadOnly = true;
            this.dataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudent.Size = new System.Drawing.Size(544, 267);
            this.dataStudent.TabIndex = 1;
            this.dataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellClick);
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbCN.Location = new System.Drawing.Point(139, 228);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(121, 21);
            this.cmbCN.TabIndex = 2;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(139, 54);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSSV.TabIndex = 3;
            this.txtMSSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Checked = true;
            this.radNu.Location = new System.Drawing.Point(6, 33);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grBGT
            // 
            this.grBGT.Controls.Add(this.radNam);
            this.grBGT.Controls.Add(this.radNu);
            this.grBGT.Location = new System.Drawing.Point(139, 102);
            this.grBGT.Name = "grBGT";
            this.grBGT.Size = new System.Drawing.Size(99, 59);
            this.grBGT.TabIndex = 5;
            this.grBGT.TabStop = false;
            this.grBGT.Enter += new System.EventHandler(this.grBGT_Enter);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(51, 33);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 5;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // labMSSV
            // 
            this.labMSSV.AutoSize = true;
            this.labMSSV.Location = new System.Drawing.Point(35, 54);
            this.labMSSV.Name = "labMSSV";
            this.labMSSV.Size = new System.Drawing.Size(70, 13);
            this.labMSSV.TabIndex = 6;
            this.labMSSV.Text = "Mã Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRS);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lblCN);
            this.groupBox1.Controls.Add(this.lblDTB);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblGT);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.grBGT);
            this.groupBox1.Controls.Add(this.labMSSV);
            this.groupBox1.Controls.Add(this.cmbCN);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 315);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(139, 183);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 20);
            this.txtDTB.TabIndex = 8;
            this.txtDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDTB_KeyPress);
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(35, 139);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(51, 13);
            this.lblGT.TabIndex = 9;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(35, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Họ Tên";
            this.lblHoTen.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(35, 183);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(31, 13);
            this.lblDTB.TabIndex = 11;
            this.lblDTB.Text = "Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nữ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tổng SV Nam";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(35, 228);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(78, 13);
            this.lblCN.TabIndex = 12;
            this.lblCN.Text = "Chuyên Ngành";
            this.lblCN.Click += new System.EventHandler(this.lblCN_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(89, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(43, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(216, 269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GT
            // 
            this.GT.HeaderText = "Giới Tính";
            this.GT.Name = "GT";
            this.GT.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "Điểm trung bình";
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            // 
            // CN
            // 
            this.CN.HeaderText = "Chuyên Nghành";
            this.CN.Name = "CN";
            this.CN.ReadOnly = true;
            // 
            // txtTongNu
            // 
            this.txtTongNu.Location = new System.Drawing.Point(915, 396);
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(100, 20);
            this.txtTongNu.TabIndex = 13;
            this.txtTongNu.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtTongNam
            // 
            this.txtTongNam.Location = new System.Drawing.Point(731, 396);
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.Size = new System.Drawing.Size(100, 20);
            this.txtTongNam.TabIndex = 14;
            this.txtTongNam.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "MSSV:2380601398\r\nHọ tên: Nguyễn Hoài Nam\r\nLớp 23DTHE1\r\n";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnRS
            // 
            this.btnRS.BackColor = System.Drawing.Color.IndianRed;
            this.btnRS.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRS.Location = new System.Drawing.Point(326, 269);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(53, 23);
            this.btnRS.TabIndex = 16;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = false;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.txtTongNu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.grBGT.ResumeLayout(false);
            this.grBGT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox grBGT;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label labMSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN;
        private System.Windows.Forms.TextBox txtTongNu;
        private System.Windows.Forms.TextBox txtTongNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnRS;
    }
}

