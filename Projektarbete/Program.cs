using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tjena tjena");
            Console.WriteLine("All your base are belong to us!");
            //Det funkar niceeeeeee
            Console.WriteLine("hej");
            Console.WriteLine("testar igen");
        }
    } //André testar läggga till en kommentar

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
