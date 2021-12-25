
namespace QuanLiSinhVien_Project3
{
    partial class timLop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvData.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvData.Location = new System.Drawing.Point(0, 156);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1300, 700);
            this.dgvData.TabIndex = 22;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 81);
            this.panel1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(659, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "SV Không Có Lớp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(817, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xuất Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLiSinhVien_Project3.Properties.Resources.search_32px;
            this.button2.Location = new System.Drawing.Point(539, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 57);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lop
            // 
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.Location = new System.Drawing.Point(184, 30);
            this.lop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(336, 34);
            this.lop.TabIndex = 1;
            this.lop.TextChanged += new System.EventHandler(this.lop_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Lớp :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(1002, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 47);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1065, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "timLop";
            this.Text = "FrmDangKi";
            this.Load += new System.EventHandler(this.FrmDangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvData;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lop;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
    }
}