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
    public partial class Frm_KhaoSat : Form
    {
        public Frm_KhaoSat()
        {
            InitializeComponent();
        }
        public GiaoDienChinh frm;
        public delegate void adongTap();
        public adongTap DongTap;
        
        private void Frm_KhaoSat_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        public void Loaddata()
        {
            KSsv ks = new KSsv();
            ks.GetNguoi(KSsv.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = KSsv.ListSV;
            datasinhviendihoc.DataSource = bin;
        }
        List<SinhVien.SinhVien> listtam = new List<SinhVien.SinhVien>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemSinhvVienNghi1.id !="")
            {
                listtam.Clear();
                long idtam = Convert.ToInt64(kiemSinhvVienNghi1.id);
                foreach (SinhVien.SinhVien per in KSsv.ListSV)
                {
                    if (per.Id == idtam)
                    {
                        listtam.Add(per);
                    }
                }
                Loaddata2();
            }
            else if (kiemSinhvVienNghi1.ten != "")
            {
                listtam.Clear();
                foreach (SinhVien.SinhVien per in KSsv.ListSV)
                {
                    if (per.Ten.Equals(kiemSinhvVienNghi1.ten))
                    {
                        listtam.Add(per);
                    }
                }
                Loaddata2();
            }
            else if (kiemSinhvVienNghi1.id == "" && kiemSinhvVienNghi1.ten == "")
            {
                listtam.Clear();
                foreach (SinhVien.SinhVien per in KSsv.ListSV)
                {
                    if (per.Tinhtrang == kiemSinhvVienNghi1.tt)
                    {
                        listtam.Add(per);
                    }
                }
                Loaddata2();
            }
            else
            {
                listtam.Clear();
            }
            
        }
        public void Loaddata2()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = listtam;
            datasinhviendihoc.DataSource = bin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void kiemSinhvVienNghi1_Load(object sender, EventArgs e)
        {

        }
        XuatFileEX xuat = new XuatFileEX();
        private void btn_xuatexks_Click(object sender, EventArgs e)
        {
            if (listtam.Count > 0)
            {
                SaveFileDialog open = new SaveFileDialog();
                open.InitialDirectory = @"d:\";
                open.Filter = "Execl files (*.xlsx)|*.xlsx";
                open.Title = "Lưu File Excel";
                open.DefaultExt = "xlsx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    xuat.Xuatexcelne(datasinhviendihoc, open.FileName);
                }
            }
        }

        private void bth_refesh_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
