using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            
            timedate.Start();
            
        }

        private void timedate_Tick(object sender, EventArgs e)
        {
            lb_thoigian.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }
        #region Kiem Tra Tab
        bool trangThai=false;
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tabcontrol_center.Tabs.Count; i++)
            {
                if (tabcontrol_center.Tabs[i].Text == name)
                {
                    tabcontrol_center.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tabcontrol_center.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tabcontrol_center.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion

        private void pn_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabcontrol_center_Click(object sender, EventArgs e)
        {

        }
        public GiaoDienChinh frm;
        public delegate void _dongTap();
        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản lý Sinh Viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_QuanLySV";

            Frm_QuanLySV frm_QuanLySV = new Frm_QuanLySV() { 
                DongTap =new Frm_QuanLySV._dongTap(DongTab),
                frm=this,
                TopLevel=false,
                Dock=DockStyle.Fill,
            };
                t.AttachedControl.Controls.Add(frm_QuanLySV);
                frm_QuanLySV.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnQuanLyDienSV_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản lý điểm Sinh Viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_QuanLyDiemSV";

                Frm_QuanLyDiemSV frm_QuanDiemLySV = new Frm_QuanLyDiemSV()
                {
                    DongTap = new Frm_QuanLyDiemSV._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_QuanDiemLySV);
                frm_QuanDiemLySV.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void lb_thoigian_Click(object sender, EventArgs e)
        {

        }

        private void btnLichhoc_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Lịch học cho sinh viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_Calendar";

                Frm_Calender frm_Calender=new Frm_Calender()
                {
                   DongTap = new Frm_Calender._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frm_Calender);
                frm_Calender.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Đăng Ký Học Phần";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_Calendar";

                FrmDangKi frmDangKi = new FrmDangKi()
                {
                    DongTap = new FrmDangKi._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmDangKi);
                frmDangKi.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void pn_leftcon1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKhaosat_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Khảo Sát";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "Frm_KhaoSat";

                Frm_KhaoSat frmkhaosat = new Frm_KhaoSat()
                {
                    DongTap = new Frm_KhaoSat.adongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmkhaosat);
                frmkhaosat.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }
    }
}
