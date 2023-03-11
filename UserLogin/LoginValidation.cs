using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
        static public UserRoles currentUserRole
        {
            get;
            private set;
        }
        public bool ValidateUserInput(String username, String password)
        {
            currentUserRole = UserRoles.ADMIN;
            return true;
        }
    }
}
