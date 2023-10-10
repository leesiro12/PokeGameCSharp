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
        public Trainer trainerPlayer=new Trainer();
        public Trainer trainer1;
        bool isPlaying = true;
        bool inBattle = false;
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
                    trainerPlayer.playerParty.Add(ChoosePokemon());
                }
                else if (inp == "2")
                {
                    if (trainerPlayer.playerParty.Count == 0)
                    {
                        Console.WriteLine("You have no PKMN");
                    }

                    foreach (Pokeyman item in trainerPlayer.playerParty)
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
                else if (inp == "3" && trainerPlayer.playerParty.Count != 0)
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
            trainerPlayer.trainerPKMN = trainerPlayer.playerParty[0];
            Console.WriteLine(trainer1.trainerName + " has challenged you to a PKMN battle");
            Console.WriteLine(trainer1.trainerName + " sent out " + trainer1.trainerPKMN.Name + " | HP: " + trainer1.trainerPKMN.Hp);
            Console.WriteLine("Go "+ trainerPlayer.playerParty[0].Name);
            inBattle = true;

            while (inBattle)
            {
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    trainerPlayer.playerParty[0].PokeyAtk(trainer1.trainerPKMN);
                    trainer1.trainerPKMN.PokeyHurty(trainerPlayer.playerParty[0].Atk);
                    Console.WriteLine(trainer1.trainerPKMN.Name + " | HP: " + trainer1.trainerPKMN.Hp);
                    if (trainer1.trainerPKMN.Hp <= 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(trainer1.trainerName + " has been defeated.");
            inBattle = false;
            trainer1.trainerPKMN.Hp = 10;
            return null;
        }
        
    }
}


