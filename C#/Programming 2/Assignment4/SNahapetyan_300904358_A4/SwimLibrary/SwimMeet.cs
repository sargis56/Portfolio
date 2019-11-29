using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class SwimMeet
    {
        private DateTime startDate;
        private DateTime endDate;
        private string nameMeet;
        public enum PoolType { SCM,LCM, SCY};
        private PoolType course;
        private int numberLanes;
        private int numberOfEvents = 0;
        public List<Event> ArrayEvents { set; get; }

        public SwimMeet(string nameOfMeet, DateTime startDate, DateTime endDate,  PoolType course, int numberLanes)
        {
            StartDate = startDate;
            EndDate = endDate;
            NameMeet = nameOfMeet;
            this.course = course;
            NumberLanes = numberLanes;
           ArrayEvents = new List<Event>();
        }

        public SwimMeet ()
        {
            ArrayEvents = new List<Event>();
        }

        public string NameMeet
        {
            set
            {
                nameMeet = value;
            }
            get
            {
                return nameMeet;
            }
        }

        public int NumberLanes
        {
            get
            {
                return numberLanes;
            }

            set
            {
                numberLanes = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }


        public PoolType Course
        {
            get
            {
                return course;
            }
        } 

        public void AddEvent(Event event1)
        {
            ArrayEvents.Add(event1);
            numberOfEvents++;
            event1.SwimMeet = this;
        }


        public void Seed()
        {
            foreach (Event sEvent in ArrayEvents)
            {
                int j = 0;
                int heat = 1;
                int lane = 1;
                foreach (Registrant swimmer in sEvent.ArraySwimmers)
                {
                    sEvent.AddSwim();

                    if (lane <= NumberLanes)
                    {
                        sEvent.ArraySwim[j].Lane = lane;
                        sEvent.ArraySwim[j].Heat = heat;
                        lane++;
                    }
                    else
                    {
                        lane = 1;
                        heat++;
                        sEvent.ArraySwim[j].Lane = lane;
                        sEvent.ArraySwim[j].Heat = heat;
                    }
                    j++;
                }
            }
        }

        public override string ToString()
        {
            string info = string.Format("Swim meet name: {0}\nFrom-to:  {1} to {2}\nPool type: {3}\nNo lanes: {4}", NameMeet, StartDate.Date.ToString("d"), EndDate.Date.ToString("d"), Course,NumberLanes);
            info += string.Format("\nEvents:");
            int i = 0;
            foreach (Event item in ArrayEvents)
            {
                info += string.Format("\n\t{0} {1}\n\tSwimmers: {2}\n", item.DistanceValue, item.StrokeValue, item.GetInfoSwimmers());
                i++;
            }
            return info;
        }


    }
}
