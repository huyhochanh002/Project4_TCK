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
                        sw.WriteLine(string.Format("{0},{1},{2}",
                            item.Id, item.Pass, item.Question));
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tentk != null)
            {
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (txt_tentk.Text == item.Id && txt_mkcu.Text == item.Pass)
                    {
                        item.Id = txt_tentk.Text;
                        item.Pass = txt_mkmoi.Text;
                        item.Question = txt_cauhoibimat.Text;
                    }
                }
                GhiFile(Userlist.pathfile);
                txt_tentk = null;
            }
            else {
                MessageBox.Show("Đổi mật khẩu thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txt_tentk != null)
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (txt_tentk.Text != item.Id)
                    {
                        MessageBox.Show("Sai tài khoản!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void txt_mkcu_TextChanged(object sender, EventArgs e)
        {
            if (txt_mkcu != null)
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (txt_mkcu.Text != item.Pass)
                    {
                        MessageBox.Show("Sai mật khẩu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Frm_Login flg = new Frm_Login();
            flg.Show();
            this.Close();
        }

        private void txt_mkmoixacnhan_TextChanged(object sender, EventArgs e)
        {
            if (txt_mkmoi != txt_mkmoixacnhan)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_hienthich_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (txt_mkcu.Text != item.Id)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            else{
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    textBox1.Text = item.Question;
                }
            }
        }
    }
 }
