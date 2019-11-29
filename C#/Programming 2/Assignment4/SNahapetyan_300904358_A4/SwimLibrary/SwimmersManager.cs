using OlimpicSwimLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class SwimmersManager :ISwimmersRepository
    {
        public List<Registrant> Swimmers;
        public int Number { set; get; }
        private ClubsManager clbMngr;

        public SwimmersManager(ClubsManager clbMngr)
        {
            Swimmers = new List<Registrant>();
            this.ClbMngr = clbMngr;
        }



        public ClubsManager ClbMngr
        {
            get
            {
                return clbMngr;
            }

            set
            {
                clbMngr = value;
            }
        }

        public Registrant Get(int regNumber)
        {
            Registrant returnValue = null;

            for (int i = 0; i < Number; i++)
            {
                if (Swimmers[i].RegistrantNumber == regNumber)
                    returnValue = Swimmers[i];
            }

            return returnValue;
        }

        public void Load(string fileName, string delimeter)
        {
            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;
            recordIn = reader.ReadLine();
            Registrant aRegistrant;


            while (recordIn != null)
            {
                fields = recordIn.Split(delimeter[0]);

                try
                {
                    //validation
                    ValidateIdNumber(fields[0]);
                    ValidatePhone(fields[7]);
                    ValidateName(fields[1]);
                    ValidateDate(fields[2]);

                    aRegistrant = CreateSwimmer();
                    aRegistrant.RegistrantNumber = Convert.ToInt32(fields[0]);
                    aRegistrant.RegistrantName = fields[1];
                    aRegistrant.RegistrantDate = DateTime.Parse(fields[2]);
                    aRegistrant.Adress = new Address(fields[3], fields[4], fields[5], fields[6]);
                    aRegistrant.RegistrantPhone = Convert.ToInt64(fields[7]);
                    int clubNumber = ValidateNumber(fields[8]);


                    if (clubNumber != 0)
                    {
                        for (int i = 0; i < ClbMngr.Number; i++)
                        {
                            if (ClbMngr.Clubs[i].ClubNumber == clubNumber)
                            {
                                ClbMngr.Clubs[i].AddSwimmer(aRegistrant);
                                break;
                            }
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("\t{0}", recordIn);
                }

                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }

        public void Save(string fileName, string delimeter)
        {
            FileStream fileOut = null;
            StreamWriter writer = null;
            try
            {
                fileOut = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(fileOut);
                for (int i = 0; i < Number; i++)
                {
                    string clubNumber;
                    if (Swimmers[i].Club == null)
                    {
                        clubNumber = "";
                    }
                    else
                    {
                        clubNumber = Swimmers[i].Club.ClubNumber.ToString();
                    }
                    writer.WriteLine(Swimmers[i].RegistrantNumber + delimeter + Swimmers[i].RegistrantName + delimeter + Swimmers[i].RegistrantDate + delimeter + Swimmers[i].Adress.Street + delimeter + Swimmers[i].Adress.City + delimeter + Swimmers[i].Adress.Province + delimeter + Swimmers[i].Adress.Zip + delimeter + Swimmers[i].RegistrantPhone + delimeter + clubNumber);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
                if (fileOut != null) fileOut.Close();
            }
        }

        private void ValidateIdNumber(string stringId)
        {
            int intId;
            int trigger = 0;
            try
            {
                intId = Convert.ToInt32(stringId);
                for (int i = 0; i < Number; i++)
                {
                    if (intId == Swimmers[i].RegistrantNumber)
                    {
                        trigger = 1;
                        throw new Exception("Invalid swimmer record. Swimmer with the registration number already exists:  ");
                    }
                }
            }

            catch (Exception error)
            {
                if (trigger == 0)
                    Console.WriteLine("Invalid swimmer record. Invalid registration number: ");
                else
                    Console.WriteLine(error.Message);
                throw;
            }
        }

        private void ValidatePhone(string stringPhone)
        {
            long intPhone;
            try
            {
                intPhone = Convert.ToInt64(stringPhone);
            }
            catch
            {
                Console.WriteLine("Invalid swimmer record. Phone number wrong format:  ");
                throw;
            }
        }

        private void ValidateName(string name)
        {
            try
            {
                if (name == "")
                    throw new Exception("Invalid swimmer record. Invalid swimmer name:   ");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
        }

        private void ValidateDate(string stringDate)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(stringDate);
            }
            catch
            {
                Console.WriteLine("Invalid swimmer record. Birth date is invalid:  ");
                throw;
            }
        }

        private int ValidateNumber(string stringNumber)
        {
            int intNumber = 0;
            try
            {
                intNumber = Convert.ToInt32(stringNumber);
            }
            catch
            {
            }
            return intNumber;
        }


        private Registrant CreateSwimmer()
        {
            Registrant aSwimmer = new Registrant();
            Add(aSwimmer);

            return aSwimmer;
        }

        public void Add(Registrant aSwimmer)
        {
            Swimmers.Add(aSwimmer);
            Number++;
            int i = 0;
            int trigger = 0;
            foreach (Club item in ClbMngr.Clubs)
            {
                if (aSwimmer.Club == item)
                    trigger = 1;
            }
            if (trigger == 0 && aSwimmer.Club != null)
            {
                ClbMngr.Add(aSwimmer.Club);
            }
        }
    }
}
