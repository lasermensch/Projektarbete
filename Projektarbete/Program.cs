using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Projektarbete
{
    class Program
    {
        static void StartGame()
        {
            DrawWalls();
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
                    Console.Write(map[x,y] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            StartGame();
        }
    }

    class Entities
    {
        public int Health;
        public int Strenght;
        //public int Armour;
        //public int Toughness;
        //public int Initiative;
        //public int Luck;

        //Attack method
    }

    class Player : Entities
    {
        //Backpack list
        //Eat method
    }
    class Enemy : Entities
    {

    }


}
