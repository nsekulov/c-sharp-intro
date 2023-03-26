using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class StudentValidation
    {
        public StudentInfoSystem.Student GetStudentDataByUser(User user)
        {
            if (user.FakNum == null)
            {
                return null;
            }
            StudentInfoSystem.Student student = (
                from _student in StudentInfoSystem.StudentData.students
                where _student.Faculty_ID == user.FakNum
                select _student
                ).First();
            return student;
        }
    }
}
