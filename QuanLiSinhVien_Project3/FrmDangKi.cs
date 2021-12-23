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
    public partial class timLop : Form
    {
        public timLop()
        {
            InitializeComponent();
        }
        public GiaoDienChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
        
        public void Loaddata()
        {
            KSsv ks = new KSsv();
            ks.GetNguoi(KSsv.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = KSsv.ListSV;
            dgvData.DataSource = bin;
        }

        private void FrmDangKi_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        List<SinhVien.SinhVien> listtam = new List<SinhVien.SinhVien>();
        private void button2_Click(object sender, EventArgs e)
        {
            listtam.Clear();
            foreach (SinhVien.SinhVien item in KSsv.ListSV)
            {
                if (item.Lop == lop.Text)
                {
                    listtam.Add(item);
                }
            }
            Loaddata2();
        }
        public void Loaddata2()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = listtam;
            dgvData.DataSource = bin;
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            listtam.Clear();
            foreach (SinhVien.SinhVien item in KSsv.ListSV)
            {
                if (item.Lop == "")
                {
                    listtam.Add(item);
                    MessageBox.Show("nhấn vào OK để hiện danh sách Sinh Viên không có Lớp");
                }
            }
            Loaddata2();
            
        }
        XuatFileEX xuat = new XuatFileEX();
        private void button3_Click(object sender, EventArgs e)
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
                    xuat.Xuatexcelne(dgvData, open.FileName);
                }
            }
        }
    }
}
