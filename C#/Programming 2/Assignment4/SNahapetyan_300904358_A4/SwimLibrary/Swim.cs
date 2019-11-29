using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Swim
    {
        private string timeSwam;
        private int heat;
        private int lane;
        Event eventSwim;

        public Swim(int heat,int lane)
        {
            Heat = heat;
            Lane = lane;
        }
        public Swim()
        {
        }


        public int Heat
        {
            set
            {
                heat = value;
            }
            get
            {
                return heat;
            }
        }

        public int Lane
        {
            set
            {
                lane = value;
            }
            get
            {
                return lane;
            }
        }

        public string TimeSwam
        {
            get
            {
                return timeSwam;
            }

            set
            {
                timeSwam = value;
            }
        }

        public Event EventSwim
        {
            set
            {
                eventSwim = value;
            }
            get
            {
                return eventSwim;
            }
        }

        public override string ToString()
        {
            return string.Format("Swim: \n\tLane: {0}\n\tHeat: {1}\n\tTime: {2}\n", Lane, Heat, TimeSwam);
        }

    }
}
