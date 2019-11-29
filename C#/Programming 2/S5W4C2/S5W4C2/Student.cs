﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E1
{
    class Student
    {
        private int studentID;
        private double gpa;
        private int semester;
        private int program;

        public Student()
        {

        }

        public Student(int studentID, double gpa, int semester, int program)
        {
            //Console.WriteLine("Constructing student with id {0}", studentID);
            this.StudentID = studentID;
            this.GPA = gpa;            
            this.Program = program;
            this.Semester = semester;
        }

        public Student(int studentID)
        {
            Console.WriteLine("Constructing student with id {0}", studentID);
            this.StudentID = studentID;
        }

        ~Student()
        {
            Console.WriteLine("Destructing student with id {0}", studentID);
        }

        public int StudentID
        {
            set
            {
                studentID = value;
            }
            get
            {
                return studentID;
            }
        }

        public double GPA
        {
            set
            {
                gpa = value;
            }
            get
            {
                return gpa;
            }
        }

        public int Semester
        {
            set
            {
                semester = value;
            }
            get
            {
                return semester;
            }
        }

        public int Program
        {
            set
            {
                program = value;
            }
            get
            {
                return program;
            }
        }

        public void TellAboutSelf()
        {
            Console.WriteLine("A Studnet: \n StudentID = {0}; GPA = {1}; Semester = {2}; Program = {3}", StudentID, GPA, Semester, Program);
        }
    }
}
