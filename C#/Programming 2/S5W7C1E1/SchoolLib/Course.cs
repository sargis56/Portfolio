using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Course
    {
        private string code;
        private string name;
        private Teacher faculty;

        public Course()
        {
            this.Code = code;
            this.Name = name;
            this.Faculty = faculty;
        }

        public Course(string code, string name)
        {
            this.Code = code;
            this.Name = name;
            this.Faculty = faculty;
        }

        public string Code
        {
            set
            {
                code = value;
            }
            get
            {
                return code;
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

        public Teacher Faculty
        {
            set
            {
                faculty = value;
            }
            get
            {
                return faculty;
            }
        }

        public string GetInfo()
        {
            string returnString = string.Format("Name: {0}, Code: {1}, Faculty: {2}", Name, Code, Faculty);
            //returnString = "Name: " +  this.Name + " Code: " + this.Code + " Faculty: " + this.Faculty;
            return returnString;
        }
    }
}
