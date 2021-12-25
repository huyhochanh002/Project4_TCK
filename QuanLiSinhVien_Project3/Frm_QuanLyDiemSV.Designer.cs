
namespace QuanLiSinhVien_Project3
{
    partial class Frm_QuanLyDiemSV
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnex = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDTB = new System.Windows.Forms.Button();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.dataGridViewQLD = new System.Windows.Forms.DataGridView();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGANHHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(909, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý điểm Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnLammoi);
            this.panel2.Controls.Add(this.btnex);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnDTB);
            this.panel2.Controls.Add(this.txtDTB);
            this.panel2.Controls.Add(this.lblDiemTB);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1626, 252);
            this.panel2.TabIndex = 2;
            // 
            // btnex
            // 
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.Location = new System.Drawing.Point(596, 111);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(166, 43);
            this.btnex.TabIndex = 7;
            this.btnex.Text = "XuatExcel";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(171)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(227)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QuanLiSinhVien_Project3.Properties.Resources.maintenance_32px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(416, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 48);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QuanLiSinhVien_Project3.Properties.Resources.remove_32px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(267, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiSinhVien_Project3.Properties.Resources.add_32px;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(119, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 48);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Nhập";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnDTB
            // 
            this.btnDTB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDTB.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDTB.Location = new System.Drawing.Point(704, 31);
            this.btnDTB.Name = "btnDTB";
            this.btnDTB.Size = new System.Drawing.Size(280, 42);
            this.btnDTB.TabIndex = 2;
            this.btnDTB.Text = "Tính điểm Trung bình";
            this.btnDTB.UseVisualStyleBackColor = false;
            this.btnDTB.Click += new System.EventHandler(this.btnDTB_Click);
            // 
            // txtDTB
            // 
            this.txtDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTB.Location = new System.Drawing.Point(397, 42);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(250, 27);
            this.txtDTB.TabIndex = 1;
            this.txtDTB.TextChanged += new System.EventHandler(this.txtDTB_TextChanged);
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTB.Location = new System.Drawing.Point(103, 38);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(225, 29);
            this.lblDiemTB.TabIndex = 0;
            this.lblDiemTB.Text = "Trung bình các môn";
            // 
            // dataGridViewQLD
            // 
            this.dataGridViewQLD.AllowUserToAddRows = false;
            this.dataGridViewQLD.AllowUserToDeleteRows = false;
            this.dataGridViewQLD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewQLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.coldiachi,
            this.coldiem,
            this.colTEN,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colDT,
            this.colNGANHHOC,
            this.colLOP,
            this.colHDT,
            this.colTT});
            this.dataGridViewQLD.Location = new System.Drawing.Point(0, 299);
            this.dataGridViewQLD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewQLD.Name = "dataGridViewQLD";
            this.dataGridViewQLD.ReadOnly = true;
            this.dataGridViewQLD.RowHeadersWidth = 51;
            this.dataGridViewQLD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQLD.Size = new System.Drawing.Size(1490, 438);
            this.dataGridViewQLD.TabIndex = 3;
            // 
            // btnLammoi
            // 
            this.btnLammoi.AllowDrop = true;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(931, 111);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(166, 43);
            this.btnLammoi.TabIndex = 8;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "Diachi";
            this.coldiachi.HeaderText = "Địa Chỉ";
            this.coldiachi.MinimumWidth = 6;
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // coldiem
            // 
            this.coldiem.DataPropertyName = "Diem";
            this.coldiem.HeaderText = "Điểm";
            this.coldiem.MinimumWidth = 6;
            this.coldiem.Name = "coldiem";
            this.coldiem.ReadOnly = true;
            // 
            // colTEN
            // 
            this.colTEN.DataPropertyName = "Ten";
            this.colTEN.HeaderText = "TÊN";
            this.colTEN.MinimumWidth = 6;
            this.colTEN.Name = "colTEN";
            this.colTEN.ReadOnly = true;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.DataPropertyName = "Ngaysinh";
            this.colNGAYSINH.HeaderText = "NGÀY SINH";
            this.colNGAYSINH.MinimumWidth = 6;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.ReadOnly = true;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.DataPropertyName = "Gioitinh";
            this.colGIOITINH.HeaderText = "GIỚI TÍNH";
            this.colGIOITINH.MinimumWidth = 6;
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.ReadOnly = true;
            // 
            // colDT
            // 
            this.colDT.DataPropertyName = "Sdt";
            this.colDT.HeaderText = "ĐIỆN THOẠI";
            this.colDT.MinimumWidth = 6;
            this.colDT.Name = "colDT";
            this.colDT.ReadOnly = true;
            // 
            // colNGANHHOC
            // 
            this.colNGANHHOC.DataPropertyName = "Nghanghoc";
            this.colNGANHHOC.HeaderText = "NGHÀNG HỌC";
            this.colNGANHHOC.MinimumWidth = 6;
            this.colNGANHHOC.Name = "colNGANHHOC";
            this.colNGANHHOC.ReadOnly = true;
            // 
            // colLOP
            // 
            this.colLOP.DataPropertyName = "Lop";
            this.colLOP.HeaderText = "LỚP";
            this.colLOP.MinimumWidth = 6;
            this.colLOP.Name = "colLOP";
            this.colLOP.ReadOnly = true;
            // 
            // colHDT
            // 
            this.colHDT.DataPropertyName = "Hedaotao";
            this.colHDT.HeaderText = "HỆ ĐÀO TẠO";
            this.colHDT.MinimumWidth = 6;
            this.colHDT.Name = "colHDT";
            this.colHDT.ReadOnly = true;
            // 
            // colTT
            // 
            this.colTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTT.DataPropertyName = "Tinhtrang";
            this.colTT.HeaderText = "TÌNH TRẠNG";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            // 
            // Frm_QuanLyDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 734);
            this.Controls.Add(this.dataGridViewQLD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyDiemSV";
            this.Text = "Frm_QuanLyDiemSV";
            this.Load += new System.EventHandler(this.Frm_QuanLyDiemSV_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDTB;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.DataGridView dataGridViewQLD;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGANHHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
    }
}