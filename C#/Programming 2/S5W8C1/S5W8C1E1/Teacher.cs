using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W8C1E1
{
    class Teacher : Person
    {
        private int empId;
        private decimal salary;
        
        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(", EmpId: {0}, Salary: {1:c}", EmpId, Salary);
        }
        public override string ToString()
        {
            return GetInfo();
        }

        public Teacher(string name, int age) : base(name, age)
        {
            Console.WriteLine("In Teacher constructor");
            Name = name;
            Age = age;
        }
    }
}
