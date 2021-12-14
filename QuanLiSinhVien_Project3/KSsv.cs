using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    public class KSsv
    { /// <summary>
    /// /File này chỉ đọc và lấy dữ liệu không có thêm sữa xóa , muốn thêm sữa xóa thì làm trên file text để trong "bin" đó nha sau đó gọi ra file sinhvien text đó
    /// làm chung cho đồng bộ
    /// </summary>
        public static List<SinhVien.SinhVien> ListSV = new List<SinhVien.SinhVien>();
        public static string pathfile = string.Format(@"{0}\Sinhvien.txt", Application.StartupPath);
        public void GetNguoi(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    ListSV.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] svarray = line.Split(',');
                            SinhVien.SinhVien sv = new SinhVien.SinhVien();
                            sv.Id = Convert.ToInt64(svarray[0]);
                            sv.Ten = svarray[1];
                            sv.Ngaysinh = svarray[2];
                            sv.Gioitinh = svarray[3];
                            sv.Sdt = svarray[4];
                            sv.Nghanghoc = svarray[5];
                            sv.Lop = svarray[6];
                            sv.Hedaotao = svarray[7];
                            sv.Tinhtrang = Convert.ToInt32(svarray[8]);
                            ListSV.Add(sv);

                        }
                    }
                }
            }
        }
    }
}

