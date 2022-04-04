using System;

namespace fightSim2
{
    public class FightSequence
    {
        /* Class description */
        /* Class creates a sequence for a fight, will be used by player to progress their fighter and allow for custom battles */

        //Fight-method, takes two fighter classes
        public void Fight(Fighter playerFighter, Fighter enemyFighter)
        {
            //Writeline tells user fight has been initiated, Fighter.GetName used to display names of fighters to user
            Console.WriteLine(playerFighter.GetName() + " and " + enemyFighter.GetName() + " will now fight to the death!");

            //Fight-loop, both Fighter-classes attack each other ones per cycle of Fight-loop, if one Fighter's HP reaches 0, Fighter.GetAlive = False = Loop ends
            while (playerFighter.GetAlive() && enemyFighter.GetAlive())
            {
                playerFighter.Attack(enemyFighter);

                Console.WriteLine(playerFighter.GetName() + " attacked " + enemyFighter.GetName() + " for " + playerFighter.GetDmgAmount() + ", " + enemyFighter.GetName() + " now has: " + enemyFighter.GetHP() + " HP");

                enemyFighter.Attack(playerFighter);

                Console.WriteLine(enemyFighter.GetName() + " attacked " + playerFighter.GetName() + " for " + enemyFighter.GetDmgAmount() + ", " + playerFighter.GetName() + " now has: " + playerFighter.GetHP() + " HP\nPress ENTER to continue");

                Console.ReadLine();

                Console.Clear();

            }

            //if-statments tells player who won the fight, Dependant on Fighter.GetAlive()
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