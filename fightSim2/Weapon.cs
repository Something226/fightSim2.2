using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
        //variables for Weapon class
        private Random generator = new Random();

        //public string name;
        //public string type;

        //method that randomizes damage
        public int Damage()
        {
            return generator.Next(1, 17);
        }

    }
}