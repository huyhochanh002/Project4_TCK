
namespace QuanLiSinhVien_Project3.Usercontrol
{
    partial class KiemSinhvVienNghi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.TextBox();
            this.Tensinhvien = new System.Windows.Forms.TextBox();
            this.Tinhtrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(259, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(203, 29);
            this.ID.TabIndex = 0;
            // 
            // Tensinhvien
            // 
            this.Tensinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensinhvien.Location = new System.Drawing.Point(259, 78);
            this.Tensinhvien.Name = "Tensinhvien";
            this.Tensinhvien.Size = new System.Drawing.Size(203, 29);
            this.Tensinhvien.TabIndex = 0;
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinhtrang.FormattingEnabled = true;
            this.Tinhtrang.Items.AddRange(new object[] {
            "Nghỉ",
            "Đang học"});
            this.Tinhtrang.Location = new System.Drawing.Point(505, 75);
            this.Tinhtrang.Name = "Tinhtrang";
            this.Tinhtrang.Size = new System.Drawing.Size(121, 32);
            this.Tinhtrang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(501, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình Trạng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tim
            // 
            this.btn_tim.AutoSize = true;
            this.btn_tim.BackColor = System.Drawing.Color.Azure;
            this.btn_tim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_tim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(259, 139);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(203, 47);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm Kiếm";
            this.btn_tim.UseVisualStyleBackColor = false;
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(505, 139);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(237, 47);
            this.lb_thongbao.TabIndex = 4;
            // 
            // KiemSinhvVienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tinhtrang);
            this.Controls.Add(this.Tensinhvien);
            this.Controls.Add(this.ID);
            this.Name = "KiemSinhvVienNghi";
            this.Size = new System.Drawing.Size(759, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Tensinhvien;
        private System.Windows.Forms.ComboBox Tinhtrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label lb_thongbao;
    }
}
