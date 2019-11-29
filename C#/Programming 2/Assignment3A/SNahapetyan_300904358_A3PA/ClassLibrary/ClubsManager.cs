//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3PA
//File Name: ClubsManager.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class ClubsManager
    {
        private Club[] clubs = new Club[99];
        private int numberOfClubs = 0;

        public ClubsManager()
        {

        }

        public Club[] Clubs
        {
            set
            {
                clubs = value;
            }
            get
            {
                return clubs;
            }
        }

        public int NumberOfClubs
        {
            set
            {
                numberOfClubs = value;
            }
            get
            {
                return numberOfClubs;
            }
        }

        public void AddClub(Club aClub)
        {
            int countMatchs = 0;
            for (int i = 0; i < numberOfClubs; i++)
            {
                if (clubs[i].ClubRegistNum == aClub.ClubRegistNum)
                {
                    countMatchs++;
                    throw new Exception("Invalid club record. Club with the registration number already exists: " + aClub.ClubRegistNum + "," + aClub.Name + "," + aClub.ClubAddress.AddressStreet + "," + aClub.ClubAddress.City + "," + aClub.ClubAddress.Province + "," + aClub.ClubAddress.Postal + "," + aClub.PhoneNumber);
                }
            }

            if (countMatchs == 0)
            {
                clubs[numberOfClubs] = aClub;
                numberOfClubs++;
            }

        }

        public Club GetClub(uint regNumber)
        {
            Club correctClub = null;
            for (int i = 0; i < numberOfClubs; i++)
            {
                if (clubs[i].ClubRegistNum == regNumber)
                {
                    correctClub = clubs[i];

                }
            }

            return correctClub;

        }

        public void LoadClubs(string fileName, string delimiter)
        {
            char delim = Convert.ToChar(delimiter);
            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;

            recordIn = reader.ReadLine();

            // this is the problem
            while (recordIn != null)
            {
                uint regNum;
                uint phoneNum;
                fields = recordIn.Split(delim);
                try
                {
                    if (uint.TryParse(fields[0], out regNum) && (uint.TryParse(fields[6], out phoneNum)))
                    {
                        AddClub(new Club(regNum, fields[1], new Address(fields[2], fields[3], fields[4], fields[5]), phoneNum));
                    }
                    else if ((uint.TryParse(fields[0], out regNum) == false))
                    {
                        throw new Exception("Invalid club record Club number is not valid: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }
                    else if ((uint.TryParse(fields[6], out phoneNum) == false))
                    {
                        throw new Exception("Invalid club record. Phone number wrong format: " + fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
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

        public void SaveClubs(string fileName, string delimiter)
        {
            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            for (int i = 0; i < numberOfClubs; i++)
            {
                //GetClub(clubs[i].ClubRegistNum);

                writer.WriteLine(clubs[i].ClubRegistNum + delimiter + clubs[i].Name + delimiter + clubs[i].ClubAddress.AddressStreet + delimiter
                    + clubs[i].ClubAddress.City + delimiter + clubs[i].ClubAddress.Province + delimiter + clubs[i].ClubAddress.Postal + delimiter + clubs[i].PhoneNumber);
            }

            //writer.WriteLine("hello world");

            writer.Close();
            outFile.Close();
        }
    }

}
