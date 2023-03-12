using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;

        public LoginValidation(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        static public UserRoles currentUserRole
        {
            get;
            private set;
        }
        public bool ValidateUserInput(ref User user)
        {
            if (username.Equals(string.Empty)) {
                errorMessage = "Не е посочено потребителско име";
                return false;
            }
            if (password.Equals(string.Empty))
            {
                errorMessage = "Не е посочена парола";
                return false;
            }
            if (username.Length <= 5)
            {
                errorMessage = "Името е твърде кратко.";
                return false;
            }
            if (password.Length <= 5)
            {
                errorMessage = "Паролата е твърде кратка.";
                return false;
            }
            user = UserData.TestUser;
            currentUserRole = (UserRoles)user.Role;
            return true;
        }
    }
}
