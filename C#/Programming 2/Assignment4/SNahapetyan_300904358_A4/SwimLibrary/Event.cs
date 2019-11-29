using OlimpicSwimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Event
    {
        public enum Distance: int
        {
            None,
            D50 = 50,
            D100 =100,
            D200 =200,
            D400 =400,
            D800 =800,
            D1500 =1500
        };
        private Distance distanceValue;
        public enum Stroke
        {
            Butterfly,
            Backstroke,
            Breaststroke,
            Freestyle,
            Individualmedley,
            None
        };
        private Stroke strokeValue;
        private SwimMeet swimMeet;
        private int numberSwimmers = 0;
        public List<Registrant> ArraySwimmers { get; set; }
        private int numberOfSwims = 0;
        public List<Swim> ArraySwim { get; set; }

        public Event(Distance distance, Stroke stroke)
        {
            DistanceValue = distance;
            StrokeValue = stroke;
            ArraySwimmers = new List<Registrant>();
            ArraySwim = new List<Swim>();
        }

        public Event() : this(Distance.None,Stroke.None)
        {
            ArraySwimmers = new List<Registrant>();
            ArraySwim = new List<Swim>();
        }

        public SwimMeet SwimMeet
        {
            set
            {
                swimMeet = value;
            }
            get
            {
                return swimMeet;
            }
        }

        public Distance DistanceValue
        {
            get
            {
                return distanceValue;
            }

            set
            {
                distanceValue = value;
            }
        }

        public Stroke StrokeValue
        {
            get
            {
                return strokeValue;
            }

            set
            {
                strokeValue = value;
            }
        }



        public void AddSwim()
        {
            Swim swim = new Swim();
            ArraySwim.Add(swim);
            numberOfSwims++;
            swim.EventSwim = this;
        }

 
        public void AddSwimmer(Registrant swimmer)
        {
            int switcher = 1;
            for (int i = 0; i < numberSwimmers; i++)
            {
                if (ArraySwimmers[i] == swimmer)
                    switcher = 0; ;
            }
                if (switcher==1)
                {
                    ArraySwimmers.Add(swimmer);
                    numberSwimmers++;
                    swimmer.EventRegistrant = this;
                }
                else
                {
                    Console.WriteLine("Swimmer {0}, {1} is already entered", swimmer.RegistrantName,swimmer.RegistrantNumber);
                }
        }


        public void EnterSwimmersTime(Registrant registrant, string time)
        {
            int index = ArraySwimmers.IndexOf(registrant);
            ArraySwim[index].TimeSwam = time;
             Swimmer swimmer = registrant as Swimmer;
            if (swimmer!=null)
            {
                TimeSpan newTime = StringToTimeSpan(time);

                string thisTimeValue= SwimMeet.Course+ "|"+ DistanceValue+ "|"+ StrokeValue+ "|"+ time;
                Console.WriteLine(thisTimeValue);

                if (swimmer.BestTimeList.Count == 0) 
                    swimmer.BestTimeList.Add(thisTimeValue);
                
                int trigger = 0;
                for (int i=0;i< swimmer.BestTimeList.Count;i++)
                {
                    if (swimmer.BestTimeList[i].Contains(SwimMeet.Course.ToString()) && swimmer.BestTimeList[i].Contains(DistanceValue.ToString()) && swimmer.BestTimeList[i].Contains(StrokeValue.ToString()))
                    {
                        string thisTime = swimmer.BestTimeList[i].Substring(swimmer.BestTimeList[i].LastIndexOf('|')+1,8);
                        TimeSpan previousTime = StringToTimeSpan(thisTime);
                        if (TimeSpan.Compare(previousTime, newTime) == 1)
                        {
                            swimmer.BestTimeList[i] = thisTimeValue;
                        }
                        trigger = 0;
                        break;
                    }
                    else
                    {
                        trigger = -1;
                    }
                }
                if (trigger == -1)
                    swimmer.BestTimeList.Add(thisTimeValue);
            }
        }

        public static TimeSpan StringToTimeSpan(string time)
        {
            int minutes = Int32.Parse(time.Substring(0, 2));
            int seconds = Int32.Parse(time.Substring(3, 2));
            int milliseconds = Int32.Parse(time.Substring(6, 2));
            TimeSpan newTime = new TimeSpan(0, 0, minutes, seconds, milliseconds * 10);
            return newTime;
        }

        public override string ToString()
        {
                return string.Format("Event: \n\tDistnce: {0}\n\tStroke: {1}\n", (int)DistanceValue, StrokeValue);
        }


        public string GetInfoSwimmers()
        {
            string info = "";
            int i = 0;
            foreach (Registrant aSwimmer in ArraySwimmers)
            {
                info += string.Format("\n\t{0,-11}  ", aSwimmer.RegistrantName);

                if (ArraySwim.ElementAtOrDefault(i) != null)
                    info += string.Format(" H{0}L{1}   time: {2}", ArraySwim[i].Heat, ArraySwim[i].Lane, ArraySwim[i].TimeSwam != null ? ArraySwim[i].TimeSwam : "no time");
                else
                    info += string.Format("Not seeded/no swim");
                i++;
            }
            return info;
        }

    }
}
