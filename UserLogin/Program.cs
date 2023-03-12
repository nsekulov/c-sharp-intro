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
            LoginValidation validator = new LoginValidation(username, password);
            if (validator.ValidateUserInput(ref newUser))
            {
                Console.WriteLine(newUser);
                Console.WriteLine(LoginValidation.currentUserRole);
            }
        }
    }
}
