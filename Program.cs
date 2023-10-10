using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {


        public static void Main(string[] args)
        {
            game game1 = new game();

        }
    }
    public class game
    {
        public Trainer trainer1;
        bool isPlaying = true;
        public game()
        {
            trainer1 = new Trainer("Prime", new Pokeyman("Rattata", 10, 3));

            startGame();

        }
        public void startGame()
        {
            while (isPlaying)
            {
                Console.WriteLine("Welcome to PokeC#! Type '1' to play Game, '2' to check party, '3' to battle. Type '4' to exit program");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    trainer1.playerParty.Add(ChoosePokemon());
                }
                else if (inp == "2")
                {
                    if (trainer1.playerParty.Count == 0)
                    {
                        Console.WriteLine("You have no PKMN");
                    }

                    foreach (Pokeyman item in trainer1.playerParty)
                    {
                        Console.WriteLine("You have: " + item.Name + " | HP:" + item.Hp);
                        if (item is FireMon)
                        {
                            Console.WriteLine("Move: Flamethrower");
                        }
                        else if (item is WaterMon)
                        {
                            Console.WriteLine("Move: Water Pulse");
                        }
                        else if (item is GrassMon)
                        {
                            Console.WriteLine("Move: Energy Ball");
                        }
                    }
                }
                else if (inp == "3" && trainer1.playerParty.Count != 0)
                {
                    EngageInBattle();
                }
                else if (inp == "4")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Choose a valid option");
                }

            }
        }
        private Pokeyman ChoosePokemon()
        {
            Console.WriteLine("Choose your starter: '1' for Bulbasaur, '2' for Charmander, '3' for Squirtle, '4' to return.");
            string inp = Console.ReadLine();

            switch (inp)
            {
                case "1":
                    Console.WriteLine("You chose 'Bulbasaur'");
                    return new GrassMon("Bulbasaur", 14, 6);
                //break;
                case "2":
                    Console.WriteLine("You chose 'Charmander'");
                    return new FireMon("Charmander", 13, 7);
                //break;
                case "3":
                    Console.WriteLine("You chose 'Squirtle'");
                    return new WaterMon("Squirtle", 16, 4);
                //break;
                default:
                    return null;
                    //break;
            }
        }
        private Battle EngageInBattle()
        {
            trainer1.trainerPKMN = trainer1.playerParty[0];
            Console.WriteLine(trainer1.trainerName + " has challenged you to a PKMN battle");
            Console.WriteLine(trainer1.trainerName + " sent out " + trainer1.trainerPKMN.Name + " | HP: " + trainer1.trainerPKMN.Hp);
            Console.WriteLine("Go ");
            return null;
        }
    }
}


