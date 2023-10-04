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
            bool isPlaying = true;
            List<Pokeyman> playerParty = new List<Pokeyman>();
            

            while (isPlaying)
            {
                Console.WriteLine("Welcome to PokeC#! Type '1' to play Game, '2' to check party. Type '4' to exit program");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    playerParty.Add(ChoosePokemon());
                }
                else if (inp == "2")
                {
                    foreach (Pokeyman item in playerParty)
                    {
                        Console.WriteLine("You have: " + item.Name + " | HP:" + item.Hp);
                    }
                }
                else if (inp == "4")
                {
                    isPlaying = false;
                }
                else
                {
                    Console.WriteLine("Choose a valid option");
                }

            }
        }
        private static Pokeyman ChoosePokemon()
        {
            Console.WriteLine("Choose your starter: '1' for Bulbasaur, '2' for Charmander, '3' for Squirtle, '4' to return.");
            string inp = Console.ReadLine();
           
            switch (inp)
            {
                case "1":
                    Console.WriteLine("You chose 'Bulbasaur'");
                    return new GrassMon("Bulbasaur", 5, 5);
                    break;
                case "2":
                    Console.WriteLine("You chose 'Charmander'");
                    return new FireMon("Charmander", 5, 5);
                    break;
                case "3":
                    Console.WriteLine("You chose 'Squirtle'");
                    return new WaterMon("Squirtle", 5, 5);
                    break;
                default:
                    return null;
                    break;
            }
        }

    
    }
}


