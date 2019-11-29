//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3PA
//File Name: SwimMeet.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum PoolType { SCM, SCY, LCM };

    public class SwimMeet
    {
        private DateTime startDate;
        private DateTime endDate;
        private string name;
        private PoolType aPoolType;
        private int noOfLanes;
        private Event[] events = new Event[50];
        private int eventArrayNum = 0;
        private Event currentEvent;

        public SwimMeet()
        {

        }

        public SwimMeet(string name, DateTime startDate, DateTime endDate, PoolType poolType, int noOfLanes)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Name = name;
            this.APoolType = poolType;
            this.NoOfLanes = noOfLanes;
            this.Events = events;
            this.EventArrayNum = eventArrayNum;
            this.CurrentEvent = currentEvent;
        }

        public Event CurrentEvent
        {
            set
            {
                currentEvent = value;
            }
            get
            {
                return currentEvent;
            }
        }

        public Event[] Events
        {
            set
            {
                events = value;
            }
            get
            {
                return events;
            }
        }

        public int EventArrayNum
        {
            set
            {
                eventArrayNum = value;
            }
            get
            {
                return eventArrayNum;
            }
        }

        public DateTime StartDate
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

        public DateTime EndDate
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

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public PoolType APoolType
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

        public int NoOfLanes
        {
            set
            {
                noOfLanes = value;
            }
            get
            {
                return noOfLanes;
            }
        }

        public void AddEvent(Event eventHeld)
        {
            events[eventArrayNum] = eventHeld;

            eventArrayNum++;
        }

        public void Seed()
        {
            if (NoOfLanes == 0)
            {
                return;
            }

            for (int i = 0; i < eventArrayNum; i++)
            {
                currentEvent = events[i];
                currentEvent.Seed(APoolType, NoOfLanes);
            }
        }

        public string GetInfo()
        {
            string eventString = "";

            for (int i = 0; i < eventArrayNum; i++)
            {
                currentEvent = events[i];
                eventString += currentEvent.GetInfo();
            }

            string returnString = string.Format("Sweem meet name: {0}\nFrom-to: {1} to {2}\nPool type: {3}\nNo lanes: {4}\nEvents: {5}", Name, StartDate.ToString("yyyy-MM-dd"), EndDate.ToString("yyyy-MM-dd"), APoolType, NoOfLanes, eventString);
            return returnString;
        }

    }
}
