using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Projektarbete
{
    class Enemy : Creature  
    {
        
        public Enemy(int health, int strength, int armour, int initiative, int luck, Point position, char repChar = '%'): base (health, strength, armour, initiative, luck, position, repChar)
        {
            this.RepChar = repChar;
        }


    }

}

