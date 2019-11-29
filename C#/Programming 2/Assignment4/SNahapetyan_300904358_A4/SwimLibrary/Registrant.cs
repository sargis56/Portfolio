using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Registrant
    {
        protected int registrantNumber;
        protected static int registrantStaticNumber;
        protected string regitsrantName;
        DateTime registrantDate;
        protected long registrantPhone;
        protected Address adress;
        protected Club club;
        protected Event eventRegistrant;


        public Registrant(string registrantName,DateTime dateRegistrant, Address adress, long registrantPhone)
        { 
            RegistrantName = registrantName;
            Adress = adress;
            RegistrantPhone = registrantPhone;
            RegistrantDate = dateRegistrant;
            registrantNumber = registrantStaticNumber++;
        }
        public Registrant()
        {
            registrantNumber = registrantStaticNumber++;
        }

        static Registrant()
        {
            registrantStaticNumber = 1;
        }

        public string RegistrantName
        {
            set
            {
                regitsrantName = value;
            }
            get
            {
                return regitsrantName;
            }
        }

        public long RegistrantPhone
        {
            get
            {
                return registrantPhone;
            }

            set
            {
                registrantPhone = value;
            }
        }

        public Club Club
        {
            get
            {
                return club;
            }

            set
            {
                if (club == null)
                {
                    club = value;
                    Club.AddSwimmer(this);
                }
                else 
                {
                    Console.WriteLine("Registrant is assigned to {0} club", Club.ClubName);
                }
            }
        }

        public DateTime RegistrantDate
        {
            get
            {
                return registrantDate;
            }

            set
            {
                registrantDate = value;
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

        public Event EventRegistrant
        {
            get
            {
                return eventRegistrant;
            }

            set
            {
                eventRegistrant = value;
            }
        }

        public int RegistrantNumber
        {
            get
            {
                return registrantNumber;
            }
            set
            {
                registrantNumber = value;
            }
        }

        public override string ToString()
        {
            string clubname;
            if (Club == null)
            {
                clubname = "not assigned";
            }
            else
            {
                clubname = Club.ClubName;
            }
            return $"Name: {RegistrantName}\nAdress: {adress.ToString()}\nTelephone number: {registrantPhone}\nDOB: {registrantDate}\nRegistration number: {RegistrantNumber}\nClub: {clubname}";
        }
    }
}
