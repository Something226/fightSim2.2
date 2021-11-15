using System;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class instances are created here
            FightSequence fightSequence = new FightSequence();
            Fighter enemyFighter = new EnemyFighter();
            Fighter playerFighter = new PlayerFighter();

            //inital name giving for both enemy and player
            enemyFighter.GiveRandomName();

            Console.WriteLine("Welcome to FightSim 2.0!\nPress Enter to continue");

            Console.ReadLine();

            Console.Clear();

            playerFighter.GiveName();

            Console.Clear();

            fightSequence.Fight(playerFighter, enemyFighter);

            Console.ReadLine();

        }
    }
}
