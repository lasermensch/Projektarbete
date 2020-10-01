namespace Projektarbete
{
    class Entities
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Armour { get; set; }
        public int Toughness { get; set; }
        public int Initiative { get; set; }
        public int Luck { get; set; }

        

        public int Punch(int health, int strength, int armour)
        {
            health = Health;
            strength = Strength;
            armour = Armour;

            int damage = health + armour - strength; //Så att någonting händer baserat på armour och strength. 
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

        public int Eat(int currentHealth, int healthRegen) //Funktion för att beräkna nytt Health värde efter spelaren/fienden har blivit skadad.
        {
            currentHealth += healthRegen;
            return currentHealth;
        }
    }


}
