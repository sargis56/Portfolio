using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W6C2E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(31132, "Madden");
            Teacher teacher2 = new Teacher();
            teacher2.IdNumber = 234423;
            teacher2.Name = "John";

            //Course course = new Course("COMP 135", "Fan-Fic Writing");
            //Course course2 = new Course();
            //course2.Code = "COMP 235";
            //course2.Name = "Stuff Writin";

            try
            {
                //Error free
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));
                teacher.AddCourse(new Course("COMP 135", "Fan-Fic Writing"));

                Console.WriteLine(teacher.GetInfo());

                //Should give an error
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));
                teacher2.AddCourse(new Course("COMP 235", "Stuff Writing"));

                //Console.WriteLine(teacher2.GetInfo());

                //course.Faculty = new Teacher(31132, "Madden");
                //Console.WriteLine(course.GetInfo());

                //course2.Faculty = new Teacher(234423, "John");
                //Console.WriteLine(course2.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
