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
        private void Xoatt()
        {
            txtMSV.Text = "";
            txtTSV.Text = "";
            txtLop.Text = "";
            txtDiemA.Text = "";
            txtDiemB.Text = "";
            txtDiemC.Text = "";
            txtDTB.Text = "";
        }
        public void GhiFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (SinhVien.SinhVien item in KSsv.ListSV)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2}",
                             item.Ten, item.Lop, item.Diem));
                    }
                }
            }
        }
        private void Frm_QuanLyDiemSV_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Hienthi();
        }

        private void Hienthi()
        {
            KSsv ks = new KSsv();
            ks.GetNguoi(KSsv.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = KSsv.ListSV;
            dataGridViewQLD.DataSource = bin;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(txtMSV.Text != "" && txtTSV.Text != "" && txtLop.Text != "")
            {
                try
                {
                    double A = Convert.ToDouble(txtDiemA.Text);
                    double B = Convert.ToDouble(txtDiemB.Text);
                    double C = Convert.ToDouble(txtDiemC.Text);
                    if(A>=0 && A<=10 && B>=0 && B<=10 && C>=0 && C<=10)
                    {
                        double diemtb = (A + B + C) / 3;

                        dataGridViewQLD.Rows.Add(txtMSV.Text, txtTSV.Text, txtLop.Text, txtDiemA.Text, txtDiemB.Text, txtDiemC.Text,txtDTB.Text, diemtb.ToString());
                        Xoatt();
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10");
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Chưa nhập điểm kìa!");
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

      

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dataGridViewQLD.CurrentCell.RowIndex;
            dataGridViewQLD[0, index].Value = txtMSV.Text;
            dataGridViewQLD[1, index].Value = txtTSV.Text;
            dataGridViewQLD[2, index].Value = txtLop.Text;
            dataGridViewQLD[3, index].Value = txtDiemA.Text;
            dataGridViewQLD[4, index].Value = txtDiemB.Text;
            dataGridViewQLD[5, index].Value = txtDiemC.Text;
            dataGridViewQLD[6, index].Value = txtDTB.Text;
            double diemtb = (Convert.ToDouble(txtDiemA.Text) + Convert.ToDouble(txtDiemB.Text) + Convert.ToDouble(txtDiemC.Text)) / 3;
            dataGridViewQLD[7, index].Value = diemtb.ToString();
            Xoatt();

        }
        XuatFileEX xuat = new XuatFileEX();
        private void dataGridViewQLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewQLD.Rows[dataGridViewQLD.CurrentCell.RowIndex];
            txtMSV.Text = row.Cells[0].Value.ToString();
            txtTSV.Text = row.Cells[1].Value.ToString();
            txtLop.Text = row.Cells[2].Value.ToString();
            txtDiemA.Text = row.Cells[3].Value.ToString();
            txtDiemB.Text = row.Cells[4].Value.ToString();
            txtDiemC.Text = row.Cells[5].Value.ToString();

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
        


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa!","Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                int index = dataGridViewQLD.CurrentCell.RowIndex;
                dataGridViewQLD.Rows.RemoveAt(index);
            }
        }
    }
    }

