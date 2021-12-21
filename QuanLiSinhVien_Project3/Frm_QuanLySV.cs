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

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_QuanLySV : Form
    {
        public Frm_QuanLySV()
        {
            InitializeComponent();
        }
        KSsv ks;
        public GiaoDienChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        public void GhiFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (SinhVien.SinhVien item in KSsv.ListSV)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item.Id, item.Ten, item.Ngaysinh, item.Gioitinh, item.Sdt, item.Nghanghoc, item.Lop, item.Hedaotao,item.Tinhtrang, item.Diachi,item.Diem));
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_QuanLySV_Load(object sender, EventArgs e)
        {
            ks = new KSsv();
            Hienthi();
        }

        private void Hienthi()
        {
            ks.GetNguoi(KSsv.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = KSsv.ListSV;
            dgvData.DataSource = bin;
        }

        SinhVien.SinhVien sinhVien;
        private void dgvData_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                sinhVien = new SinhVien.SinhVien() {
                    Id = Convert.ToInt64(dgvData.CurrentRow.Cells["col_MaSV"].Value.ToString()),
                    Ten = dgvData.CurrentRow.Cells["col_TenSV"].Value.ToString(),
                    Ngaysinh = dgvData.CurrentRow.Cells["col_Ngaysinh"].Value.ToString(),
                    Gioitinh = dgvData.CurrentRow.Cells["col_Gioitinh"].Value.ToString(),
                    Diachi = dgvData.CurrentRow.Cells["col_Diachi"].Value.ToString(),
                    Sdt = dgvData.CurrentRow.Cells["col_Dienthoai"].Value.ToString(),
                    Nghanghoc = dgvData.CurrentRow.Cells["col_Tennganh"].Value.ToString(),
                    Lop = dgvData.CurrentRow.Cells["col_Lop"].Value.ToString(),
                    Hedaotao = dgvData.CurrentRow.Cells["col_He"].Value.ToString(),
                    Tinhtrang = Convert.ToInt32(dgvData.CurrentRow.Cells["col_Tinhtrang"].Value.ToString()),
                    Diem = Convert.ToInt32(dgvData.CurrentRow.Cells["col_Diem"].Value.ToString()),
                };

                txtTenSV.Text = dgvData.CurrentRow.Cells["col_TenSV"].Value.ToString();
                txtNgaySinh.Text = dgvData.CurrentRow.Cells["col_Ngaysinh"].Value.ToString();
                txtDiachi.Text = dgvData.CurrentRow.Cells["col_Diachi"].Value.ToString();
                txtDienthoai.Text = dgvData.CurrentRow.Cells["col_Dienthoai"].Value.ToString();
                txtHedaotao.Text = dgvData.CurrentRow.Cells["col_He"].Value.ToString();
                txtNganhhoc.Text = dgvData.CurrentRow.Cells["col_Tennganh"].Value.ToString();
                txtLop.Text = dgvData.CurrentRow.Cells["col_Lop"].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sinhVien != null)
            {
                foreach (SinhVien.SinhVien item in KSsv.ListSV)
                {
                    if (item.Id == sinhVien.Id)
                    {
                        KSsv.ListSV.Remove(item);
                        return;
                    }
                }
                sinhVien = null;
                GhiFile(KSsv.pathfile);
                Hienthi();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenSV.Text = "";
            txtNgaySinh.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtHedaotao.Text = "";
            txtNganhhoc.Text = "";
            txtLop.Text = "";
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenSV.Text))
            {
                SinhVien.SinhVien sinhvien = new SinhVien.SinhVien();
                long max = KSsv.ListSV[0].Id;
                for (int i = 0; i < KSsv.ListSV.Count; i++)
                {
                    if (max < KSsv.ListSV[i].Id)
                    {
                        max = KSsv.ListSV[i].Id;
                    }
                }
                sinhvien.Id = max + 1;
                sinhvien.Ten = txtTenSV.Text;
                sinhvien.Diachi = txtDiachi.Text;
                sinhvien.Gioitinh = txtGioiTinh.Text;
                sinhvien.Hedaotao = txtHedaotao.Text;
                sinhvien.Lop = txtLop.Text;
                sinhvien.Ngaysinh = txtNgaySinh.Text;
                sinhvien.Nghanghoc = txtNganhhoc.Text;
                sinhvien.Sdt = txtDienthoai.Text;
                KSsv.ListSV.Add(sinhvien);
                GhiFile(KSsv.pathfile);
                Hienthi();
            }
            else { 
            
            MessageBox.Show("Yêu cầu nhập đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (sinhVien != null)
            {
                foreach (SinhVien.SinhVien item in KSsv.ListSV)
                {
                    if (sinhVien.Id == item.Id)
                    {
                        item.Ten = txtTenSV.Text;
                        item.Diachi = txtDiachi.Text;
                        item.Gioitinh = txtGioiTinh.Text;
                        item.Hedaotao = txtHedaotao.Text;
                        item.Lop = txtLop.Text;
                        item.Ngaysinh = txtNgaySinh.Text;
                        item.Nghanghoc = txtNganhhoc.Text;
                        item.Sdt = txtDienthoai.Text;
                    }
                }
                GhiFile(KSsv.pathfile);
                sinhVien = null;
                Hienthi();
            }
        }
    }
}

