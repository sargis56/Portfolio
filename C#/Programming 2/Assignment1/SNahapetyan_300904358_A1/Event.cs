//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: Event.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    public enum Stroke { butterfly, backstroke, breaststroke, freestyle, medley };
    public enum SwimDistance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500 };

    class Event
    {
        //private int[] swimDistance = new int[6] { 50, 100, 200, 400, 800, 1500 };
        private Stroke aStroke;
        private SwimDistance aSwimDistance;

        public Event()
        {

        }

        public Event(SwimDistance swimDistance, Stroke stroke)
        {
            this.ASwimDistance = swimDistance;
            this.AStroke = stroke;
        }

        public SwimDistance ASwimDistance
        {
            set
            {
                aSwimDistance = value;
            }
            get
            {
                return aSwimDistance;
            }
        }

        public Stroke AStroke
        {
            set
            {
                aStroke = value;
            }
            get
            {
                return aStroke;
            }
        }

        public string GetInfo()
        {
            string returnString = string.Format("Event Information: \nEvent’s swim distance: {0}\nStroke: {1}\n", ASwimDistance, AStroke);
            return returnString;
        }

    }
}
