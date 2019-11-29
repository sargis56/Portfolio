//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A2PA
//File Name: Event.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A2PA
{
    public enum Stroke { Butterfly, Backstroke, Breaststroke, Freestyle, Medley };
    public enum EventDistance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500 };

    class Event
    {
        //private int[] swimDistance = new int[6] { 50, 100, 200, 400, 800, 1500 };
        private Stroke stroke;
        private EventDistance distance;

        private Registrant[] swimmers = new Registrant[99];
        private int swimmerArrayNum = 0;
        private Swim[] swimArray = new Swim[99];
        public Event()
        {

        }

        public Event(EventDistance distance, Stroke stroke)
        {
            this.Distance = distance;
            this.Stroke = stroke;
        }

        public EventDistance Distance
        {
            set
            {
                distance = value;
            }
            get
            {
                return distance;
            }
        }

        public Stroke Stroke
        {
            set
            {
                stroke = value;
            }
            get
            {
                return stroke;
            }
        }

        public void AddSwimmer(Registrant swimmer)
        {

            if (Array.IndexOf(swimmers, swimmer) == -1)
            {
                swimmers[swimmerArrayNum] = swimmer;
                swimmer.RegistNum = swimmerArrayNum + 1;
                swimmerArrayNum++;
            }
            else
            {
                throw new Exception("Swimmer " + swimmer.Name + " " + swimmer.RegistNum + " is already entered");
            }

        }

        public void Seed(PoolType aPoolType, int noOfLanes)
        {

            for (int i = 0; i < swimmerArrayNum; i++)
            {
                Registrant currentSwimmer = swimmers[i];
                int lane = i % noOfLanes + 1;
                int heat = i / noOfLanes + 1;
                Swim swim = new Swim(null, heat, lane);

                swimArray[i] = swim;
            }
            
        }

        public void EnterSwimmersTime(Registrant swimmer, String time)
        {

        }

        public string GetInfo()
        {
            string returnString = Distance + " " + Stroke + "\n";

            for (int i = 0; i < swimmerArrayNum; i++)
            {
                Registrant currentSwimmer = swimmers[i];
                returnString += currentSwimmer.Name;
                Swim swim = swimArray[i];
                if (swim == null)
                {
                    returnString += "\tNot seeded/No swim\n";
                }
                else
                {
                    returnString += swim.GetInfo();
                }
            }

            return returnString;
        }

    }
}
