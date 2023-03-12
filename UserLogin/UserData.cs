using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal static class UserData
    {
        static private User _testUser;
        static public User TestUser
        {
            get {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }
        static public void ResetTestUserData()
        {
            while (_testUser == null)
            {
                _testUser = new User("Username", "pass", "1212", 0);
            }
        }
    }
}
