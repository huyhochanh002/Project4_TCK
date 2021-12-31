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
    public partial class Frm_ChangePass : Form
    {
        public Frm_ChangePass()
        {
            InitializeComponent();
        }
        Userlist usl;
        private void Hienthi()
        {
            usl.GetUser(Userlist.pathfile);
            BindingSource bin = new BindingSource();
            bin.DataSource = Userlist.ListUser;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static long timmax()
        {
            long max = 0;
            foreach (User.Usercf item in Userlist.ListUser)
            {
                if (max < item.Id)
                {
                    max = item.Id;
                }
            }
            return max;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tentk.Text))
            {
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (txt_tentk.Text == item.Username && txt_mkcu.Text == item.Pass)
                    {
                        item.Id = item.Id;
                        item.Username = txt_tentk.Text;
                        item.Pass = txt_mkmoi.Text;
                        item.Question = txt_cauhoibimat.Text;
                        GhiFile(Userlist.pathfile);
                        txt_tentk.Text = null;
                        Userlist userl = new Userlist();
                        userl.GetUser(Userlist.pathfile);
                        MessageBox.Show("Đổi mật khẩu thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;           
                    }
                }
                MessageBox.Show("Kiểm tra lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Không bỏ trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mkcu_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Frm_Login flg = new Frm_Login();
            flg.Show();
            this.Close();
        }

        private void txt_mkmoixacnhan_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_hienthich_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                int kiemtra = 0;
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (textBox2.Text == item.Username)
                    {
                        textBox1.Text = item.Question;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
