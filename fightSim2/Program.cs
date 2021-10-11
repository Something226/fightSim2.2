using System;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fighter instances are created here
            Fighter enemyFighter = new Fighter();
            Fighter playerFighter = new Fighter();

            //inital name giving for both enemy and player
            enemyFighter.GiveRandomName();

            Console.WriteLine("Welcome to FightSim 2.0!\nPress Enter to continue");

            Console.ReadLine();

            playerFighter.GiveName();

            Console.Clear();

            Console.WriteLine(playerFighter.GetName() + " and " + enemyFighter.GetName() + " will now fight till death!");

            //While-loop that loops the fight
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


            Console.ReadLine();

        }
    }
}
