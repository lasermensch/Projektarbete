using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new Exception();
        }
    }

    class Entities
    {
        public int Health;
        public int Strenght;
        public int Armour;
        public int Toughness;
        public int Initiative;
    }

    class Player : Entities
    {
        //Backpack list
    }
    class Enemy : Entities
    {

    }


}
