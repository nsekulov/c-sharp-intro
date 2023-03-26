using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static internal class ActivityData
    {
        static private List<Activity> _activities = new List<Activity>();
        public static List<Activity> Activitites
        {
            get {
                resetActivities();
                return _activities;
            }
            private set { }
        }

        static private void resetActivities()
        {
            while(_activities.Count == 0)
            {
            _activities.Add(new Activity("Изход", ActivitiesList.Exit));
            _activities.Add(new Activity("Промяна на роля на потребител", ActivitiesList.UserChangeRole));
            _activities.Add(new Activity("Промяна на крайна дата на активност на потребител", ActivitiesList.UserChangeExpiration));
            _activities.Add(new Activity("Списък на потребители", ActivitiesList.ListUsers));
            _activities.Add(new Activity("Преглед на лог файл", ActivitiesList.ListLogFile));
            _activities.Add(new Activity("Преглед на текушен лог", ActivitiesList.ListSessionLog));
            }
        }
    }
}
