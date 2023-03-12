﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static internal class UserData
    {
        static private List<User> _testUsers = new List<User>();
        static public List<User>TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static public void ResetTestUserData()
        {
            while (_testUsers.Count == 0)
            {
                DateTime currentDate = DateTime.Now;
                DateTime validToDate = DateTime.MaxValue;
                _testUsers.Add(new User("nsekulovAD", "randompassadmin", "__invalid__", 1, currentDate, validToDate));
                _testUsers.Add(new User("nsekulov", "randompass1", "121220076", 4, currentDate, validToDate));
                _testUsers.Add(new User("randstudent", "randompass2", "121220077", 4, currentDate, validToDate));
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
                Logger.LogActivity("[USER] Changed active untill dato for user" + user.Username + " to: " + newValidToDate);
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
                Logger.LogActivity("[USER] Changed role for user" + user.Username + " to: " + newRole);
                return (UserRoles) user.Role;
            }
            return UserRoles.ANONYMOUS;
        }
    }
}
