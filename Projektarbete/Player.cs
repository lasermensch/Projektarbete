using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Player : Creature
    {
        List<Item> Backpack = new List<Item>();

        public void PickUp(Item item)
        {
            Backpack.Add(item);
        }
        public int Punch(Random rng, int armour)
        { 
            int damage = 0;
            int luckModifier = rng.Next(-3 + Luck, 0);
            damage = luckModifier + Strength - armour;
            if (damage < 1)
                damage = 0;
            return damage;
        }
        public int Kick(Random rng, int armour)
        {
            int damage = 0;
            int luckModifier = rng.Next(-3 + Luck, 0);
            damage = luckModifier + (Strength * 3 / 2) - armour;
            if (damage < 1)
                damage = 0;
            return damage;
        }

        public int Eat(int currentHealth, int healthRegen) //Funktion för att beräkna nytt Health värde efter spelaren/fienden har blivit skadad.
        {
            currentHealth += healthRegen;
            return currentHealth;
        }
    }
}
