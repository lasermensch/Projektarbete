namespace Projektarbete
{
    class Entities
    {
        public int Health { get; set; }
        public int Strenght { get; set; }
        //public int Armour;
        //public int Toughness;
        //public int Initiative;
        //public int Luck;

        //items
        public int apple = 2;
        public int orange = 4;
        public int Pear = 7;

        public int Attack(int damage)
        {
            return damage;
        }
    }


}
