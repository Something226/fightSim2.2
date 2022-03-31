using System;

namespace fightSim2
{
    public class FightSequence
    {
        /* Class description */
        /* Class creates a sequence for a fight */

        //Fight-method, takes two fighter classes
        public void Fight(Fighter playerFighter, Fighter enemyFighter)
        {
            //Writeline tells user fight has been initiated
            Console.WriteLine(playerFighter.GetName() + " and " + enemyFighter.GetName() + " will now fight to the death!");

            //Fight-loop, both Fighter-classes attack each other ones per cycle of Fight-loop, if one Fighter's HP reaches 0, GetAlive = False = Loop ends
            while (playerFighter.GetAlive() && enemyFighter.GetAlive())
            {
                playerFighter.Attack(enemyFighter);

                Console.WriteLine(playerFighter.GetName() + " attacked " + enemyFighter.GetName() + " for " + playerFighter.GetDmgAmount() + ", " + enemyFighter.GetName() + " now has: " + enemyFighter.GetHP() + " HP");

                enemyFighter.Attack(playerFighter);

                Console.WriteLine(enemyFighter.GetName() + " attacked " + playerFighter.GetName() + " for " + enemyFighter.GetDmgAmount() + ", " + playerFighter.GetName() + " now has: " + playerFighter.GetHP() + " HP\nPress ENTER to continue");

                Console.ReadLine();

                Console.Clear();

            }

            //if-statments tells player who won the fight
            if (!enemyFighter.GetAlive() && !playerFighter.GetAlive())
            {
                Console.WriteLine("It's a draw!");
            }
            else if (!playerFighter.GetAlive())
            {
                Console.WriteLine(enemyFighter.GetName() + " won!");
            }
            else if (!enemyFighter.GetAlive())
            {
                Console.WriteLine(playerFighter.GetName() + " won!");
            }




        }


    }
}