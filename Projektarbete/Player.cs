using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Player : Entities
    {

        List<string> Backpack = new List<string>();

        public int Eat(int currentHealth, int healthRegen) //Funktion för att beräkna nytt Health värde efter spelaren har blivit skadad.
        {
            currentHealth += healthRegen;
            return currentHealth;
        }
    }
}
