using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FinalProject
{
    public class User
    {
        private string userName;
        private string passWord;

        public User() { }

        public User(string userName, string passWord)
        {
            this.Username = userName;
            this.Password = passWord;
        }

        public string Username
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }
    }
}