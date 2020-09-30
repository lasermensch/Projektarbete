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
            World world = new World(30, 30);
            world.GeneratePositions(10);

            world.PrintWorld();
            StartGame();
            Console.ReadKey();
        }
        static void StartGame()
        {
            InstantiatePlayer();
        }

        static void InstantiatePlayer()
        {
            var character = new Player();
            character.Health = 10;
            character.Strength = 2;
            
            PlayerMovement();
        }

        static void PlayerMovement()
        {
            var map = new char[30, 30];

            char player = '¤';

            Point playPos = new Point(15, 15);
            map[playPos.X, playPos.Y] = player;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.Write(Environment.NewLine);
            }

            while (true)
            {
                map[playPos.X, playPos.Y] = '#';

                Console.SetCursorPosition(playPos.X, playPos.Y);
                var command = Console.ReadKey(true).Key;
                Console.Write(map[playPos.X, playPos.Y]);


                switch (command)
                {

                    case ConsoleKey.LeftArrow:
                        playPos.X--;
                        break;
                    case ConsoleKey.UpArrow:
                        playPos.Y--;
                        break;
                    case ConsoleKey.RightArrow:
                        playPos.X++;
                        break;
                    case ConsoleKey.DownArrow:
                        playPos.Y++;
                        break;
                    default:
                        break;
                }

                map[playPos.X, playPos.Y] = player;

                Console.SetCursorPosition(playPos.X, playPos.Y);

                Console.Write(map[playPos.X, playPos.Y]);

            }
        }
    }
}
