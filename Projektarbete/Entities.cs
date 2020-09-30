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

        

        public int Attack(int strength, int armour)
        {
            int damage = armour - strength; //Så att någonting händer baserat på armour och strength. 
            return damage;
        }
    }


}
