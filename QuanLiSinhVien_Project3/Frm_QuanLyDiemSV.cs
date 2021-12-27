using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace QuanLiSinhVien_Project3
{
    public partial class Frm_QuanLyDiemSV : Form
    {
        public Frm_QuanLyDiemSV()
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
            dataGridViewQLD.DataSource = bin;
        }
        public void Loaddata2()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = listsv;
            dataGridViewQLD.DataSource = bin;
        }
        List<SinhVien.SinhVien> listsv = new List<SinhVien.SinhVien>();

        public void GhiFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (SinhVien.SinhVien item in KSsv.ListSV)
                    {

                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item.Id, item.Ten, item.Ngaysinh, item.Gioitinh, item.Sdt, item.Nghanghoc, item.Lop, item.Hedaotao, item.Tinhtrang, item.Diachi, item.Diem));
                    }
                }
            }
        }


        private void Hienthi()
        {
            KSsv ks = new KSsv();
            ks.GetNguoi(KSsv.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = KSsv.ListSV;
            dataGridViewQLD.DataSource = bin;

        }







        private void dataGridViewQLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }





        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewQLD.CurrentCell.RowIndex;
                dataGridViewQLD.Rows.RemoveAt(index);
            }
        }







        private void Frm_QuanLyDiemSV_Load_1(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void txtDTB_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnDTB_Click(object sender, EventArgs e)
        {
            listsv.Clear();
            foreach (SinhVien.SinhVien item in KSsv.ListSV)
            {
                int a = Convert.ToInt32(item.Diem);
                int b = Convert.ToInt32(txtDTB.Text);
                if (a <= b)
                {
                    listsv.Add(item);
                }
            }
            Loaddata2();
        }

        XuatFileEX xuat = new XuatFileEX();
        private void btnex_Click(object sender, EventArgs e)
        {
            if (listsv.Count > 0)
            {
                SaveFileDialog open = new SaveFileDialog();
                open.InitialDirectory = @"d:\";
                open.Filter = "Execl files (*.xlsx)|*.xlsx";
                open.Title = "Lưu File Excel";
                open.DefaultExt = "xlsx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    xuat.Xuatexcelne(dataGridViewQLD, open.FileName);
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }


        //private void btnex_Click(object sender, EventArgs e)
        //{
        //    if (listsv.Count > 0)
        //    {
        //        SaveFileDialog open = new SaveFileDialog();
        //        open.InitialDirectory = @"d:\";
        //        open.Filter = "Execl files (*.xlsx)|*.xlsx";
        //        open.Title = "Lưu File Excel";
        //        open.DefaultExt = "xlsx";
        //        if (open.ShowDialog() == DialogResult.OK)
        //        {
        //            xuat.Xuatexcelne(dataGridViewQLD, open.FileName);
        //        }
        //    }



    }
}


