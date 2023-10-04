using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pokeyman
    {
        public string Name;
        public int Hp;
        public int Atk;
        public Pokeyman()
        {

        }
        public Pokeyman(string name, int HP, int atk)
        {
            Name = name;
            Hp = HP;
            Atk = atk;

        }
    }
}
