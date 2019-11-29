using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W4C2E3
{
    class Section
    {
        private int noOfStudents;
        private string course;
        private int sectionNo;
        private Student[] classList;

        public Section(int sectionNumber, string course)
        {
            Course = course;
            SectionNo = sectionNo;
            classList = new Student[10];
        }

        public int NoOfStudents
        {
            get
            {
                return noOfStudents;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public int SectionNo
        {
            get
            {
                return sectionNo;
            }
            set
            {
                sectionNo = value;
            }
        }

        public string GetInfo()
        {

        }

        public void AddStudent(Student aStudent)
        {
            classList[noOfStudents] = aStudent;
            noOfStudents++;
        }
    }


}
