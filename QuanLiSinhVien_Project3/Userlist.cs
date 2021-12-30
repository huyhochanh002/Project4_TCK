using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    class Userlist
    {
        public static List<User.Usercf> ListUser = new List<User.Usercf>();
        public static string pathfile = string.Format(@"{0}\User.ini", Application.StartupPath);
        public void GetUser(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    ListUser.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] svarray = line.Split(',');
                            User.Usercf us = new User.Usercf();
                            us.Id = svarray[0];
                            us.Pass = svarray[1];
                            us.Question = svarray[2];
                            ListUser.Add(us);
                        }
                    }
                }
            }
        }
    }
}

