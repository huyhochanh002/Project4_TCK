using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_Project3.SinhVien
{
    public class SinhVien
    {
        private long id;
        private string ten;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private string nghanghoc;
        private string lop;
        private string hedaotao;
        private int tinhtrang;
        private string diachi;
        private int diem;

        public SinhVien(){}

        public SinhVien(long id, string ten, string ngaysinh, string gioitinh, string sdt, string nghanghoc, string lop, string hedaotao, int tinhtrang, string diachi, int diem)
        {
            this.Id = id;
            this.Ten = ten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Nghanghoc = nghanghoc;
            this.Lop = lop;
            this.Hedaotao = hedaotao;
            this.Tinhtrang = tinhtrang;
            this.Diachi = diachi;
            this.Diem = diem;
        }

        public long Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Nghanghoc { get => nghanghoc; set => nghanghoc = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Hedaotao { get => hedaotao; set => hedaotao = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
