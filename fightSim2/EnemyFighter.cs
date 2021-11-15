using System;

namespace fightSim2
{
    public class EnemyFighter : Fighter
    {

        //Constructor
        public EnemyFighter()
        {
            hp = 100;

            strength = 2;

            isEnemy = true;
        }

    }
}