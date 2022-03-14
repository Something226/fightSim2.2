using System;

namespace fightSim2
{
    public class FightSequence
    {
        /* Class description */
        /* Class creates a sequence for a fight */

        //Method that loops the fight
        public void Fight(Fighter playerFighter, Fighter enemyFighter)
        {
            //Writeline tells user fight has been initiated
            Console.WriteLine(playerFighter.GetName() + " and " + enemyFighter.GetName() + " will now fight till death!");

            //Fight-loop
            while (playerFighter.GetAlive() && enemyFighter.GetAlive())
            {
                playerFighter.Attack(enemyFighter);

                Console.WriteLine(playerFighter.GetName() + " attacked " + enemyFighter.GetName() + " for " + playerFighter.GetDmgAmount() + ", " + enemyFighter.GetName() + " now has: " + enemyFighter.GetHP() + " HP");

                enemyFighter.Attack(playerFighter);

                Console.WriteLine(enemyFighter.GetName() + " attacked " + playerFighter.GetName() + " for " + enemyFighter.GetDmgAmount() + ", " + playerFighter.GetName() + " now has: " + playerFighter.GetHP() + " HP\nPress ENTER to continue");

                Console.ReadLine();

                Console.Clear();

            }

            //if-statments checks who won
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