using System;

namespace fightSim2
{
    public class PlayerFighter : Fighter
    {
        //Class Description
        /* Player fighter class that inherits Fighter, is used as opponent to EnemyFighter */

        //Constructor, Defines variables
        public PlayerFighter()
        {
            hp = 100;

            strength = 2;

            isEnemy = false;
        }

    }
}