using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W3C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();

            aStudent.StudentID = 6564;
            aStudent.GPA = 4.5;
            aStudent.Semester = 1;
            aStudent.Program = 123;

            aStudent.TellAboutSelf();

            Student aStudent1 = new Student(2, 3.0, 2, 1234);

            aStudent1.TellAboutSelf();
        }
    }
}
