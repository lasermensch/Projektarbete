using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Projektarbete
{
    class Enemy : Creature  
    {
        public Enemy()
       {
            Health = 15;
            Strength = 1;
            Armour = 2;

            List<int> listOfEnemies = new List<int>();


            //Kan vara användbart i framtiden, skapar en lista med 10st objekt av klassen Enemy.
            for (int i = 0; i < listOfEnemies.Count + 1; i++)
            {
                var enemy = new Creature();
            }



        }


    }

}

