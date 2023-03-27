using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static internal class StudentData
    {
        static private List<Student> _students = new List<Student>();
        static public List<Student> students {
            get
            {
                ResetTestStudentData();
                return _students;
            }
            set { }
        }

        static private void ResetTestStudentData()
        {
            while (_students.Count == 0)
            {
                _students.Add(new Student("Nikola", "Jordanov", "Sekulov", "FKST", "KSI", "Bakalaver", "Bluska tam", "121220***", "3", "9 potok", "46b"));
            }
        }
    }
}
