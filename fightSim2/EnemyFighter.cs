using System;

namespace fightSim2
{
    public class EnemyFighter : Fighter
    {
        //Class Description
        /* Enemy fighter class that inherits Fighter, is used as opponent to PlayerFighter */

        //Constructor, defines variables
        public EnemyFighter()
        {
            hp = 100;

            strength = 2;

            isEnemy = true;
        }

    }
}