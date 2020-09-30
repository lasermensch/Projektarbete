using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace Projektarbete
{
    class Program
    {

        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            DrawWalls();
            DrawPlayer();
        }

        static void DrawWalls()
        {
            var map = new char[30, 30];
            int height = map.GetLength(0);
            int width = map.GetLength(1);

            for (int i = 0; i < height - 1; i++)
            {
                map[i, 0] = '.';
                map[i, height - 1] = '.';
                for (int j = 0; j < width - 1; j++)
                {
                    map[0, j] = '.';
                    map[width - 1, j] = '.';
                }
            }

            map[29, 29] = '.';

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write(map[x, y] + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        static void DrawPlayer()
        {
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
