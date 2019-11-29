using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W8C1E1
{
    class Student : Person
    {
        int studentId;

        public int StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public Student(string name, int age):base(name, age)
        {
            Console.WriteLine("In student constructor");
            Name = name;
            Age = age;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(", StudentId: {0}",  StudentId);
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}

