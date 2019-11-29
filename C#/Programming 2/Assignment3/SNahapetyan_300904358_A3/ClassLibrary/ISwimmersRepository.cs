using System.Collections.Generic;

namespace ClassLibrary
{
    public interface ISwimmersRepository
    {
        ClubsManager AParameter1 { get; set; }
        int Number { get; set; }
        List<Registrant> Swimmers { get; set; }

        void Add(Registrant aSwimmer);
        Registrant GetByRegNum(uint regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}