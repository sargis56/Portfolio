//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A2
//File Name: SwimmersManager.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class SwimmersManager
    {
        private int numberOfSwimmers;
        private Registrant[] swimmers = new Registrant[99];

        private ClubsManager aParameter1;

        public SwimmersManager(ClubsManager Parameter1)
        {
            this.AParameter1 = Parameter1;
        }

        public ClubsManager AParameter1
        {
            set
            {
                aParameter1 = value;
            }
            get
            {
                return aParameter1;
            }
        }

        public int NumberOfSwimmers
        {
            set
            {
                numberOfSwimmers = value;
            }
            get
            {
                return numberOfSwimmers;
            }
        }

        public Registrant[] Swimmers
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

        public void AddSwimmer(Registrant aSwimmer)
        {
            //swimmers[numberOfSwimmers] = aSwimmer;
            //numberOfSwimmers++;

            int countMatchs = 0;
            for (int i = 0; i < numberOfSwimmers; i++)
            {
                if (swimmers[i].RegistNum == aSwimmer.RegistNum)
                {
                    countMatchs++;
                    throw new Exception("Invalid swimmer record. Swimmer with the registration number already exists: " + aSwimmer.RegistNum + "," + aSwimmer.Name + "," + aSwimmer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt") + "," + aSwimmer.Address.AddressStreet + "," + aSwimmer.Address.City + "," + aSwimmer.Address.Province + "," + aSwimmer.Address.Postal + "," + aSwimmer.PhoneNumber + "," + aSwimmer.ClubRegNumber);
                }
            }

            if (countMatchs == 0)
            {
                swimmers[numberOfSwimmers] = aSwimmer;
                numberOfSwimmers++;
            }
        }

        public Registrant GetSwimmer(uint regNumber)
        {
            Registrant correctReg = null;
            for (int i = 0; i < numberOfSwimmers; i++)
            {
                if (swimmers[i].RegistNum == regNumber)
                {
                    correctReg = swimmers[i];
                }
            }

            return correctReg;
        }

        public void LoadSwimmers(string fileName, string delimiter)
        {
            char delim = Convert.ToChar(delimiter);
            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields = new string[20];

            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(delim);

                int regNum;
                DateTime dateTime;
                uint phoneNum;
                fields = recordIn.Split(delim);
                try
                {
                    if ((int.TryParse(fields[0], out regNum)) && (DateTime.TryParse(fields[2], out dateTime)) && (uint.TryParse(fields[7], out phoneNum)) && (fields[1] != ""))
                    {
                        AddSwimmer(new Registrant(regNum, fields[1], dateTime, new Address(fields[3], fields[4], fields[5], fields[6]), phoneNum, fields[8]));
                    }
                    else if ((int.TryParse(fields[0], out regNum) == false))
                    {
                        throw new Exception("Invalid swimmer record. Invalid registration number: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8]);
                    }
                    else if ((DateTime.TryParse(fields[2], out dateTime) == false))
                    {
                        throw new Exception("Invalid swimmer record. Burth date is invalid: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8]);
                    }
                    else if ((uint.TryParse(fields[7], out phoneNum) == false))
                    {
                        throw new Exception("Invalid swimmer record. Phone number wrong format: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8]);
                    }
                    else if (fields[1] == "")
                    {
                        throw new Exception("Invalid swimmer record. Invalid swimmer name: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }

        public void SaveSwimmers(string fileName, string delimiter)
        {
            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            for (int i = 0; i < numberOfSwimmers; i++)
            {
                writer.WriteLine(swimmers[i].RegistNum + delimiter + swimmers[i].Name + delimiter + swimmers[i].DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt") + delimiter + swimmers[i].Address.AddressStreet + delimiter
                    + swimmers[i].Address.City + delimiter + swimmers[i].Address.Province + delimiter + swimmers[i].Address.Postal + delimiter + swimmers[i].PhoneNumber + delimiter + swimmers[i].ClubRegNumber);
            }


            writer.Close();
            outFile.Close();
        }
    }
}
