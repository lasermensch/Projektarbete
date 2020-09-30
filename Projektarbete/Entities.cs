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

        public int Attack(int damage)
        {
            return damage;
        }
    }


}
