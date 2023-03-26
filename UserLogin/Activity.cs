using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{

    public enum ActivitiesList
    {
        Exit,
        UserAuth,
        UserChangeRole,
        UserChangeExpiration,
        ListUsers,
        ListLogFile,
        ListSessionLog
    }

    public class Activity
    {
        public ActivitiesList Id
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }

        public Activity (string description, ActivitiesList id)
        {
            this.Description = description;
            this.Id = id;
        }
    }
}
