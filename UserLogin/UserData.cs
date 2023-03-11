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
                Console.Write("User:");
                String username = Console.ReadLine();
                Console.Write("Pass:");
                String password = Console.ReadLine();
                LoginValidation validator = new LoginValidation();
                if (validator.ValidateUserInput(username, password))
                {
                    _testUser = new User(username, password, "121220076", 0);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
