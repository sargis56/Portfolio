using OlimpicSwimLibrary;
using SwimLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public class ClubsManager: IClubsRepository
    {
        public  List<Club> Clubs;
        public int Number { set; get; }
        private SwimmersManager swimmerManager;


        public ClubsManager()
        {
            Clubs = new List<Club>();
            SwimmerManager = new SwimmersManager(this);
        }


        public SwimmersManager SwimmerManager
        {
            get
            {
                return swimmerManager;
            }

            set
            {
                swimmerManager = value;
            }
        }

        public void Load(string fileName, string delimeter)
        {

            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                try
                {
                    fields = recordIn.Split(delimeter[0]);
                    Club aClub = new Club();


                    try
                    {
                        if (fields[0] == "")
                            throw new Exception(string.Format("Invalid club record. Registration number is missing: "));
                        if (fields[1] == "")
                            throw new Exception(string.Format("Invalid club record. Club name is missing: "));
                        if (fields[6] == "")
                            throw new Exception(string.Format("Invalid club record. Phone number is missing: "));
                    }
                    catch
                    {
                        throw;
                    }

                    int idNumber;
                    idNumber = Convert.ToInt32(fields[0]);
                    for (int i = 0; i < Number; i++)
                    {
                        if (idNumber == Clubs[i].ClubNumber)
                        {

                            throw new Exception("Invalid club record. Club with the registration number already exists: ");

                        }
                    }
                    try
                    {
                        aClub.ClubNumber = Convert.ToInt32(fields[0]);
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Invalid club record Club number is not valid:"));
                    }
                    aClub.ClubName = fields[1];
                    aClub.Adress = new Address(fields[2], fields[3], fields[4], fields[5]);
                    try
                    {
                        aClub.ClubPhone = Convert.ToInt64(fields[6]);
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Invalid club record. Phone number wrong format:"));
                    }
                    Add(aClub);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{1} \n\t{0}", recordIn, e.Message);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();


        }

        public void Save(string fileName, string delimeter)
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                for (int i = 0; i < Number; i++)
                {
                    writer.WriteLine(Clubs[i].ClubNumber + delimeter + Clubs[i].ClubName + delimeter + Clubs[i].Adress.Street + delimeter + Clubs[i].Adress.City + delimeter + Clubs[i].Adress.Province + delimeter + Clubs[i].Adress.Zip + delimeter + Clubs[i].ClubPhone);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (writer != null) writer.Close();
                if (outFile != null) outFile.Close();
            }
        }


        public Club Get(int regNumber)
        {
            Club returnValue = null;

            for (int i = 0; i < Number; i++)
            {
                if (Clubs[i].ClubNumber == regNumber)
                    returnValue = Clubs[i];
            }

            return returnValue;
        }

        public void Add(Club aClub)
        {
            Clubs.Add(aClub);
            Number++;
        }

    }
}
