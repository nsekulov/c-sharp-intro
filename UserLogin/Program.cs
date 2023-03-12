using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = null;
            Console.Write("User:");
            string username = Console.ReadLine();
            Console.Write("Pass:");
            string password = Console.ReadLine();
            LoginValidation validator = new LoginValidation(username, password, handleLoginFail);
            if (validator.ValidateUserInput(ref newUser))
            {
                Console.WriteLine(newUser);
                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.STUDENT:
                        Console.WriteLine("Logged in as a Student!");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Logged in as an Admin!");
                        break;
                }
            }
        }

        static void handleLoginFail(string errorMsg)
        {
            Console.WriteLine("Login failed: " + errorMsg);
        }
    }
}
