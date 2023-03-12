using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUsername + ";"
            + LoginValidation.currentUserRole + ";"
            + activity;
            currentSessionActivities.Add(activityLine);
            WriteLogActivity(activityLine);
        }

        static public void DisplayLogActivity()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in currentSessionActivities)
            {
                sb.AppendLine(line);
            }
            Console.WriteLine(sb.ToString());
        }

        static private void WriteLogActivity(string activity)
        {
            StreamWriter logWriter = new StreamWriter("test.txt", true);
            logWriter.WriteLine(activity);
            logWriter.Close();
        }

        static public void ReadLogActivity()
        {
            StreamReader logReader = new StreamReader("test.txt");
            while (!logReader.EndOfStream)
            {
                Console.WriteLine(logReader.ReadLine());
            }
            logReader.Close();
        }
    }
}
