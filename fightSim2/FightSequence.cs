using System;

namespace fightSim2
{
    public class FightSequence
    {   
    /* Class description */
    /* Class creates a sequence for the fight */

        //Method that loops the fight
        public void Fight(Fighter playerFighter, Fighter enemyFighter)
        {
            while (playerFighter.GetAlive() && enemyFighter.GetAlive())
            {
                playerFighter.Attack(enemyFighter);

                Console.WriteLine(playerFighter.GetName() + " attacked " + enemyFighter.GetName() + ", " + enemyFighter.GetName() + " now has: " + enemyFighter.GetHP() + " HP");

                enemyFighter.Attack(playerFighter);

                Console.WriteLine(enemyFighter.GetName() + " attacked " + playerFighter.GetName() + ", " + playerFighter.GetName() + " now has: " + playerFighter.GetHP() + " HP\nPress ENTER to continue");

                Console.ReadLine();

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