using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Projektarbete
{
    class Player : Creature
    {
        public List<Item> Backpack { get; protected set; }
        public Item EquippedWeapon { get; protected set; }
        public Item EquippedArmour { get; protected set; }
        


        public Player (int health, int strength, int armour, int initiative, int luck, Point position, char repChar = '¤'): base (health, strength, armour, initiative, luck, position, repChar)
        {
            Backpack = new List<Item>();
            Point p = new Point(-1, -1);
            EquippedWeapon = new Item(" ", 0, 0, 0, p);
            EquippedArmour = EquippedWeapon;
        }
        public void PickUp(Item item)
        {
            Backpack.Add(item);
        }
        public void UseItem(int index)
        {
            index--; //Så att om man väljer 1, så kommer man att välja första föremålet i listan. Annars måste man välja 0.
            string itemName = Backpack[index].Name;
            switch(itemName)
            {
                case "apple":
                case "banana":
                case "orange":
                case "pear":
                    Health += Backpack[index].HealthBoost;
                    Backpack.RemoveAt(index);
                    break;
                case "shield":
                    Armour -= EquippedArmour.DefenseBoost;
                    EquippedArmour = Backpack.ElementAt(index);
                    Armour += EquippedArmour.DefenseBoost;
                    break;
                case "sword":
                case "dagger":
                    Strength -= EquippedWeapon.StrenghtBoost;
                    EquippedWeapon = Backpack.ElementAt(index);
                    Strength += EquippedWeapon.StrenghtBoost;
                    break;
                default:
                    break;
            }

        }
        public void displayBackpack()
        {
            int i = 0;
            Console.SetCursorPosition(63, i);
            Console.WriteLine("Backpack: ");
            foreach (var item in Backpack)
            {
                i++;
                Console.SetCursorPosition(63, i);
                Console.WriteLine(item.Name);
                
            }
        }

        

    }
}
