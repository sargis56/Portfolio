using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W8C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("Bob", 30) {  Address = "35 Elm St, Toronto"};
            Console.WriteLine(aPerson.GetInfo());

            Student aStudent = new Student("Ann", 18);
            //aStudent.Name = "Ann";
            aStudent.Address = "10 King St, Toronto";
            aStudent.StudentId = 300;
            Console.WriteLine(aStudent.GetInfo());

            Teacher aTeacher = new Teacher("John", 40) { Address = "1 King St", Salary = 40000M, EmpId = 333};
            Console.WriteLine(aTeacher.GetInfo());

            Console.WriteLine("\n*******************************");
            Person someone;

            someone = aPerson;
            //Console.WriteLine(someone.GetInfo());
            Console.WriteLine(someone);

            someone = aStudent;
            //Console.WriteLine(someone.GetInfo());
            Console.WriteLine(someone);

            someone = aTeacher;
            //Console.WriteLine(someone.GetInfo());
            Console.WriteLine(someone);

            Console.WriteLine(someone.GetType());
            Console.WriteLine(someone.GetHashCode());
            Console.WriteLine(someone);
            Console.WriteLine(someone.ToString());
        }
    }
}
