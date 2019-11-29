//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3
//File Name: Swimmer.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Swimmer : Registrant
    {
        List<TimeSpan> bestTimes = new List<TimeSpan>();
        List<PoolType> courses = new List<PoolType>();
        List<Stroke> strokes = new List<Stroke>();
        List<EventDistance> distances = new List<EventDistance>();
        TimeSpan returnTime;
        //TimeSpan bestTime;
        //PoolType bestCourse;
        //Stroke bestStroke;
        //EventDistance bestDistance;

        //List<Tuple<PoolType, Stroke, EventDistance>> bestTimesCheck = new List<Tuple<PoolType, Stroke, EventDistance>>();

        Coach coach;

        public Swimmer(string name, DateTime dateOfBirth, Address address, UInt32 phoneNumber):base(name, dateOfBirth, address, phoneNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Swimmer()
        {

        }

        public Swimmer(Coach coach)
        {
            this.Coach = coach;
        }

        public Coach Coach
        {
            set
            {
                coach = value;
            }
            get
            {
                return coach;
            }
        }

        public TimeSpan GetBestTime(PoolType course, Stroke stroke, EventDistance distance)
        {
            //TimeSpan returnTime = new TimeSpan(0, 0, 0);      

            for (int i = 0; i < bestTimes.Count; i++)
            {
                if ((courses[i] == course) && (strokes[i] == stroke) && (distances[i] == distance))
                {
                    returnTime = bestTimes[i];
                    returnTime = new TimeSpan(0, 0, 0);
                }
            }

            return returnTime;
        }

        public void AddAsBestTime(PoolType course, EventDistance distance, Stroke stroke, TimeSpan time)
        {
            if (bestTimes.Min() >= time)
            {
                bestTimes.Add(time);
                courses.Add(course);
                strokes.Add(stroke);
                distances.Add(distance);
            }

            //bestTimes.Add(time);
            //courses.Add(course);
            //strokes.Add(stroke);
            //distances.Add(distance);
        }

        public override string GetInfo()
        {
            if (Club == null)
            {
                ClubName = "not assigned";
            }
            else
            {
                ClubName = Club.Name;
            }
            string coachString;
            if (Coach == null)
            {
                coachString = "not assigned";
            }
            else
            {
                coachString = Convert.ToString(Coach);
            }
            string returnString = string.Format("Name: {0}\nAdress: \n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nDOB: {6}\nReg number: {7}\nClub: {8}\nCoach: {9}", Name, Address.AddressStreet, Address.City, Address.Province, Address.Postal, PhoneNumber, DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt"), RegistNum, ClubName, coachString);
            return returnString;
        }

        public override string ToString()
        {
            return GetInfo();
        }

    }
}
