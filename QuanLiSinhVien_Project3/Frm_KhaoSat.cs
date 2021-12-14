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
    }
}
