using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien_Project3.User
{
    class Usercf
    {
        private long id;
        private string username;
        private string pass;
        private string question;

        public Usercf() { }

        public Usercf(long id, string username, string pass, string question)
        {
            this.id = id;
            this.username = username;
            this.pass = pass;
            this.question = question;
        }

        public long Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Question { get => question; set => question = value; }
    }
}
