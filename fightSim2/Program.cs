using System;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter enemyFighter = new Fighter();
            Fighter playerFighter = new Fighter();

            playerFighter.GiveName();

            Console.WriteLine(playerFighter.name);

            playerFighter.Attack(enemyFighter);

            Console.ReadLine();
        }
    }
}
