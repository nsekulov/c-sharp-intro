using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static internal class UserData
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
                DateTime currentDate = DateTime.Now;
                DateTime validToDate = DateTime.MaxValue;
                _testUsers[0] = new User("nsekulovAD", "randompassadmin", "__invalid__", 1, currentDate, validToDate);
                _testUsers[1] = new User("nsekulov", "randompass1", "121220076", 4, currentDate, validToDate);
                _testUsers[2] = new User("randstudent", "randompass2", "121220077", 4, currentDate, validToDate);
            }
        }

        static private User GetTestUserByName(string username)
        {
            foreach (User user in TestUsers)
            {
                if(user.Username == username) return user;
            }
            return null;
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

        static public DateTime SetUserActiveUntill(string username, DateTime newValidToDate) {
            User user = GetTestUserByName(username);
            if (user != null) {
                user.ValidToDate = newValidToDate;
                return user.ValidToDate;
            }
            return DateTime.MinValue;
        }
        static public UserRoles AssignUserRole(string username, UserRoles newRole)
        {
            User user = GetTestUserByName(username);
            if (user != null)
            {
                user.Role = (int) newRole;
                return (UserRoles) user.Role;
            }
            return UserRoles.ANONYMOUS;
        }
    }
}
