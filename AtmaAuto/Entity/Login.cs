using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmaAuto.Entity
{
    class Login
    {
        string username, password;

        public Login(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
