using System;
using System.Drawing;

namespace Projektarbete
{
    class Creature
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Armour { get; set; }
        public int Toughness { get; set; }
        public int Initiative { get; set; }
        public int Luck { get; set; }
        public Point position { get; set; } //Så att varje föremål och fiende har en fix plats på i världen.
        

        public int Punch(int health, int strength, int armour)
        {
            health = Health;
            strength = Strength;
            armour = Armour;

            int damage = health + armour - strength; //Så att någonting händer baserat på armour och strength. 
            return damage;
        }
        public int Punch(Random rng, int armour) //Modifierad metod.
        {
            int damage = 0;
            int luckModifier = rng.Next(-3 + Luck, 0);
            damage = luckModifier + Strength - armour;
            if (damage < 1)
                damage = 0;
            return damage;
        }

        public int Kick(int health, int strenght, int armour)
        {
            health = Health;
            strenght = Strength;
            armour = Armour;

            int damage = health + armour - (strenght + 2);//Lägger till mer skada vid Kick funktionen.
            return damage;
        }

    }


}
