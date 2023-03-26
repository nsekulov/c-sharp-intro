﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(Activity activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUsername + ";"
            + LoginValidation.currentUserRole + ";"
            + activity.Description;
            currentSessionActivities.Add(activityLine);
            WriteLogActivity(activityLine);
        }

        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (
                from activity in currentSessionActivities
                where activity.Contains(filter)
                select activity).ToList();
            return currentSessionActivities;
        }

        static private void WriteLogActivity(string activity)
        {
            StreamWriter logWriter = new StreamWriter("test.txt", true);
            logWriter.WriteLine(activity);
            logWriter.Close();
        }

        static public IEnumerable<string> ReadLogActivity()
        {
            StreamReader logReader = new StreamReader("test.txt");
            List<string> logActivities = new List<string>();
            while (!logReader.EndOfStream)
            {
                logActivities.Add(logReader.ReadLine());
            }
            logReader.Close();
            return logActivities;
        }
    }
}
