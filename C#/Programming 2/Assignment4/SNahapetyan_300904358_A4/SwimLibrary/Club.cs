using OlimpicSwimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Club
    {
        private static int clubStaticNumber;
        private int clubNumber;
        private string clubName;
        private long clubPhone;
        private Address adress;
        private int numberOfRegistrants=0;
        public List<Registrant> ArraySwimmers { get; set; }
        public List<Registrant> ArrayCoaches { get; set; }

        public Club(string clubName, Address address, long clubPhone)
        {
            ClubName = clubName;
            this.Adress = address;
            ClubPhone = clubPhone;
            ArraySwimmers = new List<Registrant>();
            ArrayCoaches = new List<Registrant>();
            clubNumber = clubStaticNumber++;
        }

        public Club() 
        {
            ArrayCoaches = new List<Registrant>();
            ArraySwimmers = new List<Registrant>();
            clubNumber = clubStaticNumber++;
        }

        static Club()
        {
            clubStaticNumber = 1;
        }


        public string ClubName
        {
            set
            {
                clubName = value;
            }
            get
            {
                return clubName;
            }
        }

        public long ClubPhone
        {
            get
            {
                return clubPhone;
            }

            set
            {
                clubPhone = value;
            }
        }



        public int ClubNumber
        {
            get
            {
                return clubNumber;
            }
            set
            {
                clubNumber = value;
            }
        }

        public Address Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }
        public void AddCoach(Coach coach)
        {
            ArrayCoaches.Add(coach);
            coach.Club = this;
        }
        public void AddSwimmer(Registrant registrant)
        {
            if (numberOfRegistrants == 0 || ArraySwimmers[numberOfRegistrants-1] != registrant )
            {

                if (registrant.Club == null || registrant.Club == this)
                {
                    ArraySwimmers.Add(registrant);
                    numberOfRegistrants++;
                    if (registrant.Club == null)
                    {
                        registrant.Club = this;
                    }
                }
                else
                {
                    Console.WriteLine("Registrant is assigned to {0} club", registrant.Club.ClubName);
                }
            }
        }

        public override string ToString()
        {
            string info = string.Format("Name: {0}\nAdress: {1}\nTelephone number: {2}\nClub number: {3}", clubName, Adress.ToString(), ClubPhone, ClubNumber);
            info += string.Format("\nSwimmers:");

            int i = 0;
            foreach (Registrant item in ArraySwimmers)
            {
                info += string.Format("\n\t{0}", item.RegistrantName);
                i++;
            }
            info += string.Format("\nCoaches:");

            i = 0;
            foreach (Coach item in ArrayCoaches)
            {
                info += string.Format("\n\t{0}", item.RegistrantName);
                i++;
            }
            return info;
        }
    }
}
