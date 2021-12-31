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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        Userlist userl = new Userlist();
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            userl.GetUser(Userlist.pathfile);
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
                            item.Id,item.Username,item.Pass, item.Question));
                    }
                }
            }
        }
        User.Usercf uscf;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Chưa nhập UserName!");
                txtUserName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {

                if (string.IsNullOrEmpty(txtPassWord.Text))
                {
                    errorProvider1.SetError(txtPassWord, "Chưa nhập PassWord!");
                    txtPassWord.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            if (txtUserName != null)
            {
                foreach (User.Usercf item in Userlist.ListUser)
                {
                    if (item.Username == txtUserName.Text && txtPassWord.Text == item.Pass)
                    {
                        gdc.ShowDialog();
                    }
                }
            }
            else {
                MessageBox.Show("Sai thông tin đăng nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GhiFile(Userlist.pathfile);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ChangePass cp = new Frm_ChangePass();
            cp.Show();
        }

        private void btn_đk_Click(object sender, EventArgs e)
        {
            Frm_Register frg = new Frm_Register();
            frg.Show();
        }
    }
}
