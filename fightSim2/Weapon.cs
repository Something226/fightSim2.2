using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Weapon
    {
        public Random generator = new Random();

        public int dmg;

        public string name;
        public string type;

        public int Damage()
        {
            return generator.Next(2, 4);
        }

    }
}