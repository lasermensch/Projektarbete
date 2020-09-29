using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new int[10, 10];

            int height = map.GetLength(0);
            int width = map.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("x" + " ");
                }
                Console.Write(Environment.NewLine);
            }
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
