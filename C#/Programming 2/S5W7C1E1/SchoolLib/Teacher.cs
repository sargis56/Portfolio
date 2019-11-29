using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Teacher
    {
        private int idNumber;
        private string name;
        private Course[] courses;
        int noOfCourses = 0;

        public Teacher()
        {
            this.IdNumber = idNumber;
            this.Name = name;
            courses = new Course[10];
        }

        public Teacher(int idNumber, string name)
        {
            this.IdNumber = idNumber;
            this.Name = name;
            courses = new Course[10];
        }

        public int IdNumber
        {
            set
            {
                idNumber = value;
            }
            get
            {
                return idNumber;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public Course[] Courses
        {
            get
            {
                return courses;
            }
        }

        public string GetInfo()
        {
            string returnString = string.Format("Name: {0}, Idnumber: {1}, Courses:", Name, IdNumber);
            for (int i = 0; i <= 9; i++)
            {
                returnString += string.Format("\n\t{0}", Courses[i].GetInfo());
            }
            return returnString;
        }

        public void AddCourse(Course aCourse)
        {
            if (noOfCourses == 10)
            {
                throw new Exception(string.Format("The course {0} cannot be added to teacher {1} because he already have a max number of courses assighned", aCourse.Name, Name));
            }

            Courses[noOfCourses++] = aCourse;
            aCourse.Faculty = this;
        }
    }
}
