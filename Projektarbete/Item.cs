using System;
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

        //Consumable items
        public string apple { get; set; }
        public string orange { get; set; }
        public string pear { get; set; }
        public string banana { get; set; }

        //Passive items
        public string sword { get; set; }
        public string knife { get; set; }
        public string shield { get; set; }

        //Värden för items.
        public string Name { get; set; }

        public int HealthBoost;

        public int StrenghtBoost;

        public int DefenseBoost;

        //Konstruktor för items.
        public Item(string name, int healthboost, int strenghtboost, int defenseboost)
        {
            name = Name;
            healthboost = HealthBoost;
            strenghtboost = StrenghtBoost;
            defenseboost = DefenseBoost;
        }
    }
}
