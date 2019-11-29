using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IClubsRepository
    {
        List<Club> Clubs { get; set; }
        int Number { get; set; }

        void Add(Club aClub);
        Club GetByRegNum(uint regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}