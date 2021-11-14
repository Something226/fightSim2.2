using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
        /* Class description */
        /* Weapon class, used to modify or add damage to fighter */

        //variables for Weapon class
        private Random number = new Random();

        //public string name;
        //public string type;

        //method that randomizes damage
        public int Damage()
        {
            return number.Next(1, 17);
        }

    }
}