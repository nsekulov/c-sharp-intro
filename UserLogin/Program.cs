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

            authView();
            baseNavigationView();
        }

        static void baseNavigationView()
        {
            switch (LoginValidation.currentUserRole)
            {
                case UserRoles.STUDENT:
                    Console.WriteLine("Logged in as a Student!");
                    break;
                case UserRoles.ADMIN:
                    Console.WriteLine("Logged in as an Admin!");
                    adminNavigationView();
                    break;
            }
        }

        static void adminNavigationView()
        {
            int option = -1;
            while (option < 0 || option > ActivityData.Activitites.Count)
            {
                Console.WriteLine("Изберете опция: ");
                foreach (Activity activity in ActivityData.Activitites)
                {
                    Console.WriteLine((int) activity.Id + ". " + activity.Description);
                }
                option = Convert.ToInt32(Console.ReadLine());
            }

            string username;
            switch (option) {
                case 0:
                    return;
                case 2:
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Role: ");
                    int role = Convert.ToInt32(Console.ReadLine());
                    UserData.AssignUserRole(username, (UserRoles) role);
                    break;
                case 3:
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Date (DD/MM/YR): ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    UserData.SetUserActiveUntill(username, date);
                    break;
                case 5:
                    Logger.ReadLogActivity();
                    break;
                case 6:
                    Logger.DisplayLogActivity();
                    break;
            }
            adminNavigationView();
        }
        
        static User authView()
        {
            User newUser = null;
            while (newUser == null)
            {
                Console.Write("Username:");
                string username = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();
                LoginValidation validator = new LoginValidation(username, password, handleLoginFail);
                if (!validator.ValidateUserInput(ref newUser))
                {
                    newUser = null;
                }
            }
            return newUser;
        }

        static void handleLoginFail(string errorMsg)
        {
            Console.WriteLine("Login failed: " + errorMsg + " Retry...");
        }
    }
}
