using System;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace Projektarbete
{
    class Item : Entity
    {
        public static int ConsumeItem(int currentHealth, int healthRegen) //Skicka in Player.Health och värdet hpBoost som consumablen har.
        {
            currentHealth += healthRegen;
            return currentHealth;
        }

        
        //Värden för items.

        public int HealthBoost { get; protected set; }

        public int StrenghtBoost { get; protected set; }

        public int DefenseBoost { get; protected set; }

        //Konstruktor för items.
        public Item(string name, int healthboost, int strenghtboost, int defenseboost, Point position, char repChar = '@'):base (repChar, position)
        {
            Name = name;
            HealthBoost = healthboost;
            StrenghtBoost = strenghtboost;
            DefenseBoost = defenseboost;    
        }
    }
}
