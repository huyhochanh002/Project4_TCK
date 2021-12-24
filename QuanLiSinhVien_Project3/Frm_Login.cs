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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void dangnhap()
        {
            if (txtUserName.Text.Length == 0 && txtPassWord.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập PassWord!");
            else
                if (this.txtUserName.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập UserName!");
            else
                if (this.txtPassWord.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập PassWord!");
            else
                if (this.txtUserName.Text == "admin" && this.txtPassWord.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!");              
            }
            else
                MessageBox.Show("User hoặc PassWord không đúng!");

        }

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
            if(this.txtUserName.Text == "admin" && this.txtPassWord.Text == "admin")
            {
                gdc.Show();
            }
            dangnhap();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
