using SwimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Swimmer:Registrant
    {
        private Coach coach;
        public List<String> BestTimeList { get; set; }


        public Swimmer(string registrantName, DateTime datetime, Address address, long registrantTel) : base(registrantName, datetime, address, registrantTel)
        {
            BestTimeList = new List<String>();
        }

        public Swimmer()
        {
            BestTimeList = new List<String>();
        }

        public Coach Coach
        {
            //Sargis eited this
            //get => coach;
            get
            {
                return coach;
            }
            set
            {
                if (Club == value.Club && !value.Swimmers.Contains(this))
                {
                    coach = value;
                    coach.AddSwimmer(this);
                }
                else if (value.Club != Club && value.Club != null)
                {
                    throw new Exception("Coach and swimmer are not in the same club");
                }
                else
                {
                    throw new Exception("Coach is not assigned to the club");
                }
            }
        }


        public TimeSpan GetBestTime(SwimMeet.PoolType course, Event.Stroke stroke, Event.Distance distance)
        {
            TimeSpan time = TimeSpan.Zero;
            foreach (string item in BestTimeList)
            {
                if (item.Contains(course.ToString()) && item.Contains(stroke.ToString()) && item.Contains(distance.ToString()))
                {
                    string stringTime = item.Substring(item.LastIndexOf('|') + 1, 8);
                    time = Event.StringToTimeSpan(stringTime);
                }
            }
            return time;
        }

        public void AddAsBestTime(SwimMeet.PoolType course, Event.Stroke stroke, Event.Distance distance, TimeSpan givenTime)
        {
            string newItem = "";
            string thisItem = "";
            foreach (string item in BestTimeList)
            {
                if (item.Contains(course.ToString()) && item.Contains(stroke.ToString()) && item.Contains(distance.ToString()))
                {

                    string stringTime = item.Substring(item.LastIndexOf('|') + 1, 8);
                    TimeSpan thisTime = Event.StringToTimeSpan(stringTime);
                    if (TimeSpan.Compare(thisTime, givenTime) == 1)
                    {
                        newItem = item.Replace(thisTime.ToString().Substring(3, 8), givenTime.ToString().Substring(3, 8));
                        thisItem = item;
                        break;
                    }
                }
            }
            if (newItem != "")
                BestTimeList[BestTimeList.IndexOf(thisItem)] = newItem;


        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nAdress: {1}\nTelephone number: {2}\nDOB: {3}\nREgistration number: {4}\nClub: {5}\nCoach: {6}", RegistrantName, Adress.ToString(), RegistrantPhone, RegistrantDate, RegistrantNumber, Club != null ? Club.ClubName : "not assigned", Coach != null ? Coach.RegistrantName : "not assigned");
        }
    }
}
