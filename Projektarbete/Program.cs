using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace Projektarbete
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 60);
            World world = new World(30, 60);
            world.GeneratePositions(10);

            world.PrintWorld();
            StartGame(world);
            Console.ReadKey();
        }
        static void StartGame(World world)
        {
            InstantiatePlayer(world);
            
        }

        static void InstantiatePlayer(World world)
        {
            var character = new Player(); //Exempel på instans av spelare, värden kan ändras efter behov.
            character.Health = 10;
            character.Strength = 2;
            character.Armour = 4;

            PlayerMovement(world, character);
        }

        

        static void PlayerMovement(World world, Player character) //Kodstycke som säger åt konsolen hur "spelaren" rör sig runt på spelplanen.
        {

            var Map = world.Map;
            int Width = Map.GetLength(1);
            int Height = Map.GetLength(0);
            char player = '¤';

            int x = Width / 2;
            int y = Height / 2;
            Map[y, x] = player;


            while (true)
            {
                Map[y, x] = '.';
                Tuple<int, int> temp = new Tuple<int, int>(x, y); //Lagra koordinaten, utifall fienden inte besegras.
                Console.SetCursorPosition(x, y);
                var command = Console.ReadKey(true).Key;
                Console.Write(Map[y, x]);
                

                switch (command)
                {
                    case ConsoleKey.RightArrow:
                        if (x < Width - 2)
                            x++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                            x--;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                            y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Height - 2)
                            y++;
                        break;
                    default:
                        break;
                }
                if (Map[y, x] != '.')
                {
                    Entities entity = world.ListOfItemsAndEnemies.Find(e => (e.position.X == x && e.position.Y == y));
                    bool pass = Meet(character, entity, out bool hasFought);
                    if (hasFought) 
                    {
                        Thread.Sleep(1500);
                        Console.Clear();
                        world.PrintWorld();
                    }
                    if (!pass)
                    {
                        x = temp.Item1;
                        y = temp.Item2;
                        continue;
                    }
                }
                Map[y, x] = player;

                Console.SetCursorPosition(x, y);

                Console.Write(Map[y, x]);
            }

        }
        static bool Meet(Player player, Entities entity, out bool hasFought)
        {
            hasFought = false;
            bool pass = false;
            if (entity.GetType().ToString().EndsWith("Enemy"))
            {
                if (Fight(player, entity as Enemy))
                    pass = true;

                hasFought = true;
            }
            else
            {
                player.PickUp(entity as Item);
                pass = true;
            }
            return pass;

        }
        static bool Fight(Player player, Enemy enemy)
        {
            int counter = 1;
            Random rng = new Random();
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.Clear();

                Console.WriteLine($"Round: {counter}" +
                                   $"\nYou have {player.Health} in health!" +
                                   $"\nYour enemy has {enemy.Health} in health");
                Console.WriteLine("Choose your action: \n1. Punch \n2. Kick \n3. Flee");
                while (true)
                {
                    ConsoleKey choice = Console.ReadKey(true).Key;

                    if (choice == ConsoleKey.D1 || choice == ConsoleKey.D2)
                    {
                        int damage = 0;
                        string attackType = "";
                        if (choice == ConsoleKey.D1)
                        { damage = player.Punch(rng, enemy.Armour); attackType = "punch"; }
                        else
                        { damage = player.Kick(rng, enemy.Armour); attackType = "kick"; }

                        enemy.Health -= damage;
                        Console.WriteLine($"You {attackType} the enemy, doing {damage} in damage!");

                        while (true)
                        {
                            Thread.Sleep(200);
                            if (enemy.Health > 0)
                            {
                                damage = enemy.Punch(rng, player.Armour);
                                player.Health -= damage;
                                Console.WriteLine($"The dastardly foe has punched you, inflicting {damage} in damage on you!");
                                if (attackType == "kick")
                                { attackType = ""; continue; }
                                else
                                    break;
                            }
                            else
                                break;
                        }
                        counter++;
                        break;
                    }

                    else if (choice == ConsoleKey.D3)
                    {
                        if (player.Initiative + rng.Next(1, 7) > enemy.Initiative + rng.Next(1, 7))
                        {
                            Console.WriteLine("You have managed to flee!");
                            Thread.Sleep(1500);
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("You did not manage to flee! The fight continues");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose 1 or 2");
                    }
                }
                Thread.Sleep(1500);
            }
            //Console.SetCursorPosition(0, 32); //Så att den inte skriver ut meddelandet på kartan!
            if (player.Health > 0)
            { Console.WriteLine("You have bested your foe!"); return true; }
            else
            { Console.WriteLine("You have died in shame from a mere punch!"); return false; }

        }
    }
}

