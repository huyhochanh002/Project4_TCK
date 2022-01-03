using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }
        public GiaoDienChinh frm;
        public delegate void adongTap();
        public adongTap DongTap;
        private void Frm_Register_Load(object sender, EventArgs e)
        {

        }
        public void GhiFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (User.Usercf item in Userlist.ListUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3}",
                            item.Id, item.Username, item.Pass, item.Question));
                    }
                }
            }
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            int kiemtra = 0;
            foreach (User.Usercf item in Userlist.ListUser)
            {
                if (item.Username == txt_tentk.Text)
                {
                    kiemtra++;
                }
            }
            if (txt_mkmoi.Text != txt_mkmoixacnhan.Text||kiemtra>0)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng hoặc trùng tài khoản ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_tentk != null && txt_mkmoi != null && txt_mkmoixacnhan != null && txt_cauhoibimat != null)
            {
                User.Usercf usc = new User.Usercf();
                usc.Id = Frm_ChangePass.timmax()+1;
                usc.Username = txt_tentk.Text;
                usc.Pass = txt_mkmoi.Text;
                usc.Question = txt_cauhoibimat.Text;
                Userlist.ListUser.Add(usc);
                GhiFile(Userlist.pathfile);
                MessageBox.Show("Tạo tài khoảng thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Userlist userl = new Userlist();
                userl.GetUser(Userlist.pathfile);
                kiemtra = 0;
            }
            else
            {

                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txt_mkmoixacnhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}
