using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Trainer
    {
        public string trainerName;
        public Pokeyman trainerPKMN;
        public List<Pokeyman> playerParty = new List<Pokeyman>();
        public Trainer()
        {

        }
        public Trainer(string name, Pokeyman pkmn)
        {
            trainerName = name;
            trainerPKMN = pkmn;
        }
    }
}
