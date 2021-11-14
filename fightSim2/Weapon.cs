using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
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