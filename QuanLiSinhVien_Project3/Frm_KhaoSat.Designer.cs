﻿
namespace QuanLiSinhVien_Project3
{
    partial class Frm_KhaoSat
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
            this.components = new System.ComponentModel.Container();
            this.pnkhaosat_full = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.datasinhviendihoc = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.kiemSinhvVienNghi1 = new QuanLiSinhVien_Project3.Usercontrol.KiemSinhvVienNghi();
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
            this.pnkhaosat_full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasinhviendihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnkhaosat_full
            // 
            this.pnkhaosat_full.BackColor = System.Drawing.Color.SkyBlue;
            this.pnkhaosat_full.Controls.Add(this.button2);
            this.pnkhaosat_full.Controls.Add(this.button1);
            this.pnkhaosat_full.Controls.Add(this.datasinhviendihoc);
            this.pnkhaosat_full.Controls.Add(this.kiemSinhvVienNghi1);
            this.pnkhaosat_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnkhaosat_full.Location = new System.Drawing.Point(0, 0);
            this.pnkhaosat_full.Name = "pnkhaosat_full";
            this.pnkhaosat_full.Size = new System.Drawing.Size(800, 450);
            this.pnkhaosat_full.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datasinhviendihoc
            // 
            this.datasinhviendihoc.AllowUserToAddRows = false;
            this.datasinhviendihoc.AllowUserToDeleteRows = false;
            this.datasinhviendihoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datasinhviendihoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasinhviendihoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datasinhviendihoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasinhviendihoc.Location = new System.Drawing.Point(0, 198);
            this.datasinhviendihoc.Name = "datasinhviendihoc";
            this.datasinhviendihoc.ReadOnly = true;
            this.datasinhviendihoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasinhviendihoc.Size = new System.Drawing.Size(800, 252);
            this.datasinhviendihoc.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Interval = 30000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Image = global::QuanLiSinhVien_Project3.Properties.Resources.no_32px1;
            this.button2.Location = new System.Drawing.Point(749, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 39);
            this.button2.TabIndex = 3;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kiemSinhvVienNghi1
            // 
            this.kiemSinhvVienNghi1.BackColor = System.Drawing.Color.SkyBlue;
            this.kiemSinhvVienNghi1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kiemSinhvVienNghi1.Location = new System.Drawing.Point(0, 0);
            this.kiemSinhvVienNghi1.Name = "kiemSinhvVienNghi1";
            this.kiemSinhvVienNghi1.Size = new System.Drawing.Size(800, 198);
            this.kiemSinhvVienNghi1.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "Diachi";
            this.coldiachi.HeaderText = "Địa Chỉ";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // coldiem
            // 
            this.coldiem.DataPropertyName = "Diem";
            this.coldiem.HeaderText = "Điểm";
            this.coldiem.Name = "coldiem";
            this.coldiem.ReadOnly = true;
            // 
            // colTEN
            // 
            this.colTEN.DataPropertyName = "Ten";
            this.colTEN.HeaderText = "TÊN";
            this.colTEN.Name = "colTEN";
            this.colTEN.ReadOnly = true;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.DataPropertyName = "Ngaysinh";
            this.colNGAYSINH.HeaderText = "NGÀY SINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.ReadOnly = true;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.DataPropertyName = "Gioitinh";
            this.colGIOITINH.HeaderText = "GIỚI TÍNH";
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.ReadOnly = true;
            // 
            // colDT
            // 
            this.colDT.DataPropertyName = "Sdt";
            this.colDT.HeaderText = "ĐIỆN THOẠI";
            this.colDT.Name = "colDT";
            this.colDT.ReadOnly = true;
            // 
            // colNGANHHOC
            // 
            this.colNGANHHOC.DataPropertyName = "Nghanghoc";
            this.colNGANHHOC.HeaderText = "NGHÀNG HỌC";
            this.colNGANHHOC.Name = "colNGANHHOC";
            this.colNGANHHOC.ReadOnly = true;
            // 
            // colLOP
            // 
            this.colLOP.DataPropertyName = "Lop";
            this.colLOP.HeaderText = "LỚP";
            this.colLOP.Name = "colLOP";
            this.colLOP.ReadOnly = true;
            // 
            // colHDT
            // 
            this.colHDT.DataPropertyName = "Hedaotao";
            this.colHDT.HeaderText = "HỆ ĐÀO TẠO";
            this.colHDT.Name = "colHDT";
            this.colHDT.ReadOnly = true;
            // 
            // colTT
            // 
            this.colTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTT.DataPropertyName = "Tinhtrang";
            this.colTT.HeaderText = "TÌNH TRẠNG";
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            // 
            // Frm_KhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnkhaosat_full);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_KhaoSat";
            this.Text = "Frm_KhaoSat";
            this.Load += new System.EventHandler(this.Frm_KhaoSat_Load);
            this.pnkhaosat_full.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasinhviendihoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnkhaosat_full;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView datasinhviendihoc;
        private Usercontrol.KiemSinhvVienNghi kiemSinhvVienNghi1;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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