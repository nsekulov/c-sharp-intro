using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string Qualification { get; set; }
        public string Status { get; set; }
        public string Faculty_ID { get; set; }
        public string Year { get; set; }
        public string Year_Group { get; set; }
        public string Group { get; set; }

        public Student (string firstName, string middleName, string lastName, string faculty, string specialty, string qualification, string status, string faculty_ID, string year, string year_Group, string group)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Specialty = specialty;
            Qualification = qualification;
            Status = status;
            Faculty_ID = faculty_ID;
            Year = year;
            Year_Group = year_Group;
            Group = group;
        }
        
        public Student ()
        {

        }
    }
}
