using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace Projektarbete
{
    class Program
    {

        static void Main(string[] args)
        {
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

            PlayerMovement(world);
        }

        static void PlayerMovement(World world) //Kodstycke som säger åt konsolen hur "spelaren" rör sig runt på spelplanen.
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

                Map[y, x] = player;
                
                Console.SetCursorPosition(x, y);
                
                Console.Write(Map[y, x]);
            }

        }
    }
}

