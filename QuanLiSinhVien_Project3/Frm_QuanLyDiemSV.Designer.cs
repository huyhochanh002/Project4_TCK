
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
            this.dataGridViewQLD = new System.Windows.Forms.DataGridView();
            this.col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col__MonA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MonB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MonC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDTB = new System.Windows.Forms.Button();
            this.txtDiemC = new System.Windows.Forms.TextBox();
            this.lblDiemmonC = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtDiemB = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblDiemmonB = new System.Windows.Forms.Label();
            this.txtTSV = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtDiemA = new System.Windows.Forms.TextBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblTenSv = new System.Windows.Forms.Label();
            this.lblDiemmonA = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.lblMSV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLD)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 40);
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
            this.button1.Size = new System.Drawing.Size(51, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewQLD
            // 
            this.dataGridViewQLD.AllowUserToAddRows = false;
            this.dataGridViewQLD.AllowUserToDeleteRows = false;
            this.dataGridViewQLD.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewQLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSV,
            this.col_TenSV,
            this.col_Lop,
            this.col__MonA,
            this.col_MonB,
            this.col_MonC,
            this.col_TongDiem,
            this.col_Xeploai});
            this.dataGridViewQLD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewQLD.Location = new System.Drawing.Point(0, 319);
            this.dataGridViewQLD.Name = "dataGridViewQLD";
            this.dataGridViewQLD.ReadOnly = true;
            this.dataGridViewQLD.RowHeadersVisible = false;
            this.dataGridViewQLD.RowHeadersWidth = 51;
            this.dataGridViewQLD.RowTemplate.Height = 24;
            this.dataGridViewQLD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQLD.Size = new System.Drawing.Size(927, 415);
            this.dataGridViewQLD.TabIndex = 1;
            this.dataGridViewQLD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLD_CellClick);
            // 
            // col_MaSV
            // 
            this.col_MaSV.HeaderText = "MSV";
            this.col_MaSV.MinimumWidth = 6;
            this.col_MaSV.Name = "col_MaSV";
            this.col_MaSV.ReadOnly = true;
            this.col_MaSV.Width = 75;
            // 
            // col_TenSV
            // 
            this.col_TenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenSV.HeaderText = "Tên SV";
            this.col_TenSV.MinimumWidth = 6;
            this.col_TenSV.Name = "col_TenSV";
            this.col_TenSV.ReadOnly = true;
            // 
            // col_Lop
            // 
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.MinimumWidth = 6;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.ReadOnly = true;
            this.col_Lop.Width = 75;
            // 
            // col__MonA
            // 
            this.col__MonA.HeaderText = "Điểm môn A";
            this.col__MonA.MinimumWidth = 6;
            this.col__MonA.Name = "col__MonA";
            this.col__MonA.ReadOnly = true;
            this.col__MonA.Width = 99;
            // 
            // col_MonB
            // 
            this.col_MonB.HeaderText = "Điểm môn B";
            this.col_MonB.MinimumWidth = 6;
            this.col_MonB.Name = "col_MonB";
            this.col_MonB.ReadOnly = true;
            this.col_MonB.Width = 99;
            // 
            // col_MonC
            // 
            this.col_MonC.HeaderText = "Điểm môn C";
            this.col_MonC.MinimumWidth = 6;
            this.col_MonC.Name = "col_MonC";
            this.col_MonC.ReadOnly = true;
            this.col_MonC.Width = 99;
            // 
            // col_TongDiem
            // 
            this.col_TongDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TongDiem.HeaderText = "Trung bình các môn";
            this.col_TongDiem.MinimumWidth = 6;
            this.col_TongDiem.Name = "col_TongDiem";
            this.col_TongDiem.ReadOnly = true;
            // 
            // col_Xeploai
            // 
            this.col_Xeploai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Xeploai.HeaderText = "Xếp loại";
            this.col_Xeploai.MinimumWidth = 6;
            this.col_Xeploai.Name = "col_Xeploai";
            this.col_Xeploai.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnDTB);
            this.panel2.Controls.Add(this.txtDiemC);
            this.panel2.Controls.Add(this.lblDiemmonC);
            this.panel2.Controls.Add(this.txtLop);
            this.panel2.Controls.Add(this.txtDiemB);
            this.panel2.Controls.Add(this.lblLop);
            this.panel2.Controls.Add(this.lblDiemmonB);
            this.panel2.Controls.Add(this.txtTSV);
            this.panel2.Controls.Add(this.txtDTB);
            this.panel2.Controls.Add(this.txtDiemA);
            this.panel2.Controls.Add(this.lblDiemTB);
            this.panel2.Controls.Add(this.lblTenSv);
            this.panel2.Controls.Add(this.lblDiemmonA);
            this.panel2.Controls.Add(this.txtMSV);
            this.panel2.Controls.Add(this.lblMSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 282);
            this.panel2.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(171)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(227)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QuanLiSinhVien_Project3.Properties.Resources.maintenance_32px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(398, 216);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 48);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QuanLiSinhVien_Project3.Properties.Resources.remove_32px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(253, 216);
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
            this.btnThem.Location = new System.Drawing.Point(109, 216);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 48);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Nhập";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDTB
            // 
            this.btnDTB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDTB.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDTB.Location = new System.Drawing.Point(725, 112);
            this.btnDTB.Name = "btnDTB";
            this.btnDTB.Size = new System.Drawing.Size(166, 38);
            this.btnDTB.TabIndex = 2;
            this.btnDTB.Text = "Tính điểm Trung bình";
            this.btnDTB.UseVisualStyleBackColor = false;
            // 
            // txtDiemC
            // 
            this.txtDiemC.Location = new System.Drawing.Point(388, 146);
            this.txtDiemC.Name = "txtDiemC";
            this.txtDiemC.Size = new System.Drawing.Size(166, 22);
            this.txtDiemC.TabIndex = 1;
            // 
            // lblDiemmonC
            // 
            this.lblDiemmonC.AutoSize = true;
            this.lblDiemmonC.Location = new System.Drawing.Point(298, 147);
            this.lblDiemmonC.Name = "lblDiemmonC";
            this.lblDiemmonC.Size = new System.Drawing.Size(84, 17);
            this.lblDiemmonC.TabIndex = 0;
            this.lblDiemmonC.Text = "ĐIểm môn C";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(99, 146);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(166, 22);
            this.txtLop.TabIndex = 1;
            // 
            // txtDiemB
            // 
            this.txtDiemB.Location = new System.Drawing.Point(388, 109);
            this.txtDiemB.Name = "txtDiemB";
            this.txtDiemB.Size = new System.Drawing.Size(166, 22);
            this.txtDiemB.TabIndex = 1;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(37, 149);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(32, 17);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // lblDiemmonB
            // 
            this.lblDiemmonB.AutoSize = true;
            this.lblDiemmonB.Location = new System.Drawing.Point(298, 110);
            this.lblDiemmonB.Name = "lblDiemmonB";
            this.lblDiemmonB.Size = new System.Drawing.Size(84, 17);
            this.lblDiemmonB.TabIndex = 0;
            this.lblDiemmonB.Text = "Điểm môn B";
            // 
            // txtTSV
            // 
            this.txtTSV.Location = new System.Drawing.Point(99, 109);
            this.txtTSV.Name = "txtTSV";
            this.txtTSV.Size = new System.Drawing.Size(166, 22);
            this.txtTSV.TabIndex = 1;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(725, 72);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(166, 22);
            this.txtDTB.TabIndex = 1;
            // 
            // txtDiemA
            // 
            this.txtDiemA.Location = new System.Drawing.Point(388, 72);
            this.txtDiemA.Name = "txtDiemA";
            this.txtDiemA.Size = new System.Drawing.Size(166, 22);
            this.txtDiemA.TabIndex = 1;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(585, 73);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(134, 17);
            this.lblDiemTB.TabIndex = 0;
            this.lblDiemTB.Text = "Trung bình các môn";
            // 
            // lblTenSv
            // 
            this.lblTenSv.AutoSize = true;
            this.lblTenSv.Location = new System.Drawing.Point(37, 112);
            this.lblTenSv.Name = "lblTenSv";
            this.lblTenSv.Size = new System.Drawing.Size(55, 17);
            this.lblTenSv.TabIndex = 0;
            this.lblTenSv.Text = "Tên SV";
            // 
            // lblDiemmonA
            // 
            this.lblDiemmonA.AutoSize = true;
            this.lblDiemmonA.Location = new System.Drawing.Point(298, 73);
            this.lblDiemmonA.Name = "lblDiemmonA";
            this.lblDiemmonA.Size = new System.Drawing.Size(84, 17);
            this.lblDiemmonA.TabIndex = 0;
            this.lblDiemmonA.Text = "Điểm môn A";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(99, 72);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(166, 22);
            this.txtMSV.TabIndex = 1;
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(37, 75);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(37, 17);
            this.lblMSV.TabIndex = 0;
            this.lblMSV.Text = "MSV";
            // 
            // Frm_QuanLyDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewQLD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyDiemSV";
            this.Text = "Frm_QuanLyDiemSV";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewQLD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtDiemC;
        private System.Windows.Forms.Label lblDiemmonC;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiemB;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblDiemmonB;
        private System.Windows.Forms.TextBox txtTSV;
        private System.Windows.Forms.TextBox txtDiemA;
        private System.Windows.Forms.Label lblTenSv;
        private System.Windows.Forms.Label lblDiemmonA;
        private System.Windows.Forms.Button btnDTB;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col__MonA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MonB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MonC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TongDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Xeploai;
    }
}