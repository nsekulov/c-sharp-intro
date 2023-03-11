using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserLogin
{
    internal class User
    {
        public String Username
            { get; set; }
        public String Password
            { get; set;}
        public String FakNum
            { get; set;}
        public Int32 Role
            { get; set;}

        public User(string username, string password, string fakNum, int role)
        {
            Username = username;
            Password = password;
            FakNum = fakNum;
            Role = role;
        }

        public override string ToString()
        {
            return "User: " + Username + " with UID: " + FakNum;
        }
    }
}
