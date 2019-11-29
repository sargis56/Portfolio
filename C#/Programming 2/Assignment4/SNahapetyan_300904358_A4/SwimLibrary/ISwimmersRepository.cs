using SwimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicSwimLibrary
{
    interface ISwimmersRepository
    {
        Registrant Get(int regNumber);
        void Load(string fileName, string delimeter);
        int Number { set; get; }
        void Save(string fileName, string delimeter);
        void Add(Registrant aClub);
    }
}
