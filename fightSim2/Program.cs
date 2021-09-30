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

            Console.WriteLine(playerFighter.name + " and " + enemyFighter.name + " will now fight till death!");

            //While-loop that loops the fight
            while (playerFighter.isAlive || enemyFighter.isAlive)
            {
                playerFighter.Attack(enemyFighter);

                enemyFighter.Attack(playerFighter);

                Console.WriteLine(playerFighter.name + " attacked " + enemyFighter.name + ", " + enemyFighter.name + " now has: " + enemyFighter.hp + " HP");
                Console.WriteLine(enemyFighter.name + " attacked " + playerFighter.name + ", " + playerFighter.name + " now has: " + playerFighter.hp + " HP\nPress ENTER to continue");

                Console.ReadLine();

                playerFighter.IsAlive();
                enemyFighter.IsAlive();

            }

            //if-statments checks who won
            if (!playerFighter.isAlive)
            {
                Console.WriteLine(enemyFighter.name + " won!");
            }
            else if (!enemyFighter.isAlive)
            {
                Console.WriteLine(playerFighter + " won!");
            }

            Console.ReadLine();

        }
    }
}
