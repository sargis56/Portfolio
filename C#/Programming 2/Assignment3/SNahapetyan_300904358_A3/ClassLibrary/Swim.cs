//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3
//File Name: Swim.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Swim
    {
        private string timeSwam;
        private int heatNum;
        private int laneNum;

        public Swim()
        {

        }

        public Swim(string timeSwam, int heatNum, int laneNum)
        {
            this.TimeSwam = timeSwam;
            this.HeatNum = heatNum;
            this.LaneNum = laneNum;
        }

        public string TimeSwam
        {
            set
            {
                timeSwam = value;
            }
            get
            {
                return timeSwam;
            }
        }

        public int HeatNum
        {
            set
            {
                heatNum = value;
            }
            get
            {
                return heatNum;
            }
        }

        public int LaneNum
        {
            set
            {
                laneNum = value;
            }
            get
            {
                return laneNum;
            }
        }

        public string GetInfo()
        {
            if (TimeSwam == null)
            {
                TimeSwam = "no time";
            }
            string returnString = string.Format("\n\tH{0}L{1}\t time: {2}\n", HeatNum, LaneNum, TimeSwam);
            return returnString;
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
