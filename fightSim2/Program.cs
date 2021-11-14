using System;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fighter instances are created here
            FightSequence fightSequence = new FightSequence();
            Fighter enemyFighter = new Fighter();
            Fighter playerFighter = new Fighter();

            //inital name giving for both enemy and player
            enemyFighter.GiveRandomName();

            Console.WriteLine("Welcome to FightSim 2.0!\nPress Enter to continue");

            Console.ReadLine();

            playerFighter.GiveName();

            Console.Clear();

            Console.WriteLine(playerFighter.GetName() + " and " + enemyFighter.GetName() + " will now fight till death!");

            fightSequence.Fight(playerFighter, enemyFighter);

            Console.ReadLine();

        }
    }
}
