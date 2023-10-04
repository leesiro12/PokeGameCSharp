using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokeyman poke1 = new GrassMon("bulbasaur", 5, 5);
            Pokeyman poke2 = new WaterMon("squirtle", 5, 5);
            Pokeyman poke3 = new FireMon("charmander", 5, 5);

            bool isPlaying = true;
            while (isPlaying)
            {
                Console.WriteLine("Welcome to PokeC#! Type '1' to play Game. Type '4' to exit program");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    Console.WriteLine("Choose your starter: 1 for Bulbasaur, 2 for Charmander, 3 for Squirtle");
                    inp = Console.ReadLine();
                    switch (inp)
                    {
                        case "1":
                            Console.WriteLine("You chose 'Bulbasaur'");
                            break;
                        case "2":
                            Console.WriteLine("You chose 'Charmander'");
                            break;
                        case "3":
                            Console.WriteLine("You chose 'Squirtle'");
                            break;
                        default:
                            break;
                    }
                }
                else if (inp == "4")
                {
                    break;
                }
            }
        }
    }
}
