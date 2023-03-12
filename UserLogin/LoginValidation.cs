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
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;

        public LoginValidation(string username, string password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = actionOnError;
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
            }
            if (password.Equals(string.Empty))
            {
                errorMessage = "Не е посочена парола";
            }
            if (username.Length <= 5)
            {
                errorMessage = "Името е твърде кратко.";
            }
            if (password.Length <= 5)
            {
                errorMessage = "Паролата е твърде кратка.";
            }

            if (errorMessage != null)
            {
                currentUserRole = UserRoles.ANONYMOUS;
                actionOnError(errorMessage);
                return false;
            }

            user = UserData.IsUserPassCorrect(username, password);

            if (user == null)
            {
                errorMessage = "Невалидни име и/или парола.";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
            return true;
        }
    }
}
