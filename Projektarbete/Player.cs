using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Player : Entities
    {

        List<string> Backpack = new List<string>();

        public int Eat(int currentHealth, int healthRegen)
        {
            currentHealth += healthRegen;
            return currentHealth;
        }
    }
}
