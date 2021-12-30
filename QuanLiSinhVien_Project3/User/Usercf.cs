using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_Project3.User
{
    class Usercf
    {
        private string id;
        private string pass;
        private string question;

        public Usercf() { }

        public Usercf(string ID, string Pass, string Question)
        {
            this.Id = id;
            this.Pass = pass;
            this.Question = question;
        }

        public string Id { get => id; set => id = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Question { get => question; set => question = value; }
    }
}
