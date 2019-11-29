//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3
//File Name: Event.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Stroke { Butterfly, Backstroke, Breaststroke, Freestyle, Medley };
    public enum EventDistance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500 };

    public class Event
    {
        //private int[] swimDistance = new int[6] { 50, 100, 200, 400, 800, 1500 };
        private Stroke stroke;
        private EventDistance distance;

        //private Registrant[] swimmers = new Registrant[99];
        private List<Registrant> swimmers = new List<Registrant>();
        //private int swimmerArrayNum = 0;
        //private Swim[] swimArray = new Swim[99];
        private List<Swim> swimArray = new List<Swim>();

        public Event()
        {

        }

        public Event(EventDistance distance, Stroke stroke)
        {
            this.Distance = distance;
            this.Stroke = stroke;
            //this.SwimmerArrayNum = swimmerArrayNum;
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

        public List<Swim> SwimArray
        {
            set
            {
                swimArray = value;
            }
            get
            {
                return swimArray;
            }
        }

        //public int SwimmerArrayNum
        //{
        //    set
        //    {
        //        swimmerArrayNum = value;
        //    }
        //    get
        //    {
        //        return swimmerArrayNum;
        //    }
        //}

        public List<Registrant> Swimmers
        {
            set
            {
                swimmers = value;
            }
            get
            {
                return swimmers;
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

            if (swimmers.IndexOf(swimmer) == -1)
            {
                //swimmers[swimmerArrayNum] = swimmer;
                //swimmer.RegistNum = swimmerArrayNum + 1;
                //swimmerArrayNum++;
                swimmers.Add(swimmer);
            }
            else
            {
                throw new Exception("Swimmer " + swimmer.Name + " " + swimmer.RegistNum + " is already entered");
            }

        }

        public void Seed(PoolType aPoolType, int noOfLanes)
        {

            for (int i = 0; i < swimmers.Count; i++)
            {
                Registrant currentSwimmer = swimmers[i];
                int lane = i % noOfLanes + 1;
                int heat = i / noOfLanes + 1;
                Swim swim = new Swim(null, heat, lane);
                
                swimArray.Add(swim);
            }
            
        }

        public void EnterSwimmersTime(Registrant swimmer, String time)
        {
            for (int i = 0; i < swimArray.Count; i++)
            {
                if (swimmers[i] == swimmer)
                {
                    swimArray[i].TimeSwam = time;
                }
            }
        }

        public string GetInfo()
        {
            string returnString = Distance + " " + Stroke + "\nSwimmers: \n";

            for (int i = 0; i < swimArray.Count; i++)
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
                    returnString += swim.ToString();
                }
            }

            return returnString;
        }

        public override string ToString()
        {
            return GetInfo();
        }

    }
}
