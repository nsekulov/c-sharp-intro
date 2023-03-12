using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal static class UserData
    {
        static private User[] _testUsers = new User[3];
        static public User[] TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static public void ResetTestUserData()
        {
            while (_testUsers[0] == null)
            {
                _testUsers[0] = new User("nsekulovAD", "randompassadmin", "__invalid__", 1);
                _testUsers[1] = new User("nsekulov", "randompass1", "121220076", 4);
                _testUsers[2] = new User("randstudent", "randompass2", "121220077", 4);
            }
        }

        static public User IsUserPassCorrect(string username, string password) {
            foreach (User user in TestUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
