using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W8C1E1
{
    class Person
    {
        string name;
        string address;
        int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Person(string name, int age)
        {
            Console.WriteLine("In Person constructor");
            Name = name;
            Age = age;
        }

        public Person()
        {
            Console.WriteLine("In default person constroctor");
            Name = "aaaa";
            Age = 1;
        }
        public virtual string GetInfo()
        {
            return string.Format("Name: {0}, Address: {1}, Age: {2}", Name, Address, Age);
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
