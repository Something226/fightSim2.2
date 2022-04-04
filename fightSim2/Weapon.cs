using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
        /* Class description */
        /* Weapon class, used to modify or add damage to fighter, Currently decides damage of Fighter */

        //variables for Weapon class
        private Random number = new Random();

        //public string name;
        //public string type;

        //Method that randomizes damage
        public int Damage()
        {
            return number.Next(1, 17);
        }

    }
}