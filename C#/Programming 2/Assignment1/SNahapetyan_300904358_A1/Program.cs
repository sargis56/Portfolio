//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Club aClub = new Club(234546546,"Sadie", 1999999999, new Address("Progress Ave", 941));
            Registrant aRegistrant = new Registrant(348939853, "Miller", "12/12/12", 1873456132, "Pickering Road", 284);
            SwimMeet aSwimMeet = new SwimMeet("1/2/5", "1/2/7", "Somthing", Course.SCM);
            Event aEvent = new Event(SwimDistance._1500, Stroke.butterfly);
            Swim aSwim = new Swim("1:05.52", 2, 5);

            Console.WriteLine(aClub.GetInfo());
            Console.WriteLine(aRegistrant.GetInfo());
            Console.WriteLine(aSwimMeet.GetInfo());
            Console.WriteLine(aEvent.GetInfo());
            Console.WriteLine(aSwim.GetInfo());

        }
    }
}
