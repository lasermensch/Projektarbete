﻿using System.Collections.Generic;
using System.Drawing;

namespace Projektarbete
{
    class Player : Creature
    {
        public List<Item> Backpack { get; protected set; }

        public Player (int health, int strength, int armour, int initiative, int luck, Point position, char repChar = '¤'): base (health, strength, armour, initiative, luck, position, repChar)
        {
            Backpack = new List<Item>();

        }
        public void PickUp(Item item)
        {
            Backpack.Add(item);
        }
    }
}
