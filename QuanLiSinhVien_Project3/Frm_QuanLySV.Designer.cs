﻿
namespace QuanLiSinhVien_Project3
{
    partial class Frm_QuanLySV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.col_MaSV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_He = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.boxtim = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNganhhoc = new System.Windows.Forms.ComboBox();
            this.txtLop = new System.Windows.Forms.ComboBox();
            this.txtHedaotao = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 37);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1260, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(1260, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSV,
            this.col_TenSV,
            this.col_Ngaysinh,
            this.col_Gioitinh,
            this.col_Diachi,
            this.col_Dienthoai,
            this.col_Tennganh,
            this.col_Lop,
            this.col_He,
            this.col_Tinhtrang,
            this.col_Diem});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvData.Location = new System.Drawing.Point(0, 434);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1317, 377);
            this.dgvData.TabIndex = 4;
            this.dgvData.Click += new System.EventHandler(this.dgvData_Click);
            // 
            // col_MaSV
            // 
            this.col_MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaSV.DataPropertyName = "Id";
            this.col_MaSV.HeaderText = "MSV";
            this.col_MaSV.MinimumWidth = 6;
            this.col_MaSV.Name = "col_MaSV";
            this.col_MaSV.ReadOnly = true;
            this.col_MaSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_MaSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_TenSV
            // 
            this.col_TenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenSV.DataPropertyName = "Ten";
            this.col_TenSV.HeaderText = "Tên SV";
            this.col_TenSV.MinimumWidth = 6;
            this.col_TenSV.Name = "col_TenSV";
            this.col_TenSV.ReadOnly = true;
            // 
            // col_Ngaysinh
            // 
            this.col_Ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Ngaysinh.DataPropertyName = "Ngaysinh";
            this.col_Ngaysinh.HeaderText = "Ngày sinh";
            this.col_Ngaysinh.MinimumWidth = 6;
            this.col_Ngaysinh.Name = "col_Ngaysinh";
            this.col_Ngaysinh.ReadOnly = true;
            // 
            // col_Gioitinh
            // 
            this.col_Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Gioitinh.DataPropertyName = "Gioitinh";
            this.col_Gioitinh.HeaderText = "Giới tính";
            this.col_Gioitinh.MinimumWidth = 6;
            this.col_Gioitinh.Name = "col_Gioitinh";
            this.col_Gioitinh.ReadOnly = true;
            // 
            // col_Diachi
            // 
            this.col_Diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Diachi.DataPropertyName = "Diachi";
            this.col_Diachi.HeaderText = "Địa chỉ";
            this.col_Diachi.MinimumWidth = 6;
            this.col_Diachi.Name = "col_Diachi";
            this.col_Diachi.ReadOnly = true;
            // 
            // col_Dienthoai
            // 
            this.col_Dienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Dienthoai.DataPropertyName = "Sdt";
            this.col_Dienthoai.HeaderText = "Điện thoại";
            this.col_Dienthoai.MinimumWidth = 6;
            this.col_Dienthoai.Name = "col_Dienthoai";
            this.col_Dienthoai.ReadOnly = true;
            // 
            // col_Tennganh
            // 
            this.col_Tennganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Tennganh.DataPropertyName = "Nghanghoc";
            this.col_Tennganh.HeaderText = "Ngành học";
            this.col_Tennganh.MinimumWidth = 6;
            this.col_Tennganh.Name = "col_Tennganh";
            this.col_Tennganh.ReadOnly = true;
            // 
            // col_Lop
            // 
            this.col_Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Lop.DataPropertyName = "Lop";
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.MinimumWidth = 6;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.ReadOnly = true;
            // 
            // col_He
            // 
            this.col_He.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_He.DataPropertyName = "Hedaotao";
            this.col_He.HeaderText = "Hệ đào tạo";
            this.col_He.MinimumWidth = 6;
            this.col_He.Name = "col_He";
            this.col_He.ReadOnly = true;
            // 
            // col_Tinhtrang
            // 
            this.col_Tinhtrang.DataPropertyName = "Tinhtrang";
            this.col_Tinhtrang.HeaderText = "Tình trạng";
            this.col_Tinhtrang.MinimumWidth = 6;
            this.col_Tinhtrang.Name = "col_Tinhtrang";
            this.col_Tinhtrang.ReadOnly = true;
            this.col_Tinhtrang.Width = 125;
            // 
            // col_Diem
            // 
            this.col_Diem.DataPropertyName = "Diem";
            this.col_Diem.HeaderText = "Điểm";
            this.col_Diem.MinimumWidth = 6;
            this.col_Diem.Name = "col_Diem";
            this.col_Diem.ReadOnly = true;
            this.col_Diem.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.boxtim);
            this.panel2.Controls.Add(this.txtHedaotao);
            this.panel2.Controls.Add(this.txtLop);
            this.panel2.Controls.Add(this.txtNganhhoc);
            this.panel2.Controls.Add(this.txtGioiTinh);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDiem);
            this.panel2.Controls.Add(this.txtDienthoai);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txtNgaySinh);
            this.panel2.Controls.Add(this.txtMaSV);
            this.panel2.Controls.Add(this.txtTenSV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 397);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(599, 324);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(167, 36);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tìm Kiếm ID";
            // 
            // boxtim
            // 
            this.boxtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxtim.Location = new System.Drawing.Point(299, 324);
            this.boxtim.Margin = new System.Windows.Forms.Padding(4);
            this.boxtim.Name = "boxtim";
            this.boxtim.Size = new System.Drawing.Size(291, 34);
            this.boxtim.TabIndex = 6;
            this.boxtim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxtim_KeyPress);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(120, 205);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(291, 33);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(227)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QuanLiSinhVien_Project3.Properties.Resources.maintenance_32px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(1036, 103);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 48);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QuanLiSinhVien_Project3.Properties.Resources.remove_32px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(1036, 167);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 48);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(787, 263);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiSinhVien_Project3.Properties.Resources.add_32px;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(1037, 46);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 48);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nhập điểm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hệ đào tạo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngành học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SV";
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(579, 259);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(187, 34);
            this.txtDiem.TabIndex = 1;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienthoai.Location = new System.Drawing.Point(579, 43);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDienthoai.Multiline = true;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(291, 34);
            this.txtDienthoai.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(120, 259);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(291, 34);
            this.txtDiachi.TabIndex = 1;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(120, 150);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(291, 30);
            this.txtNgaySinh.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(120, 43);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(291, 34);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(120, 93);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSV.Multiline = true;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(291, 34);
            this.txtTenSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // txtNganhhoc
            // 
            this.txtNganhhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganhhoc.FormattingEnabled = true;
            this.txtNganhhoc.Items.AddRange(new object[] {
            "Du lịch và lữ hàng",
            "Quản trị kinh doanh",
            "Kế toán",
            "Kinh tế - Ngoại thương",
            "Ngôn ngữ Hàn Quốc",
            "Ngôn ngữ Anh",
            "Công nghệ thông tin",
            "Kỹ thuật Oto"});
            this.txtNganhhoc.Location = new System.Drawing.Point(579, 97);
            this.txtNganhhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNganhhoc.Name = "txtNganhhoc";
            this.txtNganhhoc.Size = new System.Drawing.Size(291, 33);
            this.txtNganhhoc.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.FormattingEnabled = true;
            this.txtLop.Items.AddRange(new object[] {
            "21CT111",
            "21CT112",
            "21CT113",
            "21CT114",
            "20CT111",
            "20CT112",
            "20CT113",
            "19CT111",
            "19CT112",
            "19CT113",
            "19CT114"});
            this.txtLop.Location = new System.Drawing.Point(579, 150);
            this.txtLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(291, 33);
            this.txtLop.TabIndex = 5;
            // 
            // txtHedaotao
            // 
            this.txtHedaotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHedaotao.FormattingEnabled = true;
            this.txtHedaotao.Items.AddRange(new object[] {
            "Cao Đẳng Thực Hàng",
            "Đại Học"});
            this.txtHedaotao.Location = new System.Drawing.Point(579, 205);
            this.txtHedaotao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHedaotao.Name = "txtHedaotao";
            this.txtHedaotao.Size = new System.Drawing.Size(291, 33);
            this.txtHedaotao.TabIndex = 5;
            // 
            // Frm_QuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_QuanLySV";
            this.Text = "Frm_QuanLySV";
            this.Load += new System.EventHandler(this.Frm_QuanLySV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox txtGioiTinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewButtonColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_He;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Diem;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxtim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox txtNganhhoc;
        private System.Windows.Forms.ComboBox txtLop;
        private System.Windows.Forms.ComboBox txtHedaotao;
    }
}