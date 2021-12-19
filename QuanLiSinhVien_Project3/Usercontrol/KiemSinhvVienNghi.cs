using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3.Usercontrol
{
    public partial class KiemSinhvVienNghi : UserControl
    {
        public KiemSinhvVienNghi()
        {
            InitializeComponent();
        }
        public string id
        {
            
            get { return ID.Text; }
        }
        public String ten
        {
            get { return Tensinhvien.Text; }
        }
        public int tt
        {
            get { return Tinhtrang.SelectedIndex; }
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
