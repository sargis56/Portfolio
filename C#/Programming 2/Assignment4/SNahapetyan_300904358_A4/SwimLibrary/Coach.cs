using SwimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class Coach : Registrant
    {
        public Club Club { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public string Credentials { set; get; }
        public Coach(string registrantName, DateTime datetime, Address address, long registrantTel) : base(registrantName, datetime, address, registrantTel)
        {
            registrantNumber = registrantStaticNumber++;
            Swimmers = new List<Swimmer>();
        }
        public Coach()
        {
            registrantNumber = registrantStaticNumber++;
            Swimmers = new List<Swimmer>();
        }

        public void AddSwimmer(Swimmer aSwimmer)
        {
            if (Club == aSwimmer.Club && !Swimmers.Contains(aSwimmer))
            {
                if (aSwimmer.Coach != this)
                    aSwimmer.Coach = this;
                if (!Swimmers.Contains(aSwimmer))
                    Swimmers.Add(aSwimmer);
            }
            else if (Club != aSwimmer.Club && Club != null)
            {
                throw new Exception("Coach and swimmer are not in the same club");
            }
            else if (Club == null)
            {
                throw new Exception("Coach is not assigned to a club");
            }
        }

        public override string ToString()
        {
            string info = string.Format("\nName: {0}\nAdress: {1}\nTelephone number: {2}\nDOB: {3}\nREgistration number: {4}\nClub: {5}\nCredentials: {6}", RegistrantName, Adress.ToString(), RegistrantPhone, RegistrantDate, RegistrantNumber , Club != null ? Club.ClubName : "not assigned", Credentials);
            info += string.Format("\nSwimmers:");

            foreach (Swimmer swimmer in Swimmers)
            {
                info += string.Format("\n\t{0}", swimmer.RegistrantName);
            }
            return info;
        }
    }
}
