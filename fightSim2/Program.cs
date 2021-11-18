using System;
using System.Collections.Generic;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class instances are created here
            FightSequence fightSequence = new FightSequence();

            Dictionary<string, Fighter> fighter = new Dictionary<string, Fighter>();

            fighter.Add("player", new PlayerFighter());
            fighter.Add("tempEnemy", new EnemyFighter());

            //inital name giving for both enemy and player
            fighter["tempEnemy"].GiveRandomName();

            Console.WriteLine("Welcome to FightSim 2.0!\nPress Enter to continue");

            Console.ReadLine();

            Console.Clear();

            fighter["player"].GiveName();

            Console.Clear();

            fightSequence.Fight(fighter["player"], fighter["tempEnemy"]);

            Console.ReadLine();

        }
    }
}
