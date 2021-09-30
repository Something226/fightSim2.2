using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
        private Random generator = new Random();

        public string name;
        public string type;

        public int Damage()
        {
            return generator.Next(1, 17);
        }

    }
}