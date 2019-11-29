//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: SwimMeet.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    public enum Course { SCM, SCY, LCM };

    class SwimMeet
    {
        private string startDate;
        private string endDate;
        private string meetName;
        private Course aPoolType;

        public SwimMeet()
        {

        }

        public SwimMeet(string startDate, string endDate, string meetName, Course poolType)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MeetName = meetName;
            this.aPoolType = poolType;
        }

        public string StartDate
        {
            set
            {
                startDate = value;
            }
            get
            {
                return startDate;
            }
        }

        public string EndDate
        {
            set
            {
                endDate = value;
            }
            get
            {
                return endDate;
            }
        }

        public string MeetName
        {
            set
            {
                meetName = value;
            }
            get
            {
                return meetName;
            }
        }

        public Course PoolType
        {
            set
            {
                aPoolType = value;
            }
            get
            {
                return aPoolType;
            }
        }

        public string GetInfo()
        {
            string returnString = string.Format("Swim Meeting Information: \nSwim Meeting’s starting date: {0}\nSwim Meeting’s end date: {1}\nName of the meeting: {2}\nCourse (pool type): {3}\n", StartDate, EndDate, MeetName, PoolType);
            return returnString;
        }

    }
}
